namespace Card_Information
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
        private System.Windows.Forms.Label lblFINValue;
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
        private System.Windows.Forms.Label lblVerenOrqan;

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
        private System.Windows.Forms.TextBox txtVerenOrqan;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

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
            this.lblFINValue = new System.Windows.Forms.Label();
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
            this.lblVerenOrqan = new System.Windows.Forms.Label();

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
            this.txtVerenOrqan = new System.Windows.Forms.TextBox();

            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();

            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.Text = "Card Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.WhiteSmoke;

            // Məlumatların daxil edilməsi
            this.groupBox2.Location = new System.Drawing.Point(20, 20);
            this.groupBox2.Size = new System.Drawing.Size(490, 540);
            this.groupBox2.Text = "Şəxsi məlumatlar";
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F);

            AddField(this.lblSeriya, this.txtSeriya, "Seriya:", 20, 35);
            AddField(this.lblFIN, this.txtFIN, "FIN kod:", 20, 100);
            AddField(this.lblSoyad, this.txtSoyad, "Soyad:", 20, 165);
            AddField(this.lblAd, this.txtAd, "Ad:", 20, 230);
            AddField(this.lblAtaAdi, this.txtAtaAdi, "Ata adı:", 20, 295);
            AddField(this.lblCins, this.txtCins, "Cins:", 20, 360);

            AddField(this.lblDogumTarixi, this.txtDogumTarixi, "Doğum tarixi:", 250, 35);
            AddField(this.lblDogumYeri, this.txtDogumYeri, "Doğum yeri:", 250, 100);
            AddField(this.lblAileVez, this.txtAileVez, "Ailə vəziyyəti:", 250, 165);
            AddField(this.lblVerilmeTarixi, this.txtVerilmeTarixi, "Verilmə tarixi:", 250, 230);
            AddField(this.lblEtibarlidir, this.txtEtibarlidir, "Etibarlıdır:", 250, 295);
            AddField(this.lblVerenOrqan, this.txtVerenOrqan, "Verən orqan:", 250, 360);

            // Kart görünüşü
            this.panel1.Location = new System.Drawing.Point(535, 55);
            this.panel1.Size = new System.Drawing.Size(490, 300);
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblBasliq.Text = "AZƏRBAYCAN RESPUBLİKASI";
            this.lblBasliq.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblBasliq.Location = new System.Drawing.Point(15, 15);
            this.lblBasliq.Size = new System.Drawing.Size(460, 30);
            this.lblBasliq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblAltBasliq.Text = "ŞƏXSİYYƏT VƏSİQƏSİ";
            this.lblAltBasliq.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAltBasliq.Location = new System.Drawing.Point(15, 48);
            this.lblAltBasliq.Size = new System.Drawing.Size(460, 25);
            this.lblAltBasliq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.pictureBox1.Location = new System.Drawing.Point(20, 90);
            this.pictureBox1.Size = new System.Drawing.Size(130, 160);
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;

            this.lblSoyadCard.Text = "SOYAD:";
            this.lblSoyadCard.Location = new System.Drawing.Point(170, 95);
            this.lblSoyadCard.Size = new System.Drawing.Size(100, 22);

            this.lblSoyadValue.Location = new System.Drawing.Point(270, 95);
            this.lblSoyadValue.Size = new System.Drawing.Size(190, 22);
            this.lblSoyadValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            this.lblAdCard.Text = "AD:";
            this.lblAdCard.Location = new System.Drawing.Point(170, 130);
            this.lblAdCard.Size = new System.Drawing.Size(100, 22);

            this.lblAdValue.Location = new System.Drawing.Point(270, 130);
            this.lblAdValue.Size = new System.Drawing.Size(190, 22);
            this.lblAdValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            this.lblAtaAdiCard.Text = "ATA ADI:";
            this.lblAtaAdiCard.Location = new System.Drawing.Point(170, 165);
            this.lblAtaAdiCard.Size = new System.Drawing.Size(100, 22);

            this.lblAtaAdiValue.Location = new System.Drawing.Point(270, 165);
            this.lblAtaAdiValue.Size = new System.Drawing.Size(190, 22);
            this.lblAtaAdiValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            this.lblFINCard.Text = "FIN:";
            this.lblFINCard.Location = new System.Drawing.Point(170, 200);
            this.lblFINCard.Size = new System.Drawing.Size(100, 22);

            this.lblFINValue.Location = new System.Drawing.Point(270, 200);
            this.lblFINValue.Size = new System.Drawing.Size(190, 22);
            this.lblFINValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            this.lblNumune.Text = "NÜMUNƏ — RƏSMİ SƏNƏD DEYİL";
            this.lblNumune.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblNumune.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNumune.Location = new System.Drawing.Point(15, 265);
            this.lblNumune.Size = new System.Drawing.Size(460, 22);
            this.lblNumune.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

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
            this.panel1.Controls.Add(this.lblFINValue);
            this.panel1.Controls.Add(this.lblNumune);

            // Düymələr
            this.button1.Text = "Yadda saxla";
            this.button1.Location = new System.Drawing.Point(535, 400);
            this.button1.Size = new System.Drawing.Size(110, 40);
            this.button1.Click += new System.EventHandler(this.button1_Click);

            this.button2.Text = "Təmizlə";
            this.button2.Location = new System.Drawing.Point(660, 400);
            this.button2.Size = new System.Drawing.Size(110, 40);
            this.button2.Click += new System.EventHandler(this.button2_Click);

            this.button3.Text = "Şəkil yüklə";
            this.button3.Location = new System.Drawing.Point(785, 400);
            this.button3.Size = new System.Drawing.Size(110, 40);
            this.button3.Click += new System.EventHandler(this.button3_Click);

            this.button4.Text = "Çıxış";
            this.button4.Location = new System.Drawing.Point(910, 400);
            this.button4.Size = new System.Drawing.Size(110, 40);
            this.button4.Click += new System.EventHandler(this.button4_Click);

            // Hadisələr
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged);
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            this.txtAtaAdi.TextChanged += new System.EventHandler(this.txtAtaAdi_TextChanged);
            this.txtFIN.TextChanged += new System.EventHandler(this.txtFIN_TextChanged);

            // Elementləri formaya əlavə et
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);

            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private void AddField(
            System.Windows.Forms.Label label,
            System.Windows.Forms.TextBox textBox,
            string caption,
            int x,
            int y)
        {
            label.Text = caption;
            label.Location = new System.Drawing.Point(x, y);
            label.Size = new System.Drawing.Size(200, 22);
            label.Font = new System.Drawing.Font("Segoe UI", 9F);

            textBox.Location = new System.Drawing.Point(x, y + 25);
            textBox.Size = new System.Drawing.Size(205, 25);
            textBox.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.groupBox2.Controls.Add(label);
            this.groupBox2.Controls.Add(textBox);
        }
    }
}