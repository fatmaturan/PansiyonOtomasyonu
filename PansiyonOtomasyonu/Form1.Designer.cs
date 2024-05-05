namespace PansiyonOtomasyonu
{
    partial class FrmAdminGiriş
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminGiriş));
            this.labelKullanıcıAdı = new System.Windows.Forms.Label();
            this.labelŞifre = new System.Windows.Forms.Label();
            this.txtKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.txtŞifre = new System.Windows.Forms.TextBox();
            this.buttonGirişYap = new System.Windows.Forms.Button();
            this.AdminGirislabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelKullanıcıAdı
            // 
            this.labelKullanıcıAdı.AutoSize = true;
            this.labelKullanıcıAdı.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKullanıcıAdı.Location = new System.Drawing.Point(68, 230);
            this.labelKullanıcıAdı.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKullanıcıAdı.Name = "labelKullanıcıAdı";
            this.labelKullanıcıAdı.Size = new System.Drawing.Size(179, 30);
            this.labelKullanıcıAdı.TabIndex = 0;
            this.labelKullanıcıAdı.Text = "Kullanıcı Adı:";
            // 
            // labelŞifre
            // 
            this.labelŞifre.AutoSize = true;
            this.labelŞifre.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelŞifre.Location = new System.Drawing.Point(146, 308);
            this.labelŞifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelŞifre.Name = "labelŞifre";
            this.labelŞifre.Size = new System.Drawing.Size(76, 30);
            this.labelŞifre.TabIndex = 1;
            this.labelŞifre.Text = "Şifre:";
            // 
            // txtKullanıcıAdı
            // 
            this.txtKullanıcıAdı.BackColor = System.Drawing.SystemColors.Info;
            this.txtKullanıcıAdı.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKullanıcıAdı.Location = new System.Drawing.Point(271, 232);
            this.txtKullanıcıAdı.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            this.txtKullanıcıAdı.Size = new System.Drawing.Size(263, 29);
            this.txtKullanıcıAdı.TabIndex = 2;
            // 
            // txtŞifre
            // 
            this.txtŞifre.BackColor = System.Drawing.SystemColors.Info;
            this.txtŞifre.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtŞifre.Location = new System.Drawing.Point(271, 305);
            this.txtŞifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtŞifre.Name = "txtŞifre";
            this.txtŞifre.Size = new System.Drawing.Size(263, 29);
            this.txtŞifre.TabIndex = 3;
            this.txtŞifre.UseSystemPasswordChar = true;
            // 
            // buttonGirişYap
            // 
            this.buttonGirişYap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGirişYap.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.buttonGirişYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGirişYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGirişYap.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGirişYap.Location = new System.Drawing.Point(290, 383);
            this.buttonGirişYap.Name = "buttonGirişYap";
            this.buttonGirişYap.Size = new System.Drawing.Size(136, 41);
            this.buttonGirişYap.TabIndex = 4;
            this.buttonGirişYap.Text = "Giriş Yap";
            this.buttonGirişYap.UseVisualStyleBackColor = false;
            this.buttonGirişYap.Click += new System.EventHandler(this.buttonGirişYap_Click_1);
            // 
            // AdminGirislabel
            // 
            this.AdminGirislabel.AutoSize = true;
            this.AdminGirislabel.Font = new System.Drawing.Font("Jokerman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminGirislabel.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.AdminGirislabel.Location = new System.Drawing.Point(145, 86);
            this.AdminGirislabel.Name = "AdminGirislabel";
            this.AdminGirislabel.Size = new System.Drawing.Size(0, 29);
            this.AdminGirislabel.TabIndex = 6;
            // 
            // FrmAdminGiriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(679, 574);
            this.Controls.Add(this.AdminGirislabel);
            this.Controls.Add(this.buttonGirişYap);
            this.Controls.Add(this.txtŞifre);
            this.Controls.Add(this.txtKullanıcıAdı);
            this.Controls.Add(this.labelŞifre);
            this.Controls.Add(this.labelKullanıcıAdı);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdminGiriş";
            this.Text = "Admin Giriş";
            this.Load += new System.EventHandler(this.FrmAdminGiriş_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKullanıcıAdı;
        private System.Windows.Forms.Label labelŞifre;
        private System.Windows.Forms.TextBox txtKullanıcıAdı;
        private System.Windows.Forms.TextBox txtŞifre;
        private System.Windows.Forms.Button buttonGirişYap;
        private System.Windows.Forms.Label AdminGirislabel;
    }
}

