namespace Files
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox richTextBox1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();

            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 800);
            this.Text = "Files";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(0, 65, 62);
            this.MinimumSize = new System.Drawing.Size(900, 600);

            // Top orange panel
            this.panel1.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Height = 255;

            // PAPERMAN title
            this.label1.Text = "PAPERMAN";
            this.label1.Font = new System.Drawing.Font(
                "Segoe UI",
                28F,
                System.Drawing.FontStyle.Bold);

            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.AutoSize = false;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;

            this.panel1.Controls.Add(this.label1);

            // Main panel
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(0, 65, 62);
            this.panel2.Padding = new System.Windows.Forms.Padding(20);

            // Save file button
            this.button1.Text = "Save file";
            this.button1.Font = new System.Drawing.Font(
                "Segoe UI",
                19F,
                System.Drawing.FontStyle.Bold);

            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(20, 40);
            this.button1.Size = new System.Drawing.Size(575, 170);
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // Write file button
            this.button2.Text = "Write file";
            this.button2.Font = new System.Drawing.Font(
                "Segoe UI",
                19F,
                System.Drawing.FontStyle.Bold);

            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(20, 235);
            this.button2.Size = new System.Drawing.Size(575, 170);
            this.button2.Click += new System.EventHandler(this.button2_Click);

            // Delete file button
            this.button3.Text = "Delete file";
            this.button3.Font = new System.Drawing.Font(
                "Segoe UI",
                19F,
                System.Drawing.FontStyle.Bold);

            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(20, 430);
            this.button3.Size = new System.Drawing.Size(575, 170);
            this.button3.Click += new System.EventHandler(this.button3_Click);

            // Read file button
            this.button4.Text = "Read file";
            this.button4.Font = new System.Drawing.Font(
                "Segoe UI",
                19F,
                System.Drawing.FontStyle.Bold);

            this.button4.BackColor = System.Drawing.Color.Gainsboro;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(20, 625);
            this.button4.Size = new System.Drawing.Size(575, 130);
            this.button4.Click += new System.EventHandler(this.button4_Click);

            // Text area
            this.richTextBox1.Font = new System.Drawing.Font(
                "Segoe UI",
                12F);

            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(625, 40);
            this.richTextBox1.Size = new System.Drawing.Size(650, 715);
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Add controls
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.richTextBox1);

            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);

            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}