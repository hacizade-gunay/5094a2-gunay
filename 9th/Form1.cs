
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Card_Information
{
    public partial class Form1 : Form
    {
        private string sekilYolu = "";

        public Form1()
        {
            InitializeComponent();
        }

        // Ad, soyad, ata adı və FIN kodunu kartda göstərir
        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            lblSoyadValue.Text = txtSoyad.Text;
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            lblAdValue.Text = txtAd.Text;
        }

        private void txtAtaAdi_TextChanged(object sender, EventArgs e)
        {
            lblAtaAdiValue.Text = txtAtaAdi.Text;
        }

        private void txtFIN_TextChanged(object sender, EventArgs e)
        {
            lblFINValue.Text = txtFIN.Text;
        }

        // Şəkil yüklə
        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Şəkil seç";
                openFileDialog.Filter =
                    "Şəkil faylları|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (Image sekil = Image.FromFile(openFileDialog.FileName))
                        {
                            pictureBox1.Image = new Bitmap(sekil);
                        }

                        sekilYolu = openFileDialog.FileName;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(
                            "Şəkli açmaq mümkün olmadı.",
                            "Xəta",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Məlumatları faylda saxla
        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] xanalar =
            {
                txtSeriya,
                txtFIN,
                txtSoyad,
                txtAd,
                txtAtaAdi,
                txtCins,
                txtDogumTarixi,
                txtDogumYeri,
                txtAileVez,
                txtVerilmeTarixi,
                txtEtibarlidir,
                txtVerenOrqan
            };

            foreach (TextBox xana in xanalar)
            {
                if (string.IsNullOrWhiteSpace(xana.Text))
                {
                    MessageBox.Show(
                        "Zəhmət olmasa, bütün məlumatları daxil edin.",
                        "Diqqət",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    xana.Focus();
                    return;
                }
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Məlumatları saxla";
                saveFileDialog.Filter = "Mətn faylı|*.txt";
                saveFileDialog.FileName = "CardInformation.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder melumat = new StringBuilder();

                        melumat.AppendLine("KART MƏLUMATLARI");
                        melumat.AppendLine("-------------------------");
                        melumat.AppendLine("Seriya: " + txtSeriya.Text);
                        melumat.AppendLine("FIN: " + txtFIN.Text);
                        melumat.AppendLine("Soyad: " + txtSoyad.Text);
                        melumat.AppendLine("Ad: " + txtAd.Text);
                        melumat.AppendLine("Ata adı: " + txtAtaAdi.Text);
                        melumat.AppendLine("Cins: " + txtCins.Text);
                        melumat.AppendLine("Doğum tarixi: " + txtDogumTarixi.Text);
                        melumat.AppendLine("Doğum yeri: " + txtDogumYeri.Text);
                        melumat.AppendLine("Ailə vəziyyəti: " + txtAileVez.Text);
                        melumat.AppendLine("Verilmə tarixi: " + txtVerilmeTarixi.Text);
                        melumat.AppendLine("Etibarlıdır: " + txtEtibarlidir.Text);
                        melumat.AppendLine("Verən orqan: " + txtVerenOrqan.Text);
                        melumat.AppendLine("Şəkil faylının yolu: " + sekilYolu);

                        File.WriteAllText(
                            saveFileDialog.FileName,
                            melumat.ToString(),
                            Encoding.UTF8);

                        MessageBox.Show(
                            "Məlumatlar uğurla saxlanıldı.",
                            "Məlumat",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(
                            "Faylı saxlamaq mümkün olmadı.",
                            "Xəta",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Xanaları təmizlə
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cavab = MessageBox.Show(
                "Bütün məlumatları təmizləmək istəyirsiniz?",
                "Təsdiq",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (cavab == DialogResult.Yes)
            {
                TextBox[] xanalar =
                {
                    txtSeriya,
                    txtFIN,
                    txtSoyad,
                    txtAd,
                    txtAtaAdi,
                    txtCins,
                    txtDogumTarixi,
                    txtDogumYeri,
                    txtAileVez,
                    txtVerilmeTarixi,
                    txtEtibarlidir,
                    txtVerenOrqan
                };

                foreach (TextBox xana in xanalar)
                {
                    xana.Clear();
                }

                pictureBox1.Image = null;
                sekilYolu = "";

                lblSoyadValue.Text = "";
                lblAdValue.Text = "";
                lblAtaAdiValue.Text = "";
                lblFINValue.Text = "";
            }
        }

        // Proqramdan çıx
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult cavab = MessageBox.Show(
                "Proqramdan çıxmaq istəyirsiniz?",
                "Çıxış",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (cavab == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}