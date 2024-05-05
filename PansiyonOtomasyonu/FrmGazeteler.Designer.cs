namespace PansiyonOtomasyonu
{
    partial class FrmGazeteler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGazeteler));
            this.btnHürriyet = new System.Windows.Forms.Button();
            this.btnMilliyet = new System.Windows.Forms.Button();
            this.btnSözcü = new System.Windows.Forms.Button();
            this.btnHbrTrk = new System.Windows.Forms.Button();
            this.btnFanatik = new System.Windows.Forms.Button();
            this.btnOnedio = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btnHürriyet
            // 
            this.btnHürriyet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnHürriyet.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHürriyet.Location = new System.Drawing.Point(12, 12);
            this.btnHürriyet.Name = "btnHürriyet";
            this.btnHürriyet.Size = new System.Drawing.Size(98, 32);
            this.btnHürriyet.TabIndex = 0;
            this.btnHürriyet.Text = "Hürriyet";
            this.btnHürriyet.UseVisualStyleBackColor = false;
            this.btnHürriyet.Click += new System.EventHandler(this.btnHürriyet_Click);
            // 
            // btnMilliyet
            // 
            this.btnMilliyet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMilliyet.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMilliyet.Location = new System.Drawing.Point(130, 12);
            this.btnMilliyet.Name = "btnMilliyet";
            this.btnMilliyet.Size = new System.Drawing.Size(96, 32);
            this.btnMilliyet.TabIndex = 1;
            this.btnMilliyet.Text = "Milliyet";
            this.btnMilliyet.UseVisualStyleBackColor = false;
            this.btnMilliyet.Click += new System.EventHandler(this.btnMilliyet_Click);
            // 
            // btnSözcü
            // 
            this.btnSözcü.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSözcü.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSözcü.Location = new System.Drawing.Point(243, 12);
            this.btnSözcü.Name = "btnSözcü";
            this.btnSözcü.Size = new System.Drawing.Size(98, 32);
            this.btnSözcü.TabIndex = 2;
            this.btnSözcü.Text = "Sözcü";
            this.btnSözcü.UseVisualStyleBackColor = false;
            this.btnSözcü.Click += new System.EventHandler(this.btnSözcü_Click);
            // 
            // btnHbrTrk
            // 
            this.btnHbrTrk.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnHbrTrk.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHbrTrk.Location = new System.Drawing.Point(359, 12);
            this.btnHbrTrk.Name = "btnHbrTrk";
            this.btnHbrTrk.Size = new System.Drawing.Size(111, 32);
            this.btnHbrTrk.TabIndex = 3;
            this.btnHbrTrk.Text = "HaberTürk";
            this.btnHbrTrk.UseVisualStyleBackColor = false;
            this.btnHbrTrk.Click += new System.EventHandler(this.btnHbrTrk_Click);
            // 
            // btnFanatik
            // 
            this.btnFanatik.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFanatik.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFanatik.Location = new System.Drawing.Point(518, 12);
            this.btnFanatik.Name = "btnFanatik";
            this.btnFanatik.Size = new System.Drawing.Size(95, 32);
            this.btnFanatik.TabIndex = 4;
            this.btnFanatik.Text = "Fanatik";
            this.btnFanatik.UseVisualStyleBackColor = false;
            this.btnFanatik.Click += new System.EventHandler(this.btnFanatik_Click);
            // 
            // btnOnedio
            // 
            this.btnOnedio.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOnedio.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnedio.Location = new System.Drawing.Point(670, 12);
            this.btnOnedio.Name = "btnOnedio";
            this.btnOnedio.Size = new System.Drawing.Size(95, 32);
            this.btnOnedio.TabIndex = 5;
            this.btnOnedio.Text = "Onedio";
            this.btnOnedio.UseVisualStyleBackColor = false;
            this.btnOnedio.Click += new System.EventHandler(this.btnOnedio_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 50);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(788, 400);
            this.webBrowser1.TabIndex = 6;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // FrmGazeteler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnOnedio);
            this.Controls.Add(this.btnFanatik);
            this.Controls.Add(this.btnHbrTrk);
            this.Controls.Add(this.btnSözcü);
            this.Controls.Add(this.btnMilliyet);
            this.Controls.Add(this.btnHürriyet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGazeteler";
            this.Text = "Gazeteler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHürriyet;
        private System.Windows.Forms.Button btnMilliyet;
        private System.Windows.Forms.Button btnSözcü;
        private System.Windows.Forms.Button btnHbrTrk;
        private System.Windows.Forms.Button btnFanatik;
        private System.Windows.Forms.Button btnOnedio;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}