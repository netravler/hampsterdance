namespace hampsterdance
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.excersizeTheHampsterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getOnTheWheelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyOutTheResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadURLsToTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excersizeTheHampsterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1107, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // excersizeTheHampsterToolStripMenuItem
            // 
            this.excersizeTheHampsterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getOnTheWheelToolStripMenuItem,
            this.copyOutTheResultsToolStripMenuItem,
            this.loadURLsToTestToolStripMenuItem});
            this.excersizeTheHampsterToolStripMenuItem.Name = "excersizeTheHampsterToolStripMenuItem";
            this.excersizeTheHampsterToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.excersizeTheHampsterToolStripMenuItem.Text = "Excercise the Hamster";
            // 
            // getOnTheWheelToolStripMenuItem
            // 
            this.getOnTheWheelToolStripMenuItem.Name = "getOnTheWheelToolStripMenuItem";
            this.getOnTheWheelToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.getOnTheWheelToolStripMenuItem.Text = "Get on the Wheel";
            this.getOnTheWheelToolStripMenuItem.Click += new System.EventHandler(this.getOnTheWheelToolStripMenuItem_Click);
            // 
            // copyOutTheResultsToolStripMenuItem
            // 
            this.copyOutTheResultsToolStripMenuItem.Name = "copyOutTheResultsToolStripMenuItem";
            this.copyOutTheResultsToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.copyOutTheResultsToolStripMenuItem.Text = "Copy out the results";
            this.copyOutTheResultsToolStripMenuItem.Click += new System.EventHandler(this.copyOutTheResultsToolStripMenuItem_Click);
            // 
            // loadURLsToTestToolStripMenuItem
            // 
            this.loadURLsToTestToolStripMenuItem.Name = "loadURLsToTestToolStripMenuItem";
            this.loadURLsToTestToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.loadURLsToTestToolStripMenuItem.Text = "Load URL\'s to test";
            this.loadURLsToTestToolStripMenuItem.Click += new System.EventHandler(this.loadURLsToTestToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(557, 54);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(538, 284);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 54);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(538, 284);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(808, 0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 22);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(808, 31);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(148, 22);
            this.textBox4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(751, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Time In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(740, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Time Out";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 358);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Hamster Dance";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem excersizeTheHampsterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getOnTheWheelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyOutTheResultsToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem loadURLsToTestToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

