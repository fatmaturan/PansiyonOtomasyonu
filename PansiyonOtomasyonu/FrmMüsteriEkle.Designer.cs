namespace PansiyonOtomasyonu
{
    partial class FrmMüsteriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMüsteriEkle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.labelCinsiyet = new System.Windows.Forms.Label();
            this.buttonKaydet = new System.Windows.Forms.Button();
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button109 = new System.Windows.Forms.Button();
            this.button108 = new System.Windows.Forms.Button();
            this.button107 = new System.Windows.Forms.Button();
            this.button106 = new System.Windows.Forms.Button();
            this.button105 = new System.Windows.Forms.Button();
            this.button104 = new System.Windows.Forms.Button();
            this.button103 = new System.Windows.Forms.Button();
            this.button102 = new System.Windows.Forms.Button();
            this.button101 = new System.Windows.Forms.Button();
            this.buttonDolu = new System.Windows.Forms.Button();
            this.buttonBoş = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxCinsiyet);
            this.groupBox1.Controls.Add(this.labelCinsiyet);
            this.groupBox1.Controls.Add(this.buttonKaydet);
            this.groupBox1.Controls.Add(this.msdTxtTel);
            this.groupBox1.Controls.Add(this.dtpÇıkış);
            this.groupBox1.Controls.Add(this.dtpGiriş);
            this.groupBox1.Controls.Add(this.TxtÜcret);
            this.groupBox1.Controls.Add(this.TxtOdaNo);
            this.groupBox1.Controls.Add(this.TxtMail);
            this.groupBox1.Controls.Add(this.TxtKimlikNO);
            this.groupBox1.Controls.Add(this.TxtSoyad);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.labelÇıkış);
            this.groupBox1.Controls.Add(this.labelGiriş);
            this.groupBox1.Controls.Add(this.labelücret);
            this.groupBox1.Controls.Add(this.labelOdaNumarası);
            this.groupBox1.Controls.Add(this.labelKimlikNo);
            this.groupBox1.Controls.Add(this.labelMail);
            this.groupBox1.Controls.Add(this.labelTelefon);
            this.groupBox1.Controls.Add(this.labelSoyad);
            this.groupBox1.Controls.Add(this.labelAd);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 548);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            this.label1.Visible = false;
            // 
            // comboBoxCinsiyet
            // 
            this.comboBoxCinsiyet.FormattingEnabled = true;
            this.comboBoxCinsiyet.Items.AddRange(new object[] {
            "BAY",
            "BAYAN"});
            this.comboBoxCinsiyet.Location = new System.Drawing.Point(116, 130);
            this.comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            this.comboBoxCinsiyet.Size = new System.Drawing.Size(231, 24);
            this.comboBoxCinsiyet.TabIndex = 9;
            // 
            // labelCinsiyet
            // 
            this.labelCinsiyet.AutoSize = true;
            this.labelCinsiyet.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCinsiyet.Location = new System.Drawing.Point(48, 130);
            this.labelCinsiyet.Name = "labelCinsiyet";
            this.labelCinsiyet.Size = new System.Drawing.Size(66, 20);
            this.labelCinsiyet.TabIndex = 14;
            this.labelCinsiyet.Text = "Cinsiyet:";
            this.labelCinsiyet.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKaydet.Location = new System.Drawing.Point(158, 478);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(111, 45);
            this.buttonKaydet.TabIndex = 1;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = false;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // msdTxtTel
            // 
            this.msdTxtTel.Location = new System.Drawing.Point(120, 172);
            this.msdTxtTel.Mask = "(999) 000-0000";
            this.msdTxtTel.Name = "msdTxtTel";
            this.msdTxtTel.Size = new System.Drawing.Size(227, 22);
            this.msdTxtTel.TabIndex = 13;
            // 
            // dtpÇıkış
            // 
            this.dtpÇıkış.Location = new System.Drawing.Point(116, 435);
            this.dtpÇıkış.Name = "dtpÇıkış";
            this.dtpÇıkış.Size = new System.Drawing.Size(231, 22);
            this.dtpÇıkış.TabIndex = 12;
            this.dtpÇıkış.ValueChanged += new System.EventHandler(this.dtpÇıkış_ValueChanged);
            // 
            // dtpGiriş
            // 
            this.dtpGiriş.Location = new System.Drawing.Point(116, 393);
            this.dtpGiriş.Name = "dtpGiriş";
            this.dtpGiriş.Size = new System.Drawing.Size(231, 22);
            this.dtpGiriş.TabIndex = 1;
            // 
            // TxtÜcret
            // 
            this.TxtÜcret.Enabled = false;
            this.TxtÜcret.Location = new System.Drawing.Point(121, 345);
            this.TxtÜcret.Name = "TxtÜcret";
            this.TxtÜcret.Size = new System.Drawing.Size(226, 22);
            this.TxtÜcret.TabIndex = 10;
            // 
            // TxtOdaNo
            // 
            this.TxtOdaNo.Enabled = false;
            this.TxtOdaNo.Location = new System.Drawing.Point(120, 299);
            this.TxtOdaNo.Name = "TxtOdaNo";
            this.TxtOdaNo.Size = new System.Drawing.Size(227, 22);
            this.TxtOdaNo.TabIndex = 11;
            this.TxtOdaNo.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(121, 214);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(226, 22);
            this.TxtMail.TabIndex = 10;
            this.TxtMail.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // TxtKimlikNO
            // 
            this.TxtKimlikNO.Location = new System.Drawing.Point(116, 249);
            this.TxtKimlikNO.MaxLength = 11;
            this.TxtKimlikNO.Name = "TxtKimlikNO";
            this.TxtKimlikNO.Size = new System.Drawing.Size(231, 22);
            this.TxtKimlikNO.TabIndex = 9;
            this.TxtKimlikNO.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(115, 94);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(232, 22);
            this.TxtSoyad.TabIndex = 8;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(115, 56);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(232, 22);
            this.TxtAd.TabIndex = 1;
            // 
            // labelÇıkış
            // 
            this.labelÇıkış.AutoSize = true;
            this.labelÇıkış.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelÇıkış.Location = new System.Drawing.Point(33, 437);
            this.labelÇıkış.Name = "labelÇıkış";
            this.labelÇıkış.Size = new System.Drawing.Size(86, 20);
            this.labelÇıkış.TabIndex = 7;
            this.labelÇıkış.Text = "Çıkış Tarihi:";
            // 
            // labelGiriş
            // 
            this.labelGiriş.AutoSize = true;
            this.labelGiriş.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGiriş.Location = new System.Drawing.Point(33, 393);
            this.labelGiriş.Name = "labelGiriş";
            this.labelGiriş.Size = new System.Drawing.Size(85, 20);
            this.labelGiriş.TabIndex = 6;
            this.labelGiriş.Text = "Giriş Tarihi:";
            this.labelGiriş.Click += new System.EventHandler(this.label8_Click);
            // 
            // labelücret
            // 
            this.labelücret.AutoSize = true;
            this.labelücret.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelücret.Location = new System.Drawing.Point(65, 345);
            this.labelücret.Name = "labelücret";
            this.labelücret.Size = new System.Drawing.Size(50, 20);
            this.labelücret.TabIndex = 1;
            this.labelücret.Text = "Ücret:";
            // 
            // labelOdaNumarası
            // 
            this.labelOdaNumarası.AutoSize = true;
            this.labelOdaNumarası.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOdaNumarası.Location = new System.Drawing.Point(11, 299);
            this.labelOdaNumarası.Name = "labelOdaNumarası";
            this.labelOdaNumarası.Size = new System.Drawing.Size(111, 20);
            this.labelOdaNumarası.TabIndex = 5;
            this.labelOdaNumarası.Text = "Oda Numarası:";
            // 
            // labelKimlikNo
            // 
            this.labelKimlikNo.AutoSize = true;
            this.labelKimlikNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKimlikNo.Location = new System.Drawing.Point(11, 251);
            this.labelKimlikNo.Name = "labelKimlikNo";
            this.labelKimlikNo.Size = new System.Drawing.Size(108, 20);
            this.labelKimlikNo.TabIndex = 4;
            this.labelKimlikNo.Text = "T.C. Kimlik No:";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMail.Location = new System.Drawing.Point(72, 216);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(43, 20);
            this.labelMail.TabIndex = 3;
            this.labelMail.Text = "Mail:";
            this.labelMail.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTelefon.Location = new System.Drawing.Point(51, 172);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(63, 20);
            this.labelTelefon.TabIndex = 2;
            this.labelTelefon.Text = "Telefon:";
            // 
            // labelSoyad
            // 
            this.labelSoyad.AutoSize = true;
            this.labelSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSoyad.Location = new System.Drawing.Point(56, 94);
            this.labelSoyad.Name = "labelSoyad";
            this.labelSoyad.Size = new System.Drawing.Size(59, 20);
            this.labelSoyad.TabIndex = 1;
            this.labelSoyad.Text = "Soyadı:";
            this.labelSoyad.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAd.Location = new System.Drawing.Point(77, 56);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(32, 20);
            this.labelAd.TabIndex = 0;
            this.labelAd.Text = "Ad:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button109);
            this.groupBox2.Controls.Add(this.button108);
            this.groupBox2.Controls.Add(this.button107);
            this.groupBox2.Controls.Add(this.button106);
            this.groupBox2.Controls.Add(this.button105);
            this.groupBox2.Controls.Add(this.button104);
            this.groupBox2.Controls.Add(this.button103);
            this.groupBox2.Controls.Add(this.button102);
            this.groupBox2.Controls.Add(this.button101);
            this.groupBox2.Location = new System.Drawing.Point(410, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 422);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odalar";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button109
            // 
            this.button109.BackColor = System.Drawing.Color.Aquamarine;
            this.button109.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button109.Location = new System.Drawing.Point(289, 275);
            this.button109.Name = "button109";
            this.button109.Size = new System.Drawing.Size(90, 90);
            this.button109.TabIndex = 8;
            this.button109.Text = "109";
            this.button109.UseVisualStyleBackColor = false;
            this.button109.Click += new System.EventHandler(this.button109_Click);
            // 
            // button108
            // 
            this.button108.BackColor = System.Drawing.Color.Aquamarine;
            this.button108.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button108.Location = new System.Drawing.Point(176, 275);
            this.button108.Name = "button108";
            this.button108.Size = new System.Drawing.Size(90, 90);
            this.button108.TabIndex = 7;
            this.button108.Text = "108";
            this.button108.UseVisualStyleBackColor = false;
            this.button108.Click += new System.EventHandler(this.button108_Click);
            // 
            // button107
            // 
            this.button107.BackColor = System.Drawing.Color.Aquamarine;
            this.button107.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button107.Location = new System.Drawing.Point(63, 277);
            this.button107.Name = "button107";
            this.button107.Size = new System.Drawing.Size(90, 90);
            this.button107.TabIndex = 6;
            this.button107.Text = "107";
            this.button107.UseVisualStyleBackColor = false;
            this.button107.Click += new System.EventHandler(this.button107_Click);
            // 
            // button106
            // 
            this.button106.BackColor = System.Drawing.Color.Aquamarine;
            this.button106.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button106.Location = new System.Drawing.Point(290, 172);
            this.button106.Name = "button106";
            this.button106.Size = new System.Drawing.Size(90, 90);
            this.button106.TabIndex = 5;
            this.button106.Text = "106";
            this.button106.UseVisualStyleBackColor = false;
            this.button106.Click += new System.EventHandler(this.button106_Click);
            // 
            // button105
            // 
            this.button105.BackColor = System.Drawing.Color.Aquamarine;
            this.button105.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button105.Location = new System.Drawing.Point(176, 172);
            this.button105.Name = "button105";
            this.button105.Size = new System.Drawing.Size(90, 90);
            this.button105.TabIndex = 4;
            this.button105.Text = "105";
            this.button105.UseVisualStyleBackColor = false;
            this.button105.Click += new System.EventHandler(this.button105_Click);
            // 
            // button104
            // 
            this.button104.BackColor = System.Drawing.Color.Aquamarine;
            this.button104.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button104.Location = new System.Drawing.Point(63, 172);
            this.button104.Name = "button104";
            this.button104.Size = new System.Drawing.Size(90, 90);
            this.button104.TabIndex = 3;
            this.button104.Text = "104";
            this.button104.UseVisualStyleBackColor = false;
            this.button104.Click += new System.EventHandler(this.button104_Click);
            // 
            // button103
            // 
            this.button103.BackColor = System.Drawing.Color.Aquamarine;
            this.button103.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button103.Location = new System.Drawing.Point(289, 64);
            this.button103.Name = "button103";
            this.button103.Size = new System.Drawing.Size(90, 90);
            this.button103.TabIndex = 2;
            this.button103.Text = "103";
            this.button103.UseVisualStyleBackColor = false;
            this.button103.Click += new System.EventHandler(this.button103_Click);
            // 
            // button102
            // 
            this.button102.BackColor = System.Drawing.Color.Aquamarine;
            this.button102.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button102.Location = new System.Drawing.Point(176, 64);
            this.button102.Name = "button102";
            this.button102.Size = new System.Drawing.Size(90, 90);
            this.button102.TabIndex = 1;
            this.button102.Text = "102";
            this.button102.UseVisualStyleBackColor = false;
            this.button102.Click += new System.EventHandler(this.button3_Click);
            // 
            // button101
            // 
            this.button101.BackColor = System.Drawing.Color.Aquamarine;
            this.button101.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button101.Location = new System.Drawing.Point(63, 64);
            this.button101.Name = "button101";
            this.button101.Size = new System.Drawing.Size(90, 90);
            this.button101.TabIndex = 0;
            this.button101.Text = "101";
            this.button101.UseVisualStyleBackColor = false;
            this.button101.Click += new System.EventHandler(this.button101_Click);
            // 
            // buttonDolu
            // 
            this.buttonDolu.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonDolu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDolu.Location = new System.Drawing.Point(635, 490);
            this.buttonDolu.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDolu.Name = "buttonDolu";
            this.buttonDolu.Size = new System.Drawing.Size(70, 70);
            this.buttonDolu.TabIndex = 2;
            this.buttonDolu.Text = "Dolu";
            this.buttonDolu.UseVisualStyleBackColor = false;
            this.buttonDolu.Click += new System.EventHandler(this.buttonDolu_Click);
            // 
            // buttonBoş
            // 
            this.buttonBoş.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonBoş.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBoş.Location = new System.Drawing.Point(724, 490);
            this.buttonBoş.Name = "buttonBoş";
            this.buttonBoş.Size = new System.Drawing.Size(70, 70);
            this.buttonBoş.TabIndex = 3;
            this.buttonBoş.Text = "Boş";
            this.buttonBoş.UseVisualStyleBackColor = false;
            this.buttonBoş.Click += new System.EventHandler(this.buttonBoş_Click);
            // 
            // FrmMüsteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(844, 586);
            this.Controls.Add(this.buttonBoş);
            this.Controls.Add(this.buttonDolu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMüsteriEkle";
            this.Text = "Müşteri Ekle";
            this.Load += new System.EventHandler(this.FrmMüsteriEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelOdaNumarası;
        private System.Windows.Forms.Label labelKimlikNo;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelSoyad;
        private System.Windows.Forms.Label labelAd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelÇıkış;
        private System.Windows.Forms.Label labelGiriş;
        private System.Windows.Forms.Label labelücret;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtKimlikNO;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.MaskedTextBox msdTxtTel;
        private System.Windows.Forms.DateTimePicker dtpÇıkış;
        private System.Windows.Forms.DateTimePicker dtpGiriş;
        private System.Windows.Forms.TextBox TxtÜcret;
        private System.Windows.Forms.TextBox TxtOdaNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button109;
        private System.Windows.Forms.Button button108;
        private System.Windows.Forms.Button button107;
        private System.Windows.Forms.Button button106;
        private System.Windows.Forms.Button button105;
        private System.Windows.Forms.Button button104;
        private System.Windows.Forms.Button button103;
        private System.Windows.Forms.Button button102;
        private System.Windows.Forms.Button button101;
        private System.Windows.Forms.Button buttonDolu;
        private System.Windows.Forms.Button buttonBoş;
        private System.Windows.Forms.Label labelCinsiyet;
        private System.Windows.Forms.ComboBox comboBoxCinsiyet;
        private System.Windows.Forms.Label label1;
    }
}