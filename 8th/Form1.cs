using System;
using System.IO;
using System.Windows.Forms;

namespace Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Save file
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();

            sv.Filter = "Text files (*.txt)|*.txt";
            sv.FileName = "Document.txt";

            if (sv.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.Create(sv.FileName).Close();

                    MessageBox.Show(
                        "File created successfully!",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("File could not be created!");
                }
            }
        }

        // Write file
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            op.Filter = "Text files (*.txt)|*.txt";

            if (op.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.AppendAllText(op.FileName, richTextBox1.Text);

                    MessageBox.Show(
                        "Text written successfully!",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Text could not be written!");
                }
            }
        }

        // Delete file
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            op.Filter = "Text files (*.txt)|*.txt";

            if (op.ShowDialog() == DialogResult.OK)
            {
                DialogResult d = MessageBox.Show(
                    "Are you sure you want to delete this file?",
                    "Question",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (d == DialogResult.Yes)
                {
                    try
                    {
                        File.Delete(op.FileName);
                        richTextBox1.Text = "File deleted";

                        MessageBox.Show(
                            "File deleted successfully!",
                            "Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("File could not be deleted!");
                    }
                }
            }
        }

        // Read file
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            op.Filter = "Text files (*.txt)|*.txt";

            if (op.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    richTextBox1.Text = File.ReadAllText(op.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("File could not be read!");
                }
            }
        }
    }
}