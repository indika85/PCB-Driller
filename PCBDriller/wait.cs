using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PCBDriller
{
    public partial class wait : Form
    {
        public wait()
        {
            InitializeComponent();

        }

        private void wait_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                //MessageBox.Show("ssss");
                optimumPath.worker_point_analyzer.CancelAsync();
            }
        }

    }
}