namespace PansiyonOtomasyonu
{
    partial class FrmMüşteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMüşteriler));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnVerileriGoster = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnAra = new System.Windows.Forms.Button();
            this.comboBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.labelCinsiyet = new System.Windows.Forms.Label();
            this.msdTxtTel = new System.Windows.Forms.MaskedTextBox();
            this.dtpÇıkış = new System.Windows.Forms.DateTimePicker();
            this.dtpGiriş = new System.Windows.Forms.DateTimePicker();
            this.TxtÜcret = new System.Windows.Forms.TextBox();
            this.TxtOdaNo = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtKimlikNO = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.labelÇıkış = new System.Windows.Forms.Label();
            this.labelGiriş = new System.Windows.Forms.Label();
            this.labelücret = new System.Windows.Forms.Label();
            this.labelOdaNumarası = new System.Windows.Forms.Label();
            this.labelKimlikNo = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelSoyad = new System.Windows.Forms.Label();
            this.labelAd = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-3, 319);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(930, 196);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İD";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı";
            this.columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyadı";
            this.columnHeader3.Width = 83;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cinsiyet";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telefon";
            this.columnHeader5.Width = 85;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mail";
            this.columnHeader6.Width = 94;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "TC";
            this.columnHeader7.Width = 74;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "OdaNo";
            this.columnHeader8.Width = 81;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ücret";
            this.columnHeader9.Width = 77;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "G.Tarih";
            this.columnHeader10.Width = 87;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Ç.Tarih";
            this.columnHeader11.Width = 94;
            // 
            // BtnVerileriGoster
            // 
            this.BtnVerileriGoster.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnVerileriGoster.Location = new System.Drawing.Point(755, 31);
            this.BtnVerileriGoster.Name = "BtnVerileriGoster";
            this.BtnVerileriGoster.Size = new System.Drawing.Size(138, 31);
            this.BtnVerileriGoster.TabIndex = 1;
            this.BtnVerileriGoster.Text = "Verileri Göster";
            this.BtnVerileriGoster.UseVisualStyleBackColor = true;
            this.BtnVerileriGoster.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Location = new System.Drawing.Point(755, 69);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(138, 31);
            this.BtnGuncelle.TabIndex = 2;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Location = new System.Drawing.Point(755, 151);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(138, 31);
            this.BtnSil.TabIndex = 3;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnAra
            // 
            this.BtnAra.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAra.Location = new System.Drawing.Point(755, 191);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(138, 31);
            this.BtnAra.TabIndex = 4;
            this.BtnAra.Text = "Ara";
            this.BtnAra.UseVisualStyleBackColor = true;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // comboBoxCinsiyet
            // 
            this.comboBoxCinsiyet.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxCinsiyet.FormattingEnabled = true;
            this.comboBoxCinsiyet.Items.AddRange(new object[] {
            "BAY",
            "BAYAN"});
            this.comboBoxCinsiyet.Location = new System.Drawing.Point(107, 105);
            this.comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            this.comboBoxCinsiyet.Size = new System.Drawing.Size(231, 24);
            this.comboBoxCinsiyet.TabIndex = 28;
            // 
            // labelCinsiyet
            // 
            this.labelCinsiyet.AutoSize = true;
            this.labelCinsiyet.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCinsiyet.Location = new System.Drawing.Point(39, 105);
            this.labelCinsiyet.Name = "labelCinsiyet";
            this.labelCinsiyet.Size = new System.Drawing.Size(66, 20);
            this.labelCinsiyet.TabIndex = 34;
            this.labelCinsiyet.Text = "Cinsiyet:";
            // 
            // msdTxtTel
            // 
            this.msdTxtTel.BackColor = System.Drawing.SystemColors.Info;
            this.msdTxtTel.Location = new System.Drawing.Point(111, 147);
            this.msdTxtTel.Mask = "(999) 000-0000";
            this.msdTxtTel.Name = "msdTxtTel";
            this.msdTxtTel.Size = new System.Drawing.Size(227, 22);
            this.msdTxtTel.TabIndex = 33;
            // 
            // dtpÇıkış
            // 
            this.dtpÇıkış.Location = new System.Drawing.Point(513, 169);
            this.dtpÇıkış.Name = "dtpÇıkış";
            this.dtpÇıkış.Size = new System.Drawing.Size(231, 22);
            this.dtpÇıkış.TabIndex = 32;
            // 
            // dtpGiriş
            // 
            this.dtpGiriş.Location = new System.Drawing.Point(508, 114);
            this.dtpGiriş.Name = "dtpGiriş";
            this.dtpGiriş.Size = new System.Drawing.Size(231, 22);
            this.dtpGiriş.TabIndex = 16;
            // 
            // TxtÜcret
            // 
            this.TxtÜcret.BackColor = System.Drawing.SystemColors.Info;
            this.TxtÜcret.Enabled = false;
            this.TxtÜcret.Location = new System.Drawing.Point(513, 67);
            this.TxtÜcret.Name = "TxtÜcret";
            this.TxtÜcret.Size = new System.Drawing.Size(226, 22);
            this.TxtÜcret.TabIndex = 30;
            // 
            // TxtOdaNo
            // 
            this.TxtOdaNo.BackColor = System.Drawing.SystemColors.Info;
            this.TxtOdaNo.Enabled = false;
            this.TxtOdaNo.Location = new System.Drawing.Point(513, 29);
            this.TxtOdaNo.Name = "TxtOdaNo";
            this.TxtOdaNo.Size = new System.Drawing.Size(227, 22);
            this.TxtOdaNo.TabIndex = 31;
            // 
            // TxtMail
            // 
            this.TxtMail.BackColor = System.Drawing.SystemColors.Info;
            this.TxtMail.Location = new System.Drawing.Point(112, 189);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(226, 22);
            this.TxtMail.TabIndex = 29;
            // 
            // TxtKimlikNO
            // 
            this.TxtKimlikNO.BackColor = System.Drawing.SystemColors.Info;
            this.TxtKimlikNO.Location = new System.Drawing.Point(107, 235);
            this.TxtKimlikNO.MaxLength = 11;
            this.TxtKimlikNO.Name = "TxtKimlikNO";
            this.TxtKimlikNO.Size = new System.Drawing.Size(231, 22);
            this.TxtKimlikNO.TabIndex = 27;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.BackColor = System.Drawing.SystemColors.Info;
            this.TxtSoyad.Location = new System.Drawing.Point(106, 69);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(232, 22);
            this.TxtSoyad.TabIndex = 26;
            // 
            // TxtAd
            // 
            this.TxtAd.BackColor = System.Drawing.SystemColors.Info;
            this.TxtAd.Location = new System.Drawing.Point(106, 31);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(232, 22);
            this.TxtAd.TabIndex = 19;
            // 
            // labelÇıkış
            // 
            this.labelÇıkış.AutoSize = true;
            this.labelÇıkış.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelÇıkış.Location = new System.Drawing.Point(412, 175);
            this.labelÇıkış.Name = "labelÇıkış";
            this.labelÇıkış.Size = new System.Drawing.Size(86, 20);
            this.labelÇıkış.TabIndex = 25;
            this.labelÇıkış.Text = "Çıkış Tarihi:";
            // 
            // labelGiriş
            // 
            this.labelGiriş.AutoSize = true;
            this.labelGiriş.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGiriş.Location = new System.Drawing.Point(413, 114);
            this.labelGiriş.Name = "labelGiriş";
            this.labelGiriş.Size = new System.Drawing.Size(85, 20);
            this.labelGiriş.TabIndex = 24;
            this.labelGiriş.Text = "Giriş Tarihi:";
            // 
            // labelücret
            // 
            this.labelücret.AutoSize = true;
            this.labelücret.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelücret.Location = new System.Drawing.Point(448, 69);
            this.labelücret.Name = "labelücret";
            this.labelücret.Size = new System.Drawing.Size(50, 20);
            this.labelücret.TabIndex = 17;
            this.labelücret.Text = "Ücret:";
            // 
            // labelOdaNumarası
            // 
            this.labelOdaNumarası.AutoSize = true;
            this.labelOdaNumarası.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOdaNumarası.Location = new System.Drawing.Point(396, 29);
            this.labelOdaNumarası.Name = "labelOdaNumarası";
            this.labelOdaNumarası.Size = new System.Drawing.Size(111, 20);
            this.labelOdaNumarası.TabIndex = 23;
            this.labelOdaNumarası.Text = "Oda Numarası:";
            // 
            // labelKimlikNo
            // 
            this.labelKimlikNo.AutoSize = true;
            this.labelKimlikNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKimlikNo.Location = new System.Drawing.Point(2, 237);
            this.labelKimlikNo.Name = "labelKimlikNo";
            this.labelKimlikNo.Size = new System.Drawing.Size(108, 20);
            this.labelKimlikNo.TabIndex = 22;
            this.labelKimlikNo.Text = "T.C. Kimlik No:";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMail.Location = new System.Drawing.Point(63, 191);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(43, 20);
            this.labelMail.TabIndex = 21;
            this.labelMail.Text = "Mail:";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTelefon.Location = new System.Drawing.Point(42, 147);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(63, 20);
            this.labelTelefon.TabIndex = 20;
            this.labelTelefon.Text = "Telefon:";
            // 
            // labelSoyad
            // 
            this.labelSoyad.AutoSize = true;
            this.labelSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSoyad.Location = new System.Drawing.Point(47, 69);
            this.labelSoyad.Name = "labelSoyad";
            this.labelSoyad.Size = new System.Drawing.Size(59, 20);
            this.labelSoyad.TabIndex = 18;
            this.labelSoyad.Text = "Soyadı:";
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAd.Location = new System.Drawing.Point(68, 31);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(32, 20);
            this.labelAd.TabIndex = 15;
            this.labelAd.Text = "Ad:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(669, 247);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 22);
            this.textBox1.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(623, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "İsim:";
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTemizle.Location = new System.Drawing.Point(755, 110);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(138, 31);
            this.BtnTemizle.TabIndex = 37;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // FrmMüşteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(921, 514);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCinsiyet);
            this.Controls.Add(this.labelCinsiyet);
            this.Controls.Add(this.msdTxtTel);
            this.Controls.Add(this.dtpÇıkış);
            this.Controls.Add(this.dtpGiriş);
            this.Controls.Add(this.TxtÜcret);
            this.Controls.Add(this.TxtOdaNo);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.TxtKimlikNO);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.labelÇıkış);
            this.Controls.Add(this.labelGiriş);
            this.Controls.Add(this.labelücret);
            this.Controls.Add(this.labelOdaNumarası);
            this.Controls.Add(this.labelKimlikNo);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelSoyad);
            this.Controls.Add(this.labelAd);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnVerileriGoster);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMüşteriler";
            this.Text = "Müşteri Bilgileri";
            this.Load += new System.EventHandler(this.FrmMüşteriler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button BtnVerileriGoster;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.ComboBox comboBoxCinsiyet;
        private System.Windows.Forms.Label labelCinsiyet;
        private System.Windows.Forms.MaskedTextBox msdTxtTel;
        private System.Windows.Forms.DateTimePicker dtpÇıkış;
        private System.Windows.Forms.DateTimePicker dtpGiriş;
        private System.Windows.Forms.TextBox TxtÜcret;
        private System.Windows.Forms.TextBox TxtOdaNo;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtKimlikNO;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label labelÇıkış;
        private System.Windows.Forms.Label labelGiriş;
        private System.Windows.Forms.Label labelücret;
        private System.Windows.Forms.Label labelOdaNumarası;
        private System.Windows.Forms.Label labelKimlikNo;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelSoyad;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnTemizle;
    }
}