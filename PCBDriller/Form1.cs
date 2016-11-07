using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace PCBDriller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            mainForm = this;
            InitializeComponent();
        }
        #region variables
        private Bitmap image;
        public static Form1 mainForm;
        private int imgWidth = 0;//width of the image locked in the memory
        private BitmapData bitmapData;
        unsafe private byte* pBase;

        private int ACCURACY = 5;
        private int MAX_ITERATIONS = 100;
        //private int cur_h_val;

        private Point currentCursorPos;

        ArrayList tempPoints = new ArrayList();

        ArrayList drillPoints = new ArrayList();
        ArrayList boundingBoxes = new ArrayList();
        ArrayList optimizedList = new ArrayList();

        ArrayList _0_7mmList = new ArrayList();
        ArrayList _0_9mmList = new ArrayList();
        ArrayList _1_0mmList = new ArrayList();
        ArrayList _1_1mmList = new ArrayList();
        ArrayList _1_5mmList = new ArrayList();
        ArrayList _2_1mmList = new ArrayList();
        ArrayList _3_0mmList = new ArrayList();

        private bool enhace = false;
        public bool useNearestNeighbour = true;
        //private bool mousePressed = false;

        private Color holeColor;
        private Color lineColor;

        private wait w;

        private bool settingColors = false;
        private bool lineColorSet = false;
        #endregion

        private delegate void myDelegate();
        public struct PixelData
        {
            public byte B;
            public byte G;
            public byte R;
        }
        unsafe public PixelData* pixelAt(int x, int y)
        {
            return (PixelData*)((int)pBase + y * imgWidth + x * sizeof(PixelData));
        }

        private bool setColors()
        {
            lblStStatus.Text = "Setting Colors...";
            if (MessageBox.Show("You can set the calors manually, or Let the program decide the colors for you\n \nPress Yes to Auto detect the colors.\nPress No to Manually set the colors.", "PCB Driller", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                holeColor = Color.FromArgb(255, 255, 255, 255);
                lineColor = Color.FromArgb(255, 0, 0, 0);
                lblHoleColor.BackColor = holeColor;
                lblLineColor.BackColor = lineColor;
                return true;
            }
            else
            {
                MessageBox.Show("Please selects the line color");
                lblLineColor.Text = "Pending..";
                settingColors = true;
                lineColorSet = false;
                return false;
            }
        }
        private void setImage()
        {
            lblStStatus.Text = "Loading Image...";
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                string path = openFileDialog1.FileName;
                try
                {
                    image = new Bitmap(path);
                    pictureBox1.Image = image;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "PCB Driller Runtime error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                clearLists();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                if (MessageBox.Show("No Image to Analyse! \n \n Do you want to load an image now?", "PCB Driller", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    setImage();
                else return;
            }

            lblStStatus.Text = "Idle...";
            if (holeColor.Equals(lineColor))
            {
                if(!setColors())
                    return;
            }

            //image = new Bitmap(pictureBox1.Image);//*****************************
            if (btnEnhance.Text == "Finalize"||drillPoints.Count>0||optimizedList.Count>0)
            {
                if (MessageBox.Show("Do you want to finalyze and Continue?\n \n WARNING ! All the point data will be lost.", "PCB Driller", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    button3_Click(sender, e);
                }
                else return;
            }
            lblStStatus.Text = "Idle...";
            clearLists();
            if (chkHighContrast.Checked)
            {
                if (MessageBox.Show("You have selected to make the image High Contrast before Analysing. \n \n Press Yes to Continue.", "PCB Driller", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (!bw_highContrast.IsBusy)
                    {
                        lblStStatus.Text = "Changing Contrast...";
                        btnAnalyse.Enabled = false;
                        btnDrill.Enabled = false;
                        btnEnhance.Enabled = false;
                        btnSetColor.Enabled = false;
                        btnOptimize.Enabled = false;
                        bw_highContrast.RunWorkerAsync();
                        w = new wait();
                        w.ShowDialog();
                        drawAllThePoints();
                    }
                }
                else analyseImage();
            }
            lblStStatus.Text = "Idle...";
            
        }
        private void clearLists()
        {
            drillPoints.Clear();
            boundingBoxes.Clear();
            _0_7mmList.Clear();
            _0_9mmList.Clear();
            _1_0mmList.Clear();
            _3_0mmList.Clear();
            _3_0mmList.Clear();
            lbAllDrliiPoints.Items.Clear();
            optimizedList.Clear();
            foreach (Control c in groupBox5.Controls)
            {
                if (c.GetType() == typeof(Label))
                {
                    if (c.Width > 90)
                        c.Text = "0";
                }
            }
        }
        unsafe private void analyseImage()
        {
            pictureBox1.Refresh();
            lbAllDrliiPoints.Items.Clear();
            lblTot.Text = "0";
            lblStStatus.Text = "Analysing Image...";
            Point size = PixelSize();

            LockBitmap();
            Color c;

            //image.UnlockBits(bitmapData);
 
            bool inBusiness = false;
            unsafe
            {
                for (int x = 1; x < size.X - 1; x++)
                {
                    for (int y = 1; y < size.Y - 1; y++)
                    {
                        if (x > bitmapData.Width || y > bitmapData.Height) return;
                        PixelData* pPixel = pixelAt(x, y);
                        c = Color.FromArgb(pPixel->R, pPixel->G, pPixel->B);

                        if (c.Equals(lineColor) && !inBusiness) inBusiness = true;

                        if (c.Equals(holeColor) && inBusiness)
                        {
                            if (checkPoint(x, y)<0)
                                testFunc(x, y);
                            inBusiness = false;
                        }
                    }
                    int per = (x * 100 / size.X)+1;
                    w.lblPerce.Text = per.ToString();
                    pBar.Value = per;
                }
            }
            image.UnlockBits(bitmapData);
            lblStStatus.Text = "Analysing Image...";
        }
        unsafe private void LockBitmap()
        {
            GraphicsUnit unit = GraphicsUnit.Pixel;
            RectangleF boundsF = image.GetBounds(ref unit);
            Rectangle bounds = new Rectangle((int)boundsF.X,
                (int)boundsF.Y,
                (int)boundsF.Width,
                (int)boundsF.Height);

            imgWidth = (int)boundsF.Width * sizeof(PixelData);
            if (imgWidth % 4 != 0)
            {
                imgWidth = 4 * (imgWidth / 4 + 1);
            }

            bitmapData =image.LockBits(bounds, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            pBase = (Byte*)bitmapData.Scan0.ToPointer();
        }
        public Point PixelSize()
        {
            GraphicsUnit unit = GraphicsUnit.Pixel;
            RectangleF bounds = image.GetBounds(ref unit);
            return new Point((int)bounds.Width, (int)bounds.Height);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (settingColors)
            {
                Bitmap bTemp = new Bitmap(pictureBox1.Image);
                Point p = pictureBox1.PointToClient(Cursor.Position);
                if (p.X < bTemp.Width && p.Y < bTemp.Height)
                {
                    lblCurrentColor.BackColor = bTemp.GetPixel(p.X, p.Y);
                    lblRGB.Text = lblCurrentColor.BackColor.ToString();
                }
            }
            if (enhace) enhanceDrillPoints();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (settingColors)
            {
                if (!lineColorSet)
                {
                    lineColor = lblCurrentColor.BackColor;
                    lblLineColor.BackColor = lineColor;
                    lblLineColor.Text = "";
                    lineColorSet = true;
                    MessageBox.Show("Please selects the hole color");
                    lblHoleColor.Text = "Pending..";
                }
                else
                {
                    holeColor = lblCurrentColor.BackColor;
                    lblHoleColor.BackColor = holeColor;
                    lblHoleColor.Text = "";
                    lblRGB.Text = "";
                    settingColors = false;
                }
            }
            if (enhace)
            {
                manualPointInsertion(e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                if (MessageBox.Show("No Image to Get colors! \n \n Do you want to load an image now?", "PCB Driller", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    setImage();
                else return;
            }
            setColors();
        }
        
        private void addDrillPoint(int x, int y,int w,int h)
        {
            drawLint(new Point(x - (int)nmCrossHL.Value / 2, y), new Point(x + (int)nmCrossHL.Value / 2, y),Color.Red,Rectangle.Empty);
            drawLint(new Point(x, y - (int)nmCrossHL.Value / 2), new Point(x, y + (int)nmCrossHL.Value / 2),Color.Red,Rectangle.Empty);

            drillPoints.Add(new Point(x, y));
            Rectangle tempRec = new Rectangle(x - w / 2, y - h / 2, w, h);

            double pixel = (tempRec.Height + tempRec.Width) / 2.0;
            double mm = (25.4*pixel/300)+0.9;//convert pixel to mm
            
            //MessageBox.Show(mm.ToString());
            
            if (mm >= 0.9 && mm <= 1.1)
            {
                _1_0mmList.Add(new Point(x, y));//1 mm
            }
            else if (mm > 1.75 && mm <= 3.1)
            {
                _3_0mmList.Add(new Point(x, y));//3 mm
            }
            else if (mm > 1.1 && mm <= 1.75)
            {
                _1_5mmList.Add(new Point(x, y));//1.5 mm
            }
            //else if (mm >= 2.9 && mm <= 3.1)
            //{
            //    _3_0mmList.Add(new Point(x, y));//3mm
            //}

            tempRec.Inflate(1, 1);//inflate to avoid duplicated points sitting on each other.
            
            boundingBoxes.Add(tempRec);
            lbAllDrliiPoints.Items.Add(new Point(x, y).ToString());
            lbl0_7.Text = _0_7mmList.Count.ToString();
            lbl1_0.Text = _1_0mmList.Count.ToString();
            lbl3_0.Text = _3_0mmList.Count.ToString();
            lbl1_5.Text = _1_5mmList.Count.ToString();//-------------------------------------------------------------------------------------------
            lblTot.Text = lbAllDrliiPoints.Items.Count.ToString();
           
        }
        private int checkPoint(int x, int y)
        {
            Rectangle r;
            for (int i = 0; i < boundingBoxes.Count; i++)
            {
                r = (Rectangle)boundingBoxes[i];
                if(r.Contains(x,y))
                {
                    //MessageBox.Show("Contains"+ "X= "+x.ToString()+" Y= "+y.ToString()+"  "+r.ToString());
                    return i;
                }
            }
            return -1;
        }
        private void manualPointInsertion(MouseEventArgs e)
        {
            if (checkPoint(currentCursorPos.X, currentCursorPos.Y)>=0)
            {
                if(e.Button==MouseButtons.Right)
                    removePoint(currentCursorPos.X,currentCursorPos.Y);

                return;
            }
            if(e.Button==MouseButtons.Left)
                addDrillPoint(currentCursorPos.X, currentCursorPos.Y, 5, 5);

        }
        private void removePoint(int x, int y)
        {
            int index = checkPoint(x, y);
            drillPoints.RemoveAt(index);
            boundingBoxes.RemoveAt(index);
            lbAllDrliiPoints.Items.RemoveAt(index);
            lblTot.Text = lbAllDrliiPoints.Items.Count.ToString();
            drawAllThePoints();
        }
        private void drawAllThePoints()
        {
            if (drillPoints.Count <= 0 || boundingBoxes.Count <= 0) return;
            pictureBox1.Refresh();
            Point p;
            Rectangle r;
            //for (int i = 0; i < drillPoints.Count; i++)
            //{//******Drawing all the holes***************************
            //    p = (Point)drillPoints[i];
            //    if (chkDrawRec.Checked && i < boundingBoxes.Count)
            //    {
            //        r = (Rectangle)boundingBoxes[i];
            //    }
            //    else
            //    {
            //        r = Rectangle.Empty;
            //    }
            //    if (chkCrossHair.Checked)
            //    {
            //        drawLint(new Point(p.X - (int)nmCrossHL.Value / 2, p.Y), new Point(p.X + (int)nmCrossHL.Value / 2, p.Y), Color.Red, r);
            //        drawLint(new Point(p.X, p.Y - (int)nmCrossHL.Value / 2), new Point(p.X, p.Y + (int)nmCrossHL.Value / p.Y), Color.Red, r);
            //    }
            //}

            
            if (chkDrawRec.Checked && boundingBoxes.Count>0)
            {
                for (int i = 0; i < boundingBoxes.Count; i++)
                {//******Drawing Bounding boxes ***************************
                    p = new Point(-1, -1);
                    r = (Rectangle)boundingBoxes[i];
                    drawLint(p,p, Color.Red, r);
                }
            }

            //Drawing points (Cross hair)
            if (chkCrossHair.Checked && cb_07Pt.Checked)
            {
                for (int i = 0; i < _0_7mmList.Count; i++)
                {//********** Drawing 0.7 mm Holes************************
                    p = (Point)_0_7mmList[i];
                    r = Rectangle.Empty;
                    drawLint(new Point(p.X - (int)nmCrossHL.Value / 2, p.Y), new Point(p.X + (int)nmCrossHL.Value / 2, p.Y), Color.Red, r);
                    drawLint(new Point(p.X, p.Y - (int)nmCrossHL.Value / 2), new Point(p.X, p.Y + (int)nmCrossHL.Value / p.Y), Color.Red, r);
                }
            }
            if (chkCrossHair.Checked && cb_09Pt.Checked)
            {
                for (int i = 0; i < _0_9mmList.Count; i++)
                {//********** Drawing 0.9 mm Holes************************
                    p = (Point)_0_9mmList[i];
                    r = Rectangle.Empty;
                    drawLint(new Point(p.X - (int)nmCrossHL.Value / 2, p.Y), new Point(p.X + (int)nmCrossHL.Value / 2, p.Y), Color.Red, r);
                    drawLint(new Point(p.X, p.Y - (int)nmCrossHL.Value / 2), new Point(p.X, p.Y + (int)nmCrossHL.Value / p.Y), Color.Red, r);
                }
            }
            if (chkCrossHair.Checked && cb_10Pt.Checked)
            {
                for (int i = 0; i < _1_0mmList.Count; i++)
                {//********** Drawing 1.0 mm Holes************************
                    p = (Point)_1_0mmList[i];
                    r = Rectangle.Empty;
                    drawLint(new Point(p.X - (int)nmCrossHL.Value / 2, p.Y), new Point(p.X + (int)nmCrossHL.Value / 2, p.Y), Color.Red, r);
                    drawLint(new Point(p.X, p.Y - (int)nmCrossHL.Value / 2), new Point(p.X, p.Y + (int)nmCrossHL.Value / p.Y), Color.Red, r);
                }
            }
            if (chkCrossHair.Checked && cb_15Pt.Checked)
            {
                for (int i = 0; i < _1_5mmList.Count; i++)
                {//********** Drawing 1.5 mm Holes************************
                    p = (Point)_1_5mmList[i];
                    r = Rectangle.Empty;
                    drawLint(new Point(p.X - (int)nmCrossHL.Value / 2, p.Y), new Point(p.X + (int)nmCrossHL.Value / 2, p.Y), Color.Red, r);
                    drawLint(new Point(p.X, p.Y - (int)nmCrossHL.Value / 2), new Point(p.X, p.Y + (int)nmCrossHL.Value / p.Y), Color.Red, r);
                }
            }
            if (chkCrossHair.Checked && cb_21Pt.Checked)
            {
                for (int i = 0; i < _2_1mmList.Count; i++)
                {//********** Drawing 2.1 mm Holes************************
                    p = (Point)_2_1mmList[i];
                    r = Rectangle.Empty;
                    drawLint(new Point(p.X - (int)nmCrossHL.Value / 2, p.Y), new Point(p.X + (int)nmCrossHL.Value / 2, p.Y), Color.Red, r);
                    drawLint(new Point(p.X, p.Y - (int)nmCrossHL.Value / 2), new Point(p.X, p.Y + (int)nmCrossHL.Value / p.Y), Color.Red, r);
                }
            }
            if (chkCrossHair.Checked && cb_30Pt.Checked)
            {
                for (int i = 0; i < _3_0mmList.Count; i++)
                {//********** Drawing 3.0 mm Holes************************
                    p = (Point)_3_0mmList[i];
                    r = Rectangle.Empty;

                    drawLint(new Point(p.X - (int)nmCrossHL.Value / 2, p.Y), new Point(p.X + (int)nmCrossHL.Value / 2, p.Y), Color.Red, r);
                    drawLint(new Point(p.X, p.Y - (int)nmCrossHL.Value / 2), new Point(p.X, p.Y + (int)nmCrossHL.Value / p.Y), Color.Red, r);
                }
            }

            //if (optimizedList.Count > 0)
            //{
            //    for (int i = 0; i < optimizedList.Count - 1; i++)
            //    {
            //        drawLint((Point)optimizedList[i], (Point)optimizedList[i + 1], Color.SpringGreen,Rectangle.Empty);
            //    }
            //}


            //Drawing paths
            if (_0_7mmList.Count > 0 && cb_07Path.Checked)
            {
                for (int i = 0; i < _0_7mmList.Count - 1; i++)
                {
                    drawLint((Point)_0_7mmList[i], (Point)_0_7mmList[i + 1], Color.SpringGreen, Rectangle.Empty);
                }
            }
            if (_0_9mmList.Count > 0 && cb_09Path.Checked)
            {
                for (int i = 0; i < _0_9mmList.Count - 1; i++)
                {
                    drawLint((Point)_0_9mmList[i], (Point)_0_9mmList[i + 1], Color.SpringGreen, Rectangle.Empty);
                }
            }
            if (_1_0mmList.Count > 0 && cb_10Path.Checked)
            {
                for (int i = 0; i < _1_0mmList.Count - 1; i++)
                {
                    drawLint((Point)_1_0mmList[i], (Point)_1_0mmList[i + 1], Color.SpringGreen, Rectangle.Empty);
                }
            }
            if (_1_1mmList.Count > 0 && cb_11Path.Checked)
            {
                for (int i = 0; i < _1_1mmList.Count - 1; i++)
                {
                    drawLint((Point)_1_1mmList[i], (Point)_1_1mmList[i + 1], Color.SpringGreen, Rectangle.Empty);
                }
            }
            if (_1_5mmList.Count > 0 && cb_15Path.Checked)
            {
                for (int i = 0; i < _1_5mmList.Count - 1; i++)
                {
                    drawLint((Point)_1_5mmList[i], (Point)_1_5mmList[i + 1], Color.SpringGreen, Rectangle.Empty);
                }
            }
            if (_2_1mmList.Count > 0 && cb_21Path.Checked)
            {
                for (int i = 0; i < _2_1mmList.Count - 1; i++)
                {
                    drawLint((Point)_2_1mmList[i], (Point)_2_1mmList[i + 1], Color.SpringGreen, Rectangle.Empty);
                }
            }
            if (_3_0mmList.Count > 0 && cb_30Path.Checked)
            {
                for (int i = 0; i < _3_0mmList.Count - 1; i++)
                {
                    drawLint((Point)_3_0mmList[i], (Point)_3_0mmList[i + 1], Color.SpringGreen, Rectangle.Empty);
                }
            }
            
            //Drawing starting point
            if (optimizedList.Count > 0 && chkStart.Checked)
            {
                Graphics g = pictureBox1.CreateGraphics();
                Point pp = (Point)optimizedList[0];
                g.DrawLine(new Pen(Color.Yellow, 2), pp, new Point(pp.X + 10, pp.Y + 10));
                g.FillRectangle(Brushes.Yellow, new Rectangle(new Point(pp.X + 10, pp.Y + 10), new Size(30, 14)));
                g.DrawString("Start", new Font("Times New Roman", 9), Brushes.Black, new PointF(pp.X + 12, pp.Y + 10));
            }
        }
        private void drawLint(Point p1, Point p2,Color c,Rectangle rec)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.DrawLine(new Pen(c, 1), p1, p2);
            if (rec != Rectangle.Empty)
            {
                rec.Inflate((int)nmInflate.Value, (int)nmInflate.Value);
                g.DrawRectangle(new Pen(Color.Blue, 1), rec);
            }
        }

        unsafe private void testFunc(int x, int y)//Main Function to identify the shapes.
        {
            
            Color C_N,C_NE,C_E,C_SE,C_S,C_SW,C_W,C_NW;
            PixelData* pPixel;

            Point prev = new Point(0,0);
            Point current = new Point(x, y);
            Point OriginalLoca = new Point(x, y);
            bool foundMatch=false;

            tempPoints.Clear();

            for (int i = 0; i < MAX_ITERATIONS; i++)
            {
                if (current.Equals(OriginalLoca) && i > 0)
                {
                    foundCircle();
                    break;
                }
                foundMatch = false;
                tempPoints.Add(current);
                try
                {
                    //************North***************
                    pPixel = pixelAt(current.X, current.Y - 1);
                    C_N = Color.FromArgb(pPixel->R, pPixel->G, pPixel->B);

                    //************North-East***************
                    pPixel = pixelAt(current.X + 1, current.Y - 1);
                    C_NE = Color.FromArgb(pPixel->R, pPixel->G, pPixel->B);

                    //************East***************
                    pPixel = pixelAt(current.X + 1, current.Y);
                    C_E = Color.FromArgb(pPixel->R, pPixel->G, pPixel->B);

                    //************South-East***************
                    pPixel = pixelAt(current.X + 1, current.Y+1);
                    C_SE = Color.FromArgb(pPixel->R, pPixel->G, pPixel->B);

                    //************South***************
                    pPixel = pixelAt(current.X, current.Y + 1);
                    C_S = Color.FromArgb(pPixel->R, pPixel->G, pPixel->B);

                    //************South-West***************
                    pPixel = pixelAt(current.X - 1, current.Y + 1);
                    C_SW = Color.FromArgb(pPixel->R, pPixel->G, pPixel->B);

                    //************West***************
                    pPixel = pixelAt(current.X - 1, current.Y);
                    C_W = Color.FromArgb(pPixel->R, pPixel->G, pPixel->B);

                    //************North-West***************
                    pPixel = pixelAt(current.X - 1, current.Y - 1);
                    C_NW = Color.FromArgb(pPixel->R, pPixel->G, pPixel->B);

                    //listBox1.Items.Add(prev.ToString() + " - " + current.ToString());

                    if (!C_NW.Equals(C_N))
                    {
                        if (C_NW.Equals(holeColor) && (prev.X != current.X - 1 || prev.Y != current.Y - 1))
                        {
                            prev = current;
                            current.X -= 1;
                            current.Y -= 1;
                            foundMatch = true;
                        }
                        else if (prev.X != current.X || prev.Y != current.Y - 1)
                        {
                            prev = current;
                            current.Y -= 1;
                            foundMatch = true;
                        }
                    }
                    if (!C_N.Equals(C_NE) && !foundMatch)
                    {
                        if (C_N.Equals(holeColor) && (prev.X != current.X || prev.Y != current.Y - 1))
                        {
                            prev = current;
                            current.Y -= 1;
                            foundMatch = true;
                        }
                        else if (prev.X != current.X + 1 || prev.Y != current.Y - 1)
                        {
                            prev = current;
                            current.X += 1;
                            current.Y -= 1;
                            foundMatch = true;
                        }
                    }
                    if (!C_NE.Equals(C_E) && !foundMatch)
                    {
                        if (C_NE.Equals(holeColor) && (prev.X != current.X + 1 || prev.Y != current.Y - 1))
                        {
                            prev = current;
                            current.Y -= 1;
                            current.X += 1;
                            foundMatch = true;
                        }
                        else if (prev.X != current.X + 1 || prev.Y != current.Y)
                        {
                            prev = current;
                            current.X += 1;
                            foundMatch = true;
                        }
                    }
                    if (!C_E.Equals(C_SE) && !foundMatch)
                    {
                        if (C_E.Equals(holeColor) && (prev.X != current.X + 1 || prev.Y != current.Y))
                        {
                            prev = current;
                            current.X += 1;
                            foundMatch = true;
                        }
                        else if (prev.X != current.X + 1 || prev.Y != current.Y + 1)
                        {
                            prev = current;
                            current.X += 1;
                            current.Y += 1;
                            foundMatch = true;
                        }
                    }
                    if (!C_SE.Equals(C_S) && !foundMatch)
                    {
                        if (C_SE.Equals(holeColor) && (prev.X != current.X + 1 || prev.Y != current.Y + 1))
                        {
                            prev = current;
                            current.X += 1;
                            current.Y += 1;
                            foundMatch = true;
                        }
                        else if (prev.X != current.X || prev.Y != current.Y + 1)
                        {
                            prev = current;
                            current.Y += 1;
                            foundMatch = true;
                        }
                    }
                    if (!C_S.Equals(C_SW) && !foundMatch)
                    {
                        if (C_S.Equals(holeColor) && (prev.X != current.X || prev.Y != current.Y + 1))
                        {
                            prev = current;
                            current.Y += 1;
                            foundMatch = true;
                        }
                        else if (prev.X != current.X - 1 || prev.Y != current.Y + 1)
                        {
                            prev = current;
                            current.X -= 1;
                            current.Y += 1;
                            foundMatch = true;
                        }
                    }
                    if (!C_SW.Equals(C_W) && !foundMatch)
                    {
                        if (C_SW.Equals(holeColor) && (prev.X != current.X - 1 || prev.Y != current.Y + 1))
                        {
                            prev = current;
                            current.X -= 1;
                            current.Y += 1;
                            foundMatch = true;
                        }
                        else if (prev.X != current.X - 1 || prev.Y != current.Y)
                        {
                            prev = current;
                            current.X -= 1;
                            foundMatch = true;
                        }
                    }
                    if (!C_W.Equals(C_NW) && !foundMatch)
                    {
                        if (C_W.Equals(holeColor) && (prev.X != current.X - 1 || prev.Y != current.Y))
                        {
                            prev = current;
                            current.X -= 1;
                        }
                        else if (prev.X != current.X - 1 || prev.Y != current.Y - 1)
                        {
                            prev = current;
                            current.X -= 1;
                            current.Y -= 1;
                        }
                    }

                }
                catch (AccessViolationException)
                {
                    MessageBox.Show("Memory Access Voilation.\nApplication needs to be closed.","PCB Driller Runtime Error.",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Thread.CurrentThread.Abort();
                }
            }
            //draw();
        }
        private void foundCircle()
        {
            int min_x = bitmapData.Width, min_y = bitmapData.Height, max_x = 0, max_y = 0;
            int w = 0;
            int h = 0;

            if (tempPoints.Count > 1)
            {
                Point p = new Point(0, 0);
                //Bitmap b = new Bitmap(bitmapData.Width, bitmapData.Height, PixelFormat.Format24bppRgb);
                for(int i=0;i<tempPoints.Count;i++)
                {
                    p = (Point)tempPoints[i];

                    if (p.X < min_x) min_x = p.X;
                    if (p.X > max_x) max_x = p.X;
                    if (p.Y < min_y) min_y = p.Y;
                    if (p.Y > max_y) max_y = p.Y;
                }
                w = max_x - min_x;
                h = max_y - min_y;
                if (w <= h + (int)nmCircleDev.Value && w >= h - (int)nmCircleDev.Value)
                {
                    int midX = min_x + (w / 2);
                    int midY = min_y + (h / 2);
                    if (checkCenterColor(midX, midY))
                    {
                        addDrillPoint(midX, midY, w, h);
                    }
                }
                
            }
            //MessageBox.Show(tempPoints.Count.ToString());
        }
        unsafe private bool checkCenterColor(int x, int y)
        {
            int ac = 0;
            PixelData* pPix;
            pPix= pixelAt(x, y);
            Color c1 = Color.FromArgb(pPix->R, pPix->G, pPix->B);

            pPix = pixelAt(x, y-1);
            Color c2 = Color.FromArgb(pPix->R, pPix->G, pPix->B);

            pPix = pixelAt(x+1, y);
            Color c3 = Color.FromArgb(pPix->R, pPix->G, pPix->B);

            pPix = pixelAt(x, y+1);
            Color c4 = Color.FromArgb(pPix->R, pPix->G, pPix->B);

            pPix = pixelAt(x-1, y);
            Color c5 = Color.FromArgb(pPix->R, pPix->G, pPix->B);

            if (c1.Equals(holeColor)) ac++;
            if (c2.Equals(holeColor)) ac++;
            if (c3.Equals(holeColor)) ac++;
            if (c4.Equals(holeColor)) ac++;
            if (c5.Equals(holeColor)) ac++;

            if(ac>=ACCURACY)return true;
            else return false;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
           
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setImage();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (btnEnhance.Text == "Edit")
            {
                btnAnalyse.Enabled = false;
                btnSetColor.Enabled = false;
                btnLoadImage.Enabled = false;
                enhace = true;
                pictureBox1.Cursor = Cursors.Cross;
                drawCrossHair(true);
                btnEnhance.Text = "Finalize";
                grpEdit.Enabled = true;
                foreach (Control cb in groupBox5.Controls)
                {
                    if (cb.GetType() == typeof(CheckBox))
                    {
                        CheckBox b = (CheckBox)cb;
                        b.Checked = false;
                        b.Enabled = false;
                    }
                }
            }
            else
            {
                btnAnalyse.Enabled = true;
                btnSetColor.Enabled = true;
                btnLoadImage.Enabled = true;
                enhace = false;
                pictureBox1.Cursor = Cursors.Default;
                drawCrossHair(false);
                btnEnhance.Text = "Edit";
                lblCurLoc.BackColor = Color.Gainsboro;
                pictureBox2.Image = null;
                grpEdit.Enabled = false;
                foreach (Control cb in groupBox5.Controls)
                {
                    if (cb.GetType() == typeof(CheckBox))
                    {
                        CheckBox b = (CheckBox)cb;
                        //b.Checked = false;
                        b.Enabled = true;
                    }
                }
            }
            //Actual function is in the picturebox mouse move eventn
        }
        private void enhanceDrillPoints()
        {
            int si = pictureBox2.Width / (int)nmZoom.Value;
            Bitmap b = new Bitmap(si,si);
            Graphics g = Graphics.FromImage(b);
            g.InterpolationMode = InterpolationMode.NearestNeighbor;
            Point p = Cursor.Position;

            currentCursorPos = pictureBox1.PointToClient(p);
            lblCurLoc.Text = currentCursorPos.ToString();
            if (checkPoint(currentCursorPos.X, currentCursorPos.Y) < 0)
                lblCurLoc.BackColor = Color.LightGreen;
            else
                lblCurLoc.BackColor = Color.Tomato;

            p.Offset(-si/2, -si/2);
            g.Flush();
            g.CopyFromScreen(p, new Point(0, 0), new Size(si, si));

            pictureBox2.Image = b;
            //drawCrossHair();
        }
        private void drawCrossHair(bool sh)
        {
            if (sh)
            {
                hHair.Visible = true;
                vHair.Visible = true;
            }
            else
            {
                hHair.Visible = false;
                vHair.Visible = false;
            }
        }

        private void nmMaxIterations_ValueChanged(object sender, EventArgs e)
        {
            MAX_ITERATIONS =(int)nmMaxIterations.Value;
        }

        private void nmAccuracy_ValueChanged(object sender, EventArgs e)
        {
            ACCURACY = (int)nmAccuracy.Value;
        }

        private void bw_highContrast_DoWork(object sender, DoWorkEventArgs e)
        {
            //MessageBox.Show("Hello !");
            double p = 0.0;
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color cc = image.GetPixel(x, y);
                    int c = (cc.R + cc.G + cc.B) / 3;
                    if (c < (int)nmThreshold.Value)
                    {
                        image.SetPixel(x, y, Color.FromArgb(255, 0, 0, 0));
                    }
                    else
                        image.SetPixel(x, y, Color.FromArgb(255, 255, 255, 255));
                }
                p =(x*100 / image.Width);
                bw_highContrast.ReportProgress((int)p);
            }
        }

        private void bw_highContrast_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pBar.Value = e.ProgressPercentage;
            string p = e.ProgressPercentage.ToString();
            if (e.ProgressPercentage < 10)
                p = "0" + p;
            w.lblPerce.Text = p;
            lblStStatus.Text = "Analyzing image..Completed - " + e.ProgressPercentage.ToString(); ;
        }

        private void threadFunc()
        {
            myDelegate del = new myDelegate(analyseImage);
            //analyseImage();
            BeginInvoke(del);
        }

        private void bw_highContrast_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pBar.Value = 0;
            //analyseImage();
          
            Thread t = new Thread(new ThreadStart(threadFunc));
            t.Start();
            t.Join();
            //MessageBox.Show("SSSSS");

            btnAnalyse.Enabled = true;
            btnEnhance.Enabled = true;
            btnDrill.Enabled = true;
            btnSetColor.Enabled = true;
            btnOptimize.Enabled = true;
            lblStStatus.Text = "Idle...";
            w.Close();
            drawAllThePoints();
        }


        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            setImage();
        }

        private void selColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2_Click(sender,e);
        }

        private void analyseImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void enhanceEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }

        private void btnDrill_Click(object sender, EventArgs e)
        {
            
        }

        private void getOptimalPath()
        {
            //optimizedList.Clear();
            //optimizedList = optimumPath.travelling_Salesman(drillPoints, useNearestNeighbour, pBar, lblStStatus);

            if (_0_7mmList.Count > 0) _0_7mmList = optimumPath.travelling_Salesman(_0_7mmList, useNearestNeighbour, pBar, lblStStatus);
            if (_0_9mmList.Count > 0) _0_9mmList = optimumPath.travelling_Salesman(_0_9mmList, useNearestNeighbour, pBar, lblStStatus);
            if (_1_0mmList.Count > 0) _1_0mmList = optimumPath.travelling_Salesman(_1_0mmList, useNearestNeighbour, pBar, lblStStatus);
            if (_3_0mmList.Count > 0) _3_0mmList = optimumPath.travelling_Salesman(_3_0mmList, useNearestNeighbour, pBar, lblStStatus);
            if (_3_0mmList.Count > 0) _3_0mmList = optimumPath.travelling_Salesman(_3_0mmList, useNearestNeighbour, pBar, lblStStatus);
            //_0_7mmList = optimumPath.travelling_Salesman(_0_7mmList, useNearestNeighbour, pBar, lblStStatus);

            lbAllDrliiPoints.Items.Clear();
            for (int i = 0; i < optimizedList.Count; i++)
            {
                //drawLint((Point)optimizedList[i], (Point)optimizedList[i + 1],Color.Lime);
                lbAllDrliiPoints.Items.Add(optimizedList[i].ToString());
            }
            //lbAllDrliiPoints.Items.Add(optimizedList[optimizedList.Count-1].ToString());
            pictureBox1.Refresh();
            drawAllThePoints();
        }

        private void startDrillingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDrill_Click(sender, e);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {

        }

        private void pauseDrillingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnPause_Click(sender, e);
        }

        private void stopDrillingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDrill_Click(sender, e);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout f = new frmAbout();
            f.ShowDialog();
        }

        private void btnOptimize_Click(object sender, EventArgs e)
        {
            if (btnEnhance.Text == "Finalize")
            {
                if (MessageBox.Show("Current editing has not yet been Finalyzed! \nDo you want to finalyze and Continue?", "PCB Driller", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    button3_Click(sender, e);
                }
                else return;
            }
            if (drillPoints.Count <= 0 || boundingBoxes.Count <= 0)
            {
                MessageBox.Show("No drill points to Continue ", "PCB Driller", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            options opt = new options();
            opt.ShowDialog();
            getOptimalPath();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            fileHandle.writeToFile(optimizedList);
        }

        private void loadDrillPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadDrillPoints();
        }

        private void saveDrillPoinstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileHandle.writeToFile(optimizedList);
        }

        private void btnLoadPoints_Click(object sender, EventArgs e)
        {
            loadDrillPoints();
        }
        private void loadDrillPoints()
        {

            optimizedList = fileHandle.readFromFile();
            if (optimizedList.Count < 1)
            {
                MessageBox.Show("No Drill points were found in the file.", "PCB Driller - Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            optimizedList.Clear();
            pictureBox1.Image = null;
            for (int i = 0; i < optimizedList.Count; i++)
            {
                Point p = (Point)optimizedList[i];
                addDrillPoint(p.X, p.Y, 6, 6);
                lbAllDrliiPoints.Items.Add(optimizedList[i].ToString());
            }
            drawAllThePoints();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            drawAllThePoints();
        }

        private void chkDrawRec_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDrawRec.Checked)
                nmInflate.Enabled = true;
            else
                nmInflate.Enabled = false;
        }

        private void chkHighContrast_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkHighContrast.Checked)
            {
                if (MessageBox.Show("Disabling this option may not give you the expected results! \nDo you want to continue anyway?", "PCB Driller", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    chkHighContrast.Checked = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drillPoints.Count <= 0) return;
            lbAllDrliiPoints.Items.Clear();
            foreach (Control c in groupBox5.Controls)
            {
                if (c.GetType() == typeof(CheckBox))
                {
                    if(c.Name.EndsWith("t"))
                    {
                        CheckBox box = (CheckBox)c;
                        box.Checked = false;
                    }
                }
                
            }
            foreach (Control c in grpEdit.Controls)
            {
                if (c.GetType() == typeof(RadioButton))
                {
                    RadioButton b = (RadioButton)c;
                    b.Checked = false;
                }
            }
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        for (int i = 0; i < drillPoints.Count; i++)
                        {
                            Point p = (Point)drillPoints[i];
                            lbAllDrliiPoints.Items.Add(p.ToString());
                        }
                        foreach (Control c in groupBox5.Controls)
                        {
                            if (c.GetType() == typeof(CheckBox))
                            {
                                if (c.Name.EndsWith("t"))
                                {
                                    CheckBox box = (CheckBox)c;
                                    box.Checked = true;
                                }
                            }
                        }
                        break;
                    }
                case 1:
                    {
                        for (int i = 0; i < _0_7mmList.Count; i++)
                        {
                            Point p = (Point)_0_7mmList[i];
                            lbAllDrliiPoints.Items.Add(p.ToString());
                        }
                        cb_07Pt.Checked = true;
                        radioButton1.Checked = true;
                        break;
                    }
                case 2:
                    {
                        for (int i = 0; i < _0_9mmList.Count; i++)
                        {
                            Point p = (Point)_0_9mmList[i];
                            lbAllDrliiPoints.Items.Add(p.ToString());
                        }
                        cb_09Pt.Checked = true;
                        radioButton2.Checked = true;
                        break;
                    }
                case 3:
                    {
                        for (int i = 0; i < _1_0mmList.Count; i++)
                        {
                            Point p = (Point)_1_0mmList[i];
                            lbAllDrliiPoints.Items.Add(p.ToString());
                        }
                        cb_10Pt.Checked = true;
                        radioButton3.Checked = true;
                        break;
                    }
                case 4:
                    {
                        for (int i = 0; i < _1_1mmList.Count; i++)
                        {
                            Point p = (Point)_1_1mmList[i];
                            lbAllDrliiPoints.Items.Add(p.ToString());
                        }
                        cb_11Pt.Checked = true;
                        radioButton4.Checked = true;
                        break;
                    }
                case 5:
                    {
                        for (int i = 0; i < _1_5mmList.Count; i++)
                        {
                            Point p = (Point)_1_5mmList[i];
                            lbAllDrliiPoints.Items.Add(p.ToString());
                        }
                        cb_15Pt.Checked = true;
                        radioButton5.Checked = true;
                        break;
                    }
                case 6:
                    {
                        for (int i = 0; i < _2_1mmList.Count; i++)
                        {
                            Point p = (Point)_2_1mmList[i];
                            lbAllDrliiPoints.Items.Add(p.ToString());
                        }
                        cb_21Pt.Checked = true;
                        radioButton6.Checked = true;
                        break;
                    }
                case 7:
                    {
                        for (int i = 0; i < _3_0mmList.Count; i++)
                        {
                            Point p = (Point)_3_0mmList[i];
                            lbAllDrliiPoints.Items.Add(p.ToString());
                        }
                        cb_30Pt.Checked = true;
                        radioButton7.Checked = true;
                        break;
                    }
                  
            }
            drawAllThePoints();

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 2;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 3;
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 4;
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 5;
        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 6;
        }

        private void radioButton7_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 7;
        }
    }
}