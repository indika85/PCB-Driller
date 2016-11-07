namespace PCBDriller
{
    partial class options
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
            this.rb_NN = new System.Windows.Forms.RadioButton();
            this.rb_NI = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rb_NN
            // 
            this.rb_NN.AutoSize = true;
            this.rb_NN.Checked = true;
            this.rb_NN.Location = new System.Drawing.Point(23, 69);
            this.rb_NN.Name = "rb_NN";
            this.rb_NN.Size = new System.Drawing.Size(210, 17);
            this.rb_NN.TabIndex = 0;
            this.rb_NN.TabStop = true;
            this.rb_NN.Text = "Nearest Neighbour Heuristic Algorithem";
            this.rb_NN.UseVisualStyleBackColor = true;
            // 
            // rb_NI
            // 
            this.rb_NI.AutoSize = true;
            this.rb_NI.Location = new System.Drawing.Point(23, 124);
            this.rb_NI.Name = "rb_NI";
            this.rb_NI.Size = new System.Drawing.Size(201, 17);
            this.rb_NI.TabIndex = 1;
            this.rb_NI.Text = "Nearest Insertion Heuristic Algorithem";
            this.rb_NI.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please select an algorithem you want use when searching for an \r\noptimal path.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "(Slow to calculate but the \r\nresult will be More Optimized)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "(Fat to calculate but the \r\nresult will be Less Optimized)";
            // 
            // options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 205);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rb_NI);
            this.Controls.Add(this.rb_NN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "options";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Algorithem Options.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_NN;
        private System.Windows.Forms.RadioButton rb_NI;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}