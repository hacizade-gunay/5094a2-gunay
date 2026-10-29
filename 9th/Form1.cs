using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Card_Information
{
    public partial class Form1 : Form
    {
        bool k = false;

        public Form1()
        {
            InitializeComponent();
        }

        // Soyad dəyişdikdə
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblSoyadValue.Text = txtSoyad.Text;
        }

        // Ad dəyişdikdə
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lblAdValue.Text = txtAd.Text;
        }

        // Ata adı dəyişdikdə
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            lblAtaAdiValue.Text = txtAtaAdi.Text;
        }

        // Şəkil yüklə
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();

            d.Filter = "Şəkil faylları|*.jpg;*.jpeg;*.png;*.bmp";

            if (d.ShowDialog() == DialogResult.OK)
            {
                using (Image img = Image.FromFile(d.FileName))
                {
                    pictureBox1.Image = new Bitmap(img);
                }
            }
        }

        // Məlumatları yoxla və yadda saxla
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSeriya.Text) ||
                string.IsNullOrEmpty(txtFIN.Text) ||
                string.IsNullOrEmpty(txtSoyad.Text) ||
                string.IsNullOrEmpty(txtAd.Text) ||
                string.IsNullOrEmpty(txtAtaAdi.Text) ||
                string.IsNullOrEmpty(txtCins.Text) ||
                string.IsNullOrEmpty(txtDogumTarixi.Text) ||
                string.IsNullOrEmpty(txtDogumYeri.Text) ||
                string.IsNullOrEmpty(txtAileVez.Text) ||
                string.IsNullOrEmpty(txtVerilmeTarixi.Text) ||
                string.IsNullOrEmpty(txtEtibarlidir.Text) ||
                string.IsNullOrEmpty(txtVerənOrqan.Text))
            {
                MessageBox.Show(
                    "Bütün xanaları doldurun!",
                    "Xəbərdarlıq",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult d = MessageBox.Show(
                    "Məlumatları yadda saxlamaq istəyirsiniz?",
                    "Sual",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (d == DialogResult.Yes)
                {
                    SaveFileDialog s = new SaveFileDialog();

                    s.Filter = "Mətn faylı|*.txt";
                    s.FileName = "CardInformation.txt";

                    if (s.ShowDialog() == DialogResult.OK)
                    {
                        StringBuilder melumat = new StringBuilder();

                        melumat.AppendLine("Şəxsi məlumatlar");
                        melumat.AppendLine("----------------------");
                        melumat.AppendLine("Seriya və nömrə: " + txtSeriya.Text);
                        melumat.AppendLine("FIN kod: " + txtFIN.Text);
                        melumat.AppendLine("Soyad: " + txtSoyad.Text);
                        melumat.AppendLine("Ad: " + txtAd.Text);
                        melumat.AppendLine("Ata adı: " + txtAtaAdi.Text);
                        melumat.AppendLine("Cins: " + txtCins.Text);
                        melumat.AppendLine("Doğum tarixi: " + txtDogumTarixi.Text);
                        melumat.AppendLine("Doğum yeri: " + txtDogumYeri.Text);
                        melumat.AppendLine("Ailə vəziyyəti: " + txtAileVez.Text);
                        melumat.AppendLine("Verilmə tarixi: " + txtVerilmeTarixi.Text);
                        melumat.AppendLine("Etibarlıdır: " + txtEtibarlidir.Text);
                        melumat.AppendLine("Verən orqan: " + txtVerənOrqan.Text);

                        File.WriteAllText(
                            s.FileName,
                            melumat.ToString(),
                            Encoding.UTF8);

                        MessageBox.Show(
                            "Məlumatlar yadda saxlanıldı!",
                            "Uğurlu əməliyyat",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
        }

        // Xanaları təmizlə
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show(
                "Bütün məlumatları təmizləmək istəyirsiniz?",
                "Sual",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (d == DialogResult.Yes)
            {
                txtSeriya.Clear();
                txtFIN.Clear();
                txtSoyad.Clear();
                txtAd.Clear();
                txtAtaAdi.Clear();
                txtCins.Clear();
                txtDogumTarixi.Clear();
                txtDogumYeri.Clear();
                txtAileVez.Clear();
                txtVerilmeTarixi.Clear();
                txtEtibarlidir.Clear();
                txtVerənOrqan.Clear();

                pictureBox1.Image = null;

                lblSoyadValue.Text = "";
                lblAdValue.Text = "";
                lblAtaAdiValue.Text = "";
            }
        }

        // Proqramı bağla
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show(
                "Proqramdan çıxmaq istəyirsiniz?",
                "Sual",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (d == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}