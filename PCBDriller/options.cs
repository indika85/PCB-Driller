using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PCBDriller
{
    public partial class options : Form
    {
        public options()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rb_NN.Checked)
            {
                Form1.mainForm.useNearestNeighbour = true;
            }
            else if (rb_NI.Checked)
            {
                Form1.mainForm.useNearestNeighbour = false;
            }
            this.Close();
        }
    }
}