namespace PCBDriller
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAnalyse = new System.Windows.Forms.Button();
            this.lbAllDrliiPoints = new System.Windows.Forms.ListBox();
            this.btnSetColor = new System.Windows.Forms.Button();
            this.lblCurrentColor = new System.Windows.Forms.Label();
            this.lblHoleColor = new System.Windows.Forms.Label();
            this.lblLineColor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRGB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nmMaxIterations = new System.Windows.Forms.NumericUpDown();
            this.nmAccuracy = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nmZoom = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.chkHighContrast = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkStart = new System.Windows.Forms.CheckBox();
            this.label34 = new System.Windows.Forms.Label();
            this.nmInflate = new System.Windows.Forms.NumericUpDown();
            this.chkDrawRec = new System.Windows.Forms.CheckBox();
            this.chkCrossHair = new System.Windows.Forms.CheckBox();
            this.label32 = new System.Windows.Forms.Label();
            this.nmThreshold = new System.Windows.Forms.NumericUpDown();
            this.label33 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.nmCrossHL = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.nmCircleDev = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDrillPoinstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDrillPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyseImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enhanceEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startDrillingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseDrillingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopDrillingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpOnPCBDrillerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pBar = new System.Windows.Forms.ToolStripProgressBar();
            this.btnEnhance = new System.Windows.Forms.Button();
            this.btnDrill = new System.Windows.Forms.Button();
            this.hHair = new System.Windows.Forms.Label();
            this.vHair = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.grpEdit = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.cb_30Path = new System.Windows.Forms.CheckBox();
            this.cb_30Pt = new System.Windows.Forms.CheckBox();
            this.cb_21Path = new System.Windows.Forms.CheckBox();
            this.cb_21Pt = new System.Windows.Forms.CheckBox();
            this.cb_15Path = new System.Windows.Forms.CheckBox();
            this.cb_15Pt = new System.Windows.Forms.CheckBox();
            this.cb_11Path = new System.Windows.Forms.CheckBox();
            this.cb_11Pt = new System.Windows.Forms.CheckBox();
            this.cb_10Path = new System.Windows.Forms.CheckBox();
            this.cb_10Pt = new System.Windows.Forms.CheckBox();
            this.cb_09Path = new System.Windows.Forms.CheckBox();
            this.cb_09Pt = new System.Windows.Forms.CheckBox();
            this.cb_07Path = new System.Windows.Forms.CheckBox();
            this.cb_07Pt = new System.Windows.Forms.CheckBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblTot = new System.Windows.Forms.Label();
            this.lbl0_7 = new System.Windows.Forms.Label();
            this.lbl3_0 = new System.Windows.Forms.Label();
            this.lbl0_9 = new System.Windows.Forms.Label();
            this.lbl2_1 = new System.Windows.Forms.Label();
            this.lbl1_0 = new System.Windows.Forms.Label();
            this.lbl1_5 = new System.Windows.Forms.Label();
            this.lbl1_1 = new System.Windows.Forms.Label();
            this.bw_highContrast = new System.ComponentModel.BackgroundWorker();
            this.lblCurLoc = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnOptimize = new System.Windows.Forms.Button();
            this.btnLoadPoints = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMaxIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAccuracy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmZoom)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmInflate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCrossHL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCircleDev)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.grpEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnalyse
            // 
            this.btnAnalyse.Location = new System.Drawing.Point(469, 259);
            this.btnAnalyse.Name = "btnAnalyse";
            this.btnAnalyse.Size = new System.Drawing.Size(82, 23);
            this.btnAnalyse.TabIndex = 1;
            this.btnAnalyse.Text = "Analys";
            this.btnAnalyse.UseVisualStyleBackColor = true;
            this.btnAnalyse.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbAllDrliiPoints
            // 
            this.lbAllDrliiPoints.FormattingEnabled = true;
            this.lbAllDrliiPoints.Location = new System.Drawing.Point(6, 42);
            this.lbAllDrliiPoints.Name = "lbAllDrliiPoints";
            this.lbAllDrliiPoints.Size = new System.Drawing.Size(121, 121);
            this.lbAllDrliiPoints.TabIndex = 2;
            // 
            // btnSetColor
            // 
            this.btnSetColor.Location = new System.Drawing.Point(469, 231);
            this.btnSetColor.Name = "btnSetColor";
            this.btnSetColor.Size = new System.Drawing.Size(82, 23);
            this.btnSetColor.TabIndex = 4;
            this.btnSetColor.Text = "Set Colors";
            this.btnSetColor.UseVisualStyleBackColor = true;
            this.btnSetColor.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblCurrentColor
            // 
            this.lblCurrentColor.BackColor = System.Drawing.Color.White;
            this.lblCurrentColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentColor.Location = new System.Drawing.Point(172, 15);
            this.lblCurrentColor.Name = "lblCurrentColor";
            this.lblCurrentColor.Size = new System.Drawing.Size(60, 42);
            this.lblCurrentColor.TabIndex = 5;
            // 
            // lblHoleColor
            // 
            this.lblHoleColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHoleColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoleColor.Location = new System.Drawing.Point(112, 43);
            this.lblHoleColor.Name = "lblHoleColor";
            this.lblHoleColor.Size = new System.Drawing.Size(54, 14);
            this.lblHoleColor.TabIndex = 6;
            // 
            // lblLineColor
            // 
            this.lblLineColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLineColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLineColor.Location = new System.Drawing.Point(112, 18);
            this.lblLineColor.Name = "lblLineColor";
            this.lblLineColor.Size = new System.Drawing.Size(54, 14);
            this.lblLineColor.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Line Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hole Color";
            // 
            // lblRGB
            // 
            this.lblRGB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRGB.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRGB.Location = new System.Drawing.Point(32, 69);
            this.lblRGB.Name = "lblRGB";
            this.lblRGB.Size = new System.Drawing.Size(200, 15);
            this.lblRGB.TabIndex = 10;
            this.lblRGB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRGB);
            this.groupBox1.Controls.Add(this.lblCurrentColor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblHoleColor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblLineColor);
            this.groupBox1.Location = new System.Drawing.Point(587, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 90);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color select";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.hScrollBar1);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 506);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PCB";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar1.Location = new System.Drawing.Point(3, 487);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(415, 16);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.Visible = false;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Max Iterations";
            // 
            // nmMaxIterations
            // 
            this.nmMaxIterations.Location = new System.Drawing.Point(105, 19);
            this.nmMaxIterations.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmMaxIterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmMaxIterations.Name = "nmMaxIterations";
            this.nmMaxIterations.Size = new System.Drawing.Size(66, 20);
            this.nmMaxIterations.TabIndex = 12;
            this.nmMaxIterations.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nmMaxIterations.ValueChanged += new System.EventHandler(this.nmMaxIterations_ValueChanged);
            // 
            // nmAccuracy
            // 
            this.nmAccuracy.Location = new System.Drawing.Point(105, 43);
            this.nmAccuracy.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmAccuracy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmAccuracy.Name = "nmAccuracy";
            this.nmAccuracy.Size = new System.Drawing.Size(66, 20);
            this.nmAccuracy.TabIndex = 14;
            this.nmAccuracy.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmAccuracy.ValueChanged += new System.EventHandler(this.nmAccuracy_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Accuracy";
            // 
            // nmZoom
            // 
            this.nmZoom.Location = new System.Drawing.Point(105, 90);
            this.nmZoom.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nmZoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmZoom.Name = "nmZoom";
            this.nmZoom.Size = new System.Drawing.Size(66, 20);
            this.nmZoom.TabIndex = 16;
            this.nmZoom.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Zoom level";
            // 
            // chkHighContrast
            // 
            this.chkHighContrast.AutoSize = true;
            this.chkHighContrast.Checked = true;
            this.chkHighContrast.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHighContrast.Location = new System.Drawing.Point(3, 166);
            this.chkHighContrast.Name = "chkHighContrast";
            this.chkHighContrast.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkHighContrast.Size = new System.Drawing.Size(131, 17);
            this.chkHighContrast.TabIndex = 17;
            this.chkHighContrast.Text = "Enable image contrast";
            this.chkHighContrast.UseVisualStyleBackColor = true;
            this.chkHighContrast.CheckedChanged += new System.EventHandler(this.chkHighContrast_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkStart);
            this.groupBox3.Controls.Add(this.label34);
            this.groupBox3.Controls.Add(this.nmInflate);
            this.groupBox3.Controls.Add(this.chkDrawRec);
            this.groupBox3.Controls.Add(this.chkCrossHair);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.nmThreshold);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.nmCrossHL);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.nmCircleDev);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.nmMaxIterations);
            this.groupBox3.Controls.Add(this.chkHighContrast);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.nmZoom);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.nmAccuracy);
            this.groupBox3.Location = new System.Drawing.Point(587, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 238);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configarations";
            // 
            // chkStart
            // 
            this.chkStart.AutoSize = true;
            this.chkStart.Location = new System.Drawing.Point(141, 166);
            this.chkStart.Name = "chkStart";
            this.chkStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkStart.Size = new System.Drawing.Size(79, 17);
            this.chkStart.TabIndex = 47;
            this.chkStart.Text = "Show St Pt";
            this.chkStart.UseVisualStyleBackColor = true;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(144, 213);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(36, 13);
            this.label34.TabIndex = 46;
            this.label34.Text = "Inflate";
            // 
            // nmInflate
            // 
            this.nmInflate.Enabled = false;
            this.nmInflate.Location = new System.Drawing.Point(189, 209);
            this.nmInflate.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmInflate.Name = "nmInflate";
            this.nmInflate.Size = new System.Drawing.Size(34, 20);
            this.nmInflate.TabIndex = 42;
            // 
            // chkDrawRec
            // 
            this.chkDrawRec.AutoSize = true;
            this.chkDrawRec.Location = new System.Drawing.Point(3, 210);
            this.chkDrawRec.Name = "chkDrawRec";
            this.chkDrawRec.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkDrawRec.Size = new System.Drawing.Size(131, 17);
            this.chkDrawRec.TabIndex = 41;
            this.chkDrawRec.Text = "Draw Bounding-Boxes";
            this.chkDrawRec.UseVisualStyleBackColor = true;
            this.chkDrawRec.CheckedChanged += new System.EventHandler(this.chkDrawRec_CheckedChanged);
            // 
            // chkCrossHair
            // 
            this.chkCrossHair.AutoSize = true;
            this.chkCrossHair.Checked = true;
            this.chkCrossHair.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCrossHair.Location = new System.Drawing.Point(32, 187);
            this.chkCrossHair.Name = "chkCrossHair";
            this.chkCrossHair.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCrossHair.Size = new System.Drawing.Size(102, 17);
            this.chkCrossHair.TabIndex = 40;
            this.chkCrossHair.Text = "Draw Cross-Hair";
            this.chkCrossHair.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(177, 140);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(43, 13);
            this.label32.TabIndex = 39;
            this.label32.Text = "(1 -254)";
            // 
            // nmThreshold
            // 
            this.nmThreshold.Location = new System.Drawing.Point(105, 138);
            this.nmThreshold.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.nmThreshold.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmThreshold.Name = "nmThreshold";
            this.nmThreshold.Size = new System.Drawing.Size(66, 20);
            this.nmThreshold.TabIndex = 38;
            this.nmThreshold.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(12, 140);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(90, 13);
            this.label33.TabIndex = 37;
            this.label33.Text = "Contrast Treshold";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(177, 116);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 13);
            this.label21.TabIndex = 36;
            this.label21.Text = "(1 - 20)";
            // 
            // nmCrossHL
            // 
            this.nmCrossHL.Location = new System.Drawing.Point(105, 114);
            this.nmCrossHL.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nmCrossHL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmCrossHL.Name = "nmCrossHL";
            this.nmCrossHL.Size = new System.Drawing.Size(66, 20);
            this.nmCrossHL.TabIndex = 35;
            this.nmCrossHL.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 116);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 13);
            this.label22.TabIndex = 34;
            this.label22.Text = "Cross-hair Len.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(177, 69);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 13);
            this.label19.TabIndex = 33;
            this.label19.Text = "(0 - 10)";
            // 
            // nmCircleDev
            // 
            this.nmCircleDev.Location = new System.Drawing.Point(105, 67);
            this.nmCircleDev.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmCircleDev.Name = "nmCircleDev";
            this.nmCircleDev.Size = new System.Drawing.Size(66, 20);
            this.nmCircleDev.TabIndex = 32;
            this.nmCircleDev.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 69);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(81, 13);
            this.label20.TabIndex = 31;
            this.label20.Text = "Circle Deviation";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(177, 92);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "(1 - 8)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(177, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "(1 - 1000)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(177, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "(1 - 5)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.processToolStripMenuItem,
            this.drillToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem,
            this.saveDrillPoinstToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem,
            this.loadDrillPointsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
            // 
            // saveDrillPoinstToolStripMenuItem
            // 
            this.saveDrillPoinstToolStripMenuItem.Name = "saveDrillPoinstToolStripMenuItem";
            this.saveDrillPoinstToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.saveDrillPoinstToolStripMenuItem.Text = "Save Drill poinst";
            this.saveDrillPoinstToolStripMenuItem.Click += new System.EventHandler(this.saveDrillPoinstToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // loadDrillPointsToolStripMenuItem
            // 
            this.loadDrillPointsToolStripMenuItem.Name = "loadDrillPointsToolStripMenuItem";
            this.loadDrillPointsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.loadDrillPointsToolStripMenuItem.Text = "Load Drill Points";
            this.loadDrillPointsToolStripMenuItem.Click += new System.EventHandler(this.loadDrillPointsToolStripMenuItem_Click);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selColorsToolStripMenuItem,
            this.analyseImageToolStripMenuItem,
            this.enhanceEditToolStripMenuItem});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.processToolStripMenuItem.Text = "Process";
            // 
            // selColorsToolStripMenuItem
            // 
            this.selColorsToolStripMenuItem.Name = "selColorsToolStripMenuItem";
            this.selColorsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.selColorsToolStripMenuItem.Text = "Set Colors...";
            this.selColorsToolStripMenuItem.Click += new System.EventHandler(this.selColorsToolStripMenuItem_Click);
            // 
            // analyseImageToolStripMenuItem
            // 
            this.analyseImageToolStripMenuItem.Name = "analyseImageToolStripMenuItem";
            this.analyseImageToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.analyseImageToolStripMenuItem.Text = "Analyse Image";
            this.analyseImageToolStripMenuItem.Click += new System.EventHandler(this.analyseImageToolStripMenuItem_Click);
            // 
            // enhanceEditToolStripMenuItem
            // 
            this.enhanceEditToolStripMenuItem.Name = "enhanceEditToolStripMenuItem";
            this.enhanceEditToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.enhanceEditToolStripMenuItem.Text = "Enhance/ Edit";
            this.enhanceEditToolStripMenuItem.Click += new System.EventHandler(this.enhanceEditToolStripMenuItem_Click);
            // 
            // drillToolStripMenuItem
            // 
            this.drillToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startDrillingToolStripMenuItem,
            this.pauseDrillingToolStripMenuItem,
            this.stopDrillingToolStripMenuItem});
            this.drillToolStripMenuItem.Name = "drillToolStripMenuItem";
            this.drillToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.drillToolStripMenuItem.Text = "Drill";
            // 
            // startDrillingToolStripMenuItem
            // 
            this.startDrillingToolStripMenuItem.Name = "startDrillingToolStripMenuItem";
            this.startDrillingToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.startDrillingToolStripMenuItem.Text = "Start Drilling...";
            this.startDrillingToolStripMenuItem.Click += new System.EventHandler(this.startDrillingToolStripMenuItem_Click);
            // 
            // pauseDrillingToolStripMenuItem
            // 
            this.pauseDrillingToolStripMenuItem.Name = "pauseDrillingToolStripMenuItem";
            this.pauseDrillingToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.pauseDrillingToolStripMenuItem.Text = "Pause Drilling...";
            this.pauseDrillingToolStripMenuItem.Click += new System.EventHandler(this.pauseDrillingToolStripMenuItem_Click);
            // 
            // stopDrillingToolStripMenuItem
            // 
            this.stopDrillingToolStripMenuItem.Name = "stopDrillingToolStripMenuItem";
            this.stopDrillingToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.stopDrillingToolStripMenuItem.Text = "Stop Drilling....";
            this.stopDrillingToolStripMenuItem.Click += new System.EventHandler(this.stopDrillingToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpOnPCBDrillerToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpOnPCBDrillerToolStripMenuItem
            // 
            this.helpOnPCBDrillerToolStripMenuItem.Name = "helpOnPCBDrillerToolStripMenuItem";
            this.helpOnPCBDrillerToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.helpOnPCBDrillerToolStripMenuItem.Text = "Help on PCB Driller";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "pcb";
            this.openFileDialog1.Filter = "JPG Files|*.jpg|PNG Files|*.png|BMP Files|*.bmp";
            this.openFileDialog1.Title = "Open PCB Image File";
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStStatus,
            this.pBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 625);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(892, 22);
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStStatus
            // 
            this.lblStStatus.Name = "lblStStatus";
            this.lblStStatus.Size = new System.Drawing.Size(775, 17);
            this.lblStStatus.Spring = true;
            this.lblStStatus.Text = "PCB Driller...";
            this.lblStStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pBar
            // 
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(100, 16);
            // 
            // btnEnhance
            // 
            this.btnEnhance.Location = new System.Drawing.Point(469, 288);
            this.btnEnhance.Name = "btnEnhance";
            this.btnEnhance.Size = new System.Drawing.Size(82, 23);
            this.btnEnhance.TabIndex = 21;
            this.btnEnhance.Text = "Edit";
            this.btnEnhance.UseVisualStyleBackColor = true;
            this.btnEnhance.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDrill
            // 
            this.btnDrill.BackColor = System.Drawing.Color.Tomato;
            this.btnDrill.Enabled = false;
            this.btnDrill.Location = new System.Drawing.Point(469, 355);
            this.btnDrill.Name = "btnDrill";
            this.btnDrill.Size = new System.Drawing.Size(82, 23);
            this.btnDrill.TabIndex = 22;
            this.btnDrill.Text = "Drill";
            this.btnDrill.UseVisualStyleBackColor = false;
            this.btnDrill.Click += new System.EventHandler(this.btnDrill_Click);
            // 
            // hHair
            // 
            this.hHair.BackColor = System.Drawing.Color.Red;
            this.hHair.Location = new System.Drawing.Point(464, 117);
            this.hHair.Name = "hHair";
            this.hHair.Size = new System.Drawing.Size(90, 1);
            this.hHair.TabIndex = 1;
            this.hHair.Visible = false;
            // 
            // vHair
            // 
            this.vHair.BackColor = System.Drawing.Color.Red;
            this.vHair.Location = new System.Drawing.Point(509, 72);
            this.vHair.Name = "vHair";
            this.vHair.Size = new System.Drawing.Size(1, 90);
            this.vHair.TabIndex = 23;
            this.vHair.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Location = new System.Drawing.Point(750, 598);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(555, 598);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Save Points";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(439, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(390, 1);
            this.label8.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(4, 594);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(845, 1);
            this.label9.TabIndex = 30;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.lbAllDrliiPoints);
            this.groupBox4.Location = new System.Drawing.Point(442, 417);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(148, 170);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Found Points.";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "0.7 mm",
            "0.9 mm",
            "1.0 mm",
            "1.1 mm",
            "1.5 mm",
            "2.1 mm",
            "3.0 mm"});
            this.comboBox1.Location = new System.Drawing.Point(6, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 46;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Total     :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "0.7 mm :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "1.0 mm :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "0.9 mm :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "1.5 mm :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "1.1 mm :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "2.1 mm :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 143);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "3.0 mm :";
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(469, 383);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(82, 23);
            this.btnPause.TabIndex = 37;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.grpEdit);
            this.groupBox5.Controls.Add(this.cb_30Path);
            this.groupBox5.Controls.Add(this.cb_30Pt);
            this.groupBox5.Controls.Add(this.cb_21Path);
            this.groupBox5.Controls.Add(this.cb_21Pt);
            this.groupBox5.Controls.Add(this.cb_15Path);
            this.groupBox5.Controls.Add(this.cb_15Pt);
            this.groupBox5.Controls.Add(this.cb_11Path);
            this.groupBox5.Controls.Add(this.cb_11Pt);
            this.groupBox5.Controls.Add(this.cb_10Path);
            this.groupBox5.Controls.Add(this.cb_10Pt);
            this.groupBox5.Controls.Add(this.cb_09Path);
            this.groupBox5.Controls.Add(this.cb_09Pt);
            this.groupBox5.Controls.Add(this.cb_07Path);
            this.groupBox5.Controls.Add(this.cb_07Pt);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.lblTot);
            this.groupBox5.Controls.Add(this.lbl0_7);
            this.groupBox5.Controls.Add(this.lbl3_0);
            this.groupBox5.Controls.Add(this.lbl0_9);
            this.groupBox5.Controls.Add(this.lbl2_1);
            this.groupBox5.Controls.Add(this.lbl1_0);
            this.groupBox5.Controls.Add(this.lbl1_5);
            this.groupBox5.Controls.Add(this.lbl1_1);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(602, 424);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(278, 163);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SUMMERY";
            // 
            // grpEdit
            // 
            this.grpEdit.Controls.Add(this.radioButton7);
            this.grpEdit.Controls.Add(this.radioButton6);
            this.grpEdit.Controls.Add(this.radioButton5);
            this.grpEdit.Controls.Add(this.radioButton4);
            this.grpEdit.Controls.Add(this.radioButton3);
            this.grpEdit.Controls.Add(this.radioButton2);
            this.grpEdit.Controls.Add(this.radioButton1);
            this.grpEdit.Enabled = false;
            this.grpEdit.Location = new System.Drawing.Point(221, 14);
            this.grpEdit.Name = "grpEdit";
            this.grpEdit.Size = new System.Drawing.Size(41, 149);
            this.grpEdit.TabIndex = 62;
            this.grpEdit.TabStop = false;
            this.grpEdit.Text = "Edit";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(14, 129);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(14, 13);
            this.radioButton7.TabIndex = 6;
            this.radioButton7.TabStop = true;
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.Click += new System.EventHandler(this.radioButton7_Click);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(14, 112);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(14, 13);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.Click += new System.EventHandler(this.radioButton6_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(14, 96);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(14, 13);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.Click += new System.EventHandler(this.radioButton5_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(14, 78);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(14, 13);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Click += new System.EventHandler(this.radioButton4_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(14, 62);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.radioButton3_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(14, 46);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(14, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // cb_30Path
            // 
            this.cb_30Path.AutoSize = true;
            this.cb_30Path.Location = new System.Drawing.Point(197, 143);
            this.cb_30Path.Name = "cb_30Path";
            this.cb_30Path.Size = new System.Drawing.Size(15, 14);
            this.cb_30Path.TabIndex = 61;
            this.cb_30Path.UseVisualStyleBackColor = true;
            // 
            // cb_30Pt
            // 
            this.cb_30Pt.AutoSize = true;
            this.cb_30Pt.Checked = true;
            this.cb_30Pt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_30Pt.Location = new System.Drawing.Point(168, 143);
            this.cb_30Pt.Name = "cb_30Pt";
            this.cb_30Pt.Size = new System.Drawing.Size(15, 14);
            this.cb_30Pt.TabIndex = 60;
            this.cb_30Pt.UseVisualStyleBackColor = true;
            // 
            // cb_21Path
            // 
            this.cb_21Path.AutoSize = true;
            this.cb_21Path.Location = new System.Drawing.Point(197, 126);
            this.cb_21Path.Name = "cb_21Path";
            this.cb_21Path.Size = new System.Drawing.Size(15, 14);
            this.cb_21Path.TabIndex = 59;
            this.cb_21Path.UseVisualStyleBackColor = true;
            // 
            // cb_21Pt
            // 
            this.cb_21Pt.AutoSize = true;
            this.cb_21Pt.Checked = true;
            this.cb_21Pt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_21Pt.Location = new System.Drawing.Point(168, 126);
            this.cb_21Pt.Name = "cb_21Pt";
            this.cb_21Pt.Size = new System.Drawing.Size(15, 14);
            this.cb_21Pt.TabIndex = 58;
            this.cb_21Pt.UseVisualStyleBackColor = true;
            // 
            // cb_15Path
            // 
            this.cb_15Path.AutoSize = true;
            this.cb_15Path.Location = new System.Drawing.Point(197, 110);
            this.cb_15Path.Name = "cb_15Path";
            this.cb_15Path.Size = new System.Drawing.Size(15, 14);
            this.cb_15Path.TabIndex = 57;
            this.cb_15Path.UseVisualStyleBackColor = true;
            // 
            // cb_15Pt
            // 
            this.cb_15Pt.AutoSize = true;
            this.cb_15Pt.Checked = true;
            this.cb_15Pt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_15Pt.Location = new System.Drawing.Point(168, 110);
            this.cb_15Pt.Name = "cb_15Pt";
            this.cb_15Pt.Size = new System.Drawing.Size(15, 14);
            this.cb_15Pt.TabIndex = 56;
            this.cb_15Pt.UseVisualStyleBackColor = true;
            // 
            // cb_11Path
            // 
            this.cb_11Path.AutoSize = true;
            this.cb_11Path.Location = new System.Drawing.Point(197, 93);
            this.cb_11Path.Name = "cb_11Path";
            this.cb_11Path.Size = new System.Drawing.Size(15, 14);
            this.cb_11Path.TabIndex = 55;
            this.cb_11Path.UseVisualStyleBackColor = true;
            // 
            // cb_11Pt
            // 
            this.cb_11Pt.AutoSize = true;
            this.cb_11Pt.Checked = true;
            this.cb_11Pt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_11Pt.Location = new System.Drawing.Point(168, 93);
            this.cb_11Pt.Name = "cb_11Pt";
            this.cb_11Pt.Size = new System.Drawing.Size(15, 14);
            this.cb_11Pt.TabIndex = 54;
            this.cb_11Pt.UseVisualStyleBackColor = true;
            // 
            // cb_10Path
            // 
            this.cb_10Path.AutoSize = true;
            this.cb_10Path.Location = new System.Drawing.Point(197, 76);
            this.cb_10Path.Name = "cb_10Path";
            this.cb_10Path.Size = new System.Drawing.Size(15, 14);
            this.cb_10Path.TabIndex = 53;
            this.cb_10Path.UseVisualStyleBackColor = true;
            // 
            // cb_10Pt
            // 
            this.cb_10Pt.AutoSize = true;
            this.cb_10Pt.Checked = true;
            this.cb_10Pt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_10Pt.Location = new System.Drawing.Point(168, 76);
            this.cb_10Pt.Name = "cb_10Pt";
            this.cb_10Pt.Size = new System.Drawing.Size(15, 14);
            this.cb_10Pt.TabIndex = 52;
            this.cb_10Pt.UseVisualStyleBackColor = true;
            // 
            // cb_09Path
            // 
            this.cb_09Path.AutoSize = true;
            this.cb_09Path.Location = new System.Drawing.Point(197, 59);
            this.cb_09Path.Name = "cb_09Path";
            this.cb_09Path.Size = new System.Drawing.Size(15, 14);
            this.cb_09Path.TabIndex = 51;
            this.cb_09Path.UseVisualStyleBackColor = true;
            // 
            // cb_09Pt
            // 
            this.cb_09Pt.AutoSize = true;
            this.cb_09Pt.Checked = true;
            this.cb_09Pt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_09Pt.Location = new System.Drawing.Point(168, 59);
            this.cb_09Pt.Name = "cb_09Pt";
            this.cb_09Pt.Size = new System.Drawing.Size(15, 14);
            this.cb_09Pt.TabIndex = 50;
            this.cb_09Pt.UseVisualStyleBackColor = true;
            // 
            // cb_07Path
            // 
            this.cb_07Path.AutoSize = true;
            this.cb_07Path.Location = new System.Drawing.Point(197, 42);
            this.cb_07Path.Name = "cb_07Path";
            this.cb_07Path.Size = new System.Drawing.Size(15, 14);
            this.cb_07Path.TabIndex = 49;
            this.cb_07Path.UseVisualStyleBackColor = true;
            // 
            // cb_07Pt
            // 
            this.cb_07Pt.AutoSize = true;
            this.cb_07Pt.Checked = true;
            this.cb_07Pt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_07Pt.Location = new System.Drawing.Point(168, 42);
            this.cb_07Pt.Name = "cb_07Pt";
            this.cb_07Pt.Size = new System.Drawing.Size(15, 14);
            this.cb_07Pt.TabIndex = 46;
            this.cb_07Pt.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(190, 17);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 13);
            this.label26.TabIndex = 48;
            this.label26.Text = "Path";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(166, 17);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(20, 13);
            this.label25.TabIndex = 47;
            this.label25.Text = "Pt.";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.Blue;
            this.label24.Location = new System.Drawing.Point(174, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(34, 13);
            this.label24.TabIndex = 46;
            this.label24.Text = "Show";
            // 
            // lblTot
            // 
            this.lblTot.BackColor = System.Drawing.Color.Silver;
            this.lblTot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTot.Location = new System.Drawing.Point(65, 19);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(94, 13);
            this.lblTot.TabIndex = 36;
            this.lblTot.Text = "---";
            // 
            // lbl0_7
            // 
            this.lbl0_7.BackColor = System.Drawing.Color.DarkGray;
            this.lbl0_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl0_7.ForeColor = System.Drawing.Color.Black;
            this.lbl0_7.Location = new System.Drawing.Point(65, 41);
            this.lbl0_7.Name = "lbl0_7";
            this.lbl0_7.Size = new System.Drawing.Size(94, 13);
            this.lbl0_7.TabIndex = 37;
            this.lbl0_7.Text = "---";
            // 
            // lbl3_0
            // 
            this.lbl3_0.BackColor = System.Drawing.Color.DarkGray;
            this.lbl3_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl3_0.ForeColor = System.Drawing.Color.Black;
            this.lbl3_0.Location = new System.Drawing.Point(65, 143);
            this.lbl3_0.Name = "lbl3_0";
            this.lbl3_0.Size = new System.Drawing.Size(94, 13);
            this.lbl3_0.TabIndex = 43;
            this.lbl3_0.Text = "---";
            // 
            // lbl0_9
            // 
            this.lbl0_9.BackColor = System.Drawing.Color.DarkGray;
            this.lbl0_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl0_9.ForeColor = System.Drawing.Color.Black;
            this.lbl0_9.Location = new System.Drawing.Point(65, 58);
            this.lbl0_9.Name = "lbl0_9";
            this.lbl0_9.Size = new System.Drawing.Size(94, 13);
            this.lbl0_9.TabIndex = 38;
            this.lbl0_9.Text = "---";
            // 
            // lbl2_1
            // 
            this.lbl2_1.BackColor = System.Drawing.Color.DarkGray;
            this.lbl2_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2_1.ForeColor = System.Drawing.Color.Black;
            this.lbl2_1.Location = new System.Drawing.Point(65, 126);
            this.lbl2_1.Name = "lbl2_1";
            this.lbl2_1.Size = new System.Drawing.Size(94, 13);
            this.lbl2_1.TabIndex = 42;
            this.lbl2_1.Text = "---";
            // 
            // lbl1_0
            // 
            this.lbl1_0.BackColor = System.Drawing.Color.DarkGray;
            this.lbl1_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1_0.ForeColor = System.Drawing.Color.Black;
            this.lbl1_0.Location = new System.Drawing.Point(65, 75);
            this.lbl1_0.Name = "lbl1_0";
            this.lbl1_0.Size = new System.Drawing.Size(94, 13);
            this.lbl1_0.TabIndex = 39;
            this.lbl1_0.Text = "---";
            // 
            // lbl1_5
            // 
            this.lbl1_5.BackColor = System.Drawing.Color.DarkGray;
            this.lbl1_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1_5.ForeColor = System.Drawing.Color.Black;
            this.lbl1_5.Location = new System.Drawing.Point(65, 109);
            this.lbl1_5.Name = "lbl1_5";
            this.lbl1_5.Size = new System.Drawing.Size(94, 13);
            this.lbl1_5.TabIndex = 41;
            this.lbl1_5.Text = "---";
            // 
            // lbl1_1
            // 
            this.lbl1_1.BackColor = System.Drawing.Color.DarkGray;
            this.lbl1_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1_1.ForeColor = System.Drawing.Color.Black;
            this.lbl1_1.Location = new System.Drawing.Point(65, 92);
            this.lbl1_1.Name = "lbl1_1";
            this.lbl1_1.Size = new System.Drawing.Size(94, 13);
            this.lbl1_1.TabIndex = 40;
            this.lbl1_1.Text = "---";
            // 
            // bw_highContrast
            // 
            this.bw_highContrast.WorkerReportsProgress = true;
            this.bw_highContrast.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_highContrast_DoWork);
            this.bw_highContrast.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_highContrast_RunWorkerCompleted);
            this.bw_highContrast.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw_highContrast_ProgressChanged);
            // 
            // lblCurLoc
            // 
            this.lblCurLoc.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCurLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurLoc.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurLoc.Location = new System.Drawing.Point(444, 175);
            this.lblCurLoc.Name = "lblCurLoc";
            this.lblCurLoc.Size = new System.Drawing.Size(133, 21);
            this.lblCurLoc.TabIndex = 38;
            this.lblCurLoc.Text = "--------";
            this.lblCurLoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(-3, 64);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(836, 1);
            this.label23.TabIndex = 40;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(469, 202);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(82, 23);
            this.btnLoadImage.TabIndex = 41;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // btnOptimize
            // 
            this.btnOptimize.Location = new System.Drawing.Point(469, 322);
            this.btnOptimize.Name = "btnOptimize";
            this.btnOptimize.Size = new System.Drawing.Size(82, 23);
            this.btnOptimize.TabIndex = 42;
            this.btnOptimize.Text = "Optimize";
            this.btnOptimize.UseVisualStyleBackColor = true;
            this.btnOptimize.Click += new System.EventHandler(this.btnOptimize_Click);
            // 
            // btnLoadPoints
            // 
            this.btnLoadPoints.Location = new System.Drawing.Point(448, 598);
            this.btnLoadPoints.Name = "btnLoadPoints";
            this.btnLoadPoints.Size = new System.Drawing.Size(75, 23);
            this.btnLoadPoints.TabIndex = 44;
            this.btnLoadPoints.Text = "Load Points";
            this.btnLoadPoints.UseVisualStyleBackColor = true;
            this.btnLoadPoints.Click += new System.EventHandler(this.btnLoadPoints_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(183, 598);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 45;
            this.button3.Text = "Re-Draw";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(892, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(464, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(892, 647);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnLoadPoints);
            this.Controls.Add(this.btnOptimize);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblCurLoc);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vHair);
            this.Controls.Add(this.hHair);
            this.Controls.Add(this.btnDrill);
            this.Controls.Add(this.btnEnhance);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSetColor);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnAnalyse);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PCB Driller - Beta Version";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMaxIterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAccuracy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmZoom)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmInflate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCrossHL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCircleDev)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.grpEdit.ResumeLayout(false);
            this.grpEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAnalyse;
        private System.Windows.Forms.ListBox lbAllDrliiPoints;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSetColor;
        private System.Windows.Forms.Label lblCurrentColor;
        private System.Windows.Forms.Label lblHoleColor;
        private System.Windows.Forms.Label lblLineColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRGB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmMaxIterations;
        private System.Windows.Forms.NumericUpDown nmAccuracy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmZoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkHighContrast;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDrillPoinstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpOnPCBDrillerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar pBar;
        private System.Windows.Forms.Button btnEnhance;
        private System.Windows.Forms.Button btnDrill;
        private System.Windows.Forms.Label hHair;
        private System.Windows.Forms.Label vHair;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.ComponentModel.BackgroundWorker bw_highContrast;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown nmCircleDev;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown nmCrossHL;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblCurLoc;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.Label lbl0_7;
        private System.Windows.Forms.Label lbl3_0;
        private System.Windows.Forms.Label lbl0_9;
        private System.Windows.Forms.Label lbl2_1;
        private System.Windows.Forms.Label lbl1_0;
        private System.Windows.Forms.Label lbl1_5;
        private System.Windows.Forms.Label lbl1_1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selColorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analyseImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enhanceEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startDrillingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseDrillingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopDrillingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDrillPointsToolStripMenuItem;
        private System.Windows.Forms.Button btnOptimize;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.NumericUpDown nmThreshold;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button btnLoadPoints;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox chkDrawRec;
        private System.Windows.Forms.CheckBox chkCrossHair;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.NumericUpDown nmInflate;
        private System.Windows.Forms.CheckBox chkStart;
        public System.Windows.Forms.ToolStripStatusLabel lblStStatus;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.CheckBox cb_07Pt;
        private System.Windows.Forms.CheckBox cb_30Path;
        private System.Windows.Forms.CheckBox cb_30Pt;
        private System.Windows.Forms.CheckBox cb_21Path;
        private System.Windows.Forms.CheckBox cb_21Pt;
        private System.Windows.Forms.CheckBox cb_15Path;
        private System.Windows.Forms.CheckBox cb_15Pt;
        private System.Windows.Forms.CheckBox cb_11Path;
        private System.Windows.Forms.CheckBox cb_11Pt;
        private System.Windows.Forms.CheckBox cb_10Path;
        private System.Windows.Forms.CheckBox cb_10Pt;
        private System.Windows.Forms.CheckBox cb_09Path;
        private System.Windows.Forms.CheckBox cb_09Pt;
        private System.Windows.Forms.CheckBox cb_07Path;
        private System.Windows.Forms.GroupBox grpEdit;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

