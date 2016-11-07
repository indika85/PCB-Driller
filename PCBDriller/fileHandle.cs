using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace PCBDriller
{
    class fileHandle
    {
        public static void writeToFile(ArrayList list)
        {
            string path="";
            if (list.Count < 1)
            {
                MessageBox.Show("No Drill points to save!", "PCB Driller - Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            SaveFileDialog diag = new SaveFileDialog();
            diag.Filter = "PCB Driller file|*.pcbd";
            if (diag.ShowDialog() == DialogResult.Cancel)
                return;
            else 
                path=diag.FileName;
            //MessageBox.Show(path);
            //FileStream f = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            try
            {
                StreamWriter writer = File.CreateText(path);
                writer.Write("PCB Driller-V 1.0 Beta\n");
                writer.Write("File ID=19850602/19851124\n");
                writer.Write("Point data :");
                for (int i = 0; i < list.Count; i++)
                {
                    writer.Write(list[i].ToString());
                }
                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        public static ArrayList readFromFile()
        {
            string path = "";
            OpenFileDialog diag = new OpenFileDialog();
            ArrayList list = new ArrayList();
            diag.Filter = "PCB Driller files|*.pcbd";
            if (diag.ShowDialog() != DialogResult.Cancel)
            {
                try
                {
                    path = diag.FileName;
                    StreamReader reader = File.OpenText(path);
                    string info = reader.ReadToEnd();
                    reader.Close();
                    int current = info.IndexOf(":");
                    if (current < 1)
                    {
                        MessageBox.Show("Invalid file!", "PCB Driller - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return list;
                    }
                    while (current < info.Length - 1)
                    {
                        current = info.IndexOf("{", current);
                        if (current < 0)
                        {
                            break;
                        }
                        int x = Convert.ToInt32(info.Substring(current + 3, info.IndexOf(",", current + 3) - current - 3));
                        current = info.IndexOf(",", current);
                        int y = Convert.ToInt32(info.Substring(current + 3, info.IndexOf("}", current + 3) - current - 3));
                        list.Add(new Point(x, y));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            return list;
        }
    }
}
