namespace Card_Information
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Label lblBasliq;
        private System.Windows.Forms.Label lblAltBasliq;
        private System.Windows.Forms.Label lblSoyadCard;
        private System.Windows.Forms.Label lblAdCard;
        private System.Windows.Forms.Label lblAtaAdiCard;
        private System.Windows.Forms.Label lblSoyadValue;
        private System.Windows.Forms.Label lblAdValue;
        private System.Windows.Forms.Label lblAtaAdiValue;
        private System.Windows.Forms.Label lblFINCard;
        private System.Windows.Forms.Label lblNumune;

        private System.Windows.Forms.Label lblSeriya;
        private System.Windows.Forms.Label lblFIN;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblAtaAdi;
        private System.Windows.Forms.Label lblCins;
        private System.Windows.Forms.Label lblDogumTarixi;
        private System.Windows.Forms.Label lblDogumYeri;
        private System.Windows.Forms.Label lblAileVez;
        private System.Windows.Forms.Label lblVerilmeTarixi;
        private System.Windows.Forms.Label lblEtibarlidir;
        private System.Windows.Forms.Label lblVerənOrqan;

        private System.Windows.Forms.TextBox txtSeriya;
        private System.Windows.Forms.TextBox txtFIN;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtAtaAdi;
        private System.Windows.Forms.TextBox txtCins;
        private System.Windows.Forms.TextBox txtDogumTarixi;
        private System.Windows.Forms.TextBox txtDogumYeri;
        private System.Windows.Forms.TextBox txtAileVez;
        private System.Windows.Forms.TextBox txtVerilmeTarixi;
        private System.Windows.Forms.TextBox txtEtibarlidir;
        private System.Windows.Forms.TextBox txtVerənOrqan;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components =
                new System.ComponentModel.Container();

            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();

            this.lblBasliq = new System.Windows.Forms.Label();
            this.lblAltBasliq = new System.Windows.Forms.Label();
            this.lblSoyadCard = new System.Windows.Forms.Label();
            this.lblAdCard = new System.Windows.Forms.Label();
            this.lblAtaAdiCard = new System.Windows.Forms.Label();
            this.lblSoyadValue = new System.Windows.Forms.Label();
            this.lblAdValue = new System.Windows.Forms.Label();
            this.lblAtaAdiValue = new System.Windows.Forms.Label();
            this.lblFINCard = new System.Windows.Forms.Label();
            this.lblNumune = new System.Windows.Forms.Label();

            this.lblSeriya = new System.Windows.Forms.Label();
            this.lblFIN = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblAtaAdi = new System.Windows.Forms.Label();
            this.lblCins = new System.Windows.Forms.Label();
            this.lblDogumTarixi = new System.Windows.Forms.Label();
            this.lblDogumYeri = new System.Windows.Forms.Label();
            this.lblAileVez = new System.Windows.Forms.Label();
            this.lblVerilmeTarixi = new System.Windows.Forms.Label();
            this.lblEtibarlidir = new System.Windows.Forms.Label();
            this.lblVerənOrqan = new System.Windows.Forms.Label();

            this.txtSeriya = new System.Windows.Forms.TextBox();
            this.txtFIN = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtAtaAdi = new System.Windows.Forms.TextBox();
            this.txtCins = new System.Windows.Forms.TextBox();
            this.txtDogumTarixi = new System.Windows.Forms.TextBox();
            this.txtDogumYeri = new System.Windows.Forms.TextBox();
            this.txtAileVez = new System.Windows.Forms.TextBox();
            this.txtVerilmeTarixi = new System.Windows.Forms.TextBox();
            this.txtEtibarlidir = new System.Windows.Forms.TextBox();
            this.txtVerənOrqan = new System.Windows.Forms.TextBox();

            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Form
            this.Text = "Şəxsi Məlumatlar";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(1200, 760);
            this.MinimumSize = new System.Drawing.Size(1050, 700);

            // Sol tərəf
            this.groupBox1.Text = "Şəxsi məlumat kartı";
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Size = new System.Drawing.Size(550, 590);
            this.groupBox1.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left;

            // Kart
            this.panel1.Location = new System.Drawing.Point(20, 35);
            this.panel1.Size = new System.Drawing.Size(510, 460);
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblBasliq.Text = "AZƏRBAYCAN RESPUBLİKASI";
            this.lblBasliq.Location = new System.Drawing.Point(15, 15);
            this.lblBasliq.AutoSize = true;
            this.lblBasliq.Font = new System.Drawing.Font(
                "Arial", 13, System.Drawing.FontStyle.Bold);

            this.lblAltBasliq.Text = "Şəxsi məlumat kartı - NÜMUNƏ";
            this.lblAltBasliq.Location = new System.Drawing.Point(17, 43);
            this.lblAltBasliq.AutoSize = true;

            // Foto
            this.pictureBox1.Location = new System.Drawing.Point(15, 90);
            this.pictureBox1.Size = new System.Drawing.Size(125, 155);
            this.pictureBox1.SizeMode =
                System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.BackColor = System.Drawing.Color.White;

            // Kartdakı yazılar
            this.lblSoyadCard.Text = "Soyad:";
            this.lblSoyadCard.Location = new System.Drawing.Point(165, 95);
            this.lblSoyadCard.AutoSize = true;

            this.lblSoyadValue.Location = new System.Drawing.Point(245, 95);
            this.lblSoyadValue.Size = new System.Drawing.Size(220, 22);

            this.lblAdCard.Text = "Ad:";
            this.lblAdCard.Location = new System.Drawing.Point(165, 135);
            this.lblAdCard.AutoSize = true;

            this.lblAdValue.Location = new System.Drawing.Point(245, 135);
            this.lblAdValue.Size = new System.Drawing.Size(220, 22);

            this.lblAtaAdiCard.Text = "Ata adı:";
            this.lblAtaAdiCard.Location = new System.Drawing.Point(165, 175);
            this.lblAtaAdiCard.AutoSize = true;

            this.lblAtaAdiValue.Location = new System.Drawing.Point(245, 175);
            this.lblAtaAdiValue.Size = new System.Drawing.Size(220, 22);

            this.lblFINCard.Text = "FIN:";
            this.lblFINCard.Location = new System.Drawing.Point(165, 215);
            this.lblFINCard.AutoSize = true;

            this.lblNumune.Text = "TƏDRİS MƏQSƏDLİ NÜMUNƏ";
            this.lblNumune.Location = new System.Drawing.Point(100, 390);
            this.lblNumune.AutoSize = true;
            this.lblNumune.Font = new System.Drawing.Font(
                "Arial", 12, System.Drawing.FontStyle.Bold);
            this.lblNumune.ForeColor = System.Drawing.Color.SteelBlue;

            this.panel1.Controls.Add(this.lblBasliq);
            this.panel1.Controls.Add(this.lblAltBasliq);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblSoyadCard);
            this.panel1.Controls.Add(this.lblSoyadValue);
            this.panel1.Controls.Add(this.lblAdCard);
            this.panel1.Controls.Add(this.lblAdValue);
            this.panel1.Controls.Add(this.lblAtaAdiCard);
            this.panel1.Controls.Add(this.lblAtaAdiValue);
            this.panel1.Controls.Add(this.lblFINCard);
            this.panel1.Controls.Add(this.lblNumune);

            // Şəkil yüklə
            this.button3.Text = "Şəkil yüklə...";
            this.button3.Location = new System.Drawing.Point(20, 510);
            this.button3.Size = new System.Drawing.Size(510, 45);
            this.button3.Click += new System.EventHandler(
                this.button3_Click);

            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.button3);

            // Sağ tərəf
            this.groupBox2.Text = "Vəsiqə məlumatları";
            this.groupBox2.Location = new System.Drawing.Point(590, 20);
            this.groupBox2.Size = new System.Drawing.Size(590, 590);
            this.groupBox2.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            // Məlumat xanaları
            AddField("Seriya və nömrə:", 40,
                out lblSeriya, out txtSeriya);

            AddField("FIN kod:", 85,
                out lblFIN, out txtFIN);

            AddField("Soyad:", 130,
                out lblSoyad, out txtSoyad);

            AddField("Ad:", 175,
                out lblAd, out txtAd);

            AddField("Ata adı:", 220,
                out lblAtaAdi, out txtAtaAdi);

            AddField("Cins:", 265,
                out lblCins, out txtCins);

            AddField("Doğum tarixi:", 310,
                out lblDogumTarixi, out txtDogumTarixi);

            AddField("Doğum yeri:", 355,
                out lblDogumYeri, out txtDogumYeri);

            AddField("Ailə vəziyyəti:", 400,
                out lblAileVez, out txtAileVez);

            AddField("Verilmə tarixi:", 445,
                out lblVerilmeTarixi, out txtVerilmeTarixi);

            AddField("Etibarlıdır:", 490,
                out lblEtibarlidir, out txtEtibarlidir);

            AddField("Verən orqan:", 535,
                out lblVerənOrqan, out txtVerənOrqan);

            // TextChanged hadisələri
            this.txtSoyad.TextChanged +=
                new System.EventHandler(this.textBox1_TextChanged);

            this.txtAd.TextChanged +=
                new System.EventHandler(this.textBox2_TextChanged);

            this.txtAtaAdi.TextChanged +=
                new System.EventHandler(this.textBox3_TextChanged);

            // Düymələr
            this.button1.Text = "Yadda saxla";
            this.button1.Location = new System.Drawing.Point(780, 635);
            this.button1.Size = new System.Drawing.Size(150, 45);
            this.button1.Click += new System.EventHandler(
                this.button1_Click);

            this.button2.Text = "Təmizlə";
            this.button2.Location = new System.Drawing.Point(600, 635);
            this.button2.Size = new System.Drawing.Size(150, 45);
            this.button2.Click += new System.EventHandler(
                this.button2_Click);

            this.button4.Text = "Çıxış";
            this.button4.Location = new System.Drawing.Point(960, 635);
            this.button4.Size = new System.Drawing.Size(150, 45);
            this.button4.Click += new System.EventHandler(
                this.button4_Click);

            // Form üzərində yerləşdirmə
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);

            this.ResumeLayout(false);
        }

        // Xanaları yaratmaq üçün metod
        private void AddField(
            string title,
            int y,
            out System.Windows.Forms.Label label,
            out System.Windows.Forms.TextBox textBox)
        {
            label = new System.Windows.Forms.Label();
            label.Text = title;
            label.Location = new System.Drawing.Point(20, y + 5);
            label.Size = new System.Drawing.Size(190, 25);
            label.Font = new System.Drawing.Font("Arial", 10);

            textBox = new System.Windows.Forms.TextBox();
            textBox.Location = new System.Drawing.Point(210, y);
            textBox.Size = new System.Drawing.Size(345, 30);
            textBox.Font = new System.Drawing.Font("Arial", 10);

            this.groupBox2.Controls.Add(label);
            this.groupBox2.Controls.Add(textBox);
        }
    }
}