namespace PansiyonOtomasyonu
{
    partial class FrmStoklar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStoklar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGıda = new System.Windows.Forms.TextBox();
            this.textBoxİcecek = new System.Windows.Forms.TextBox();
            this.textBoxAtistirmalik = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxİnternet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxelektrik = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gıda Tutarı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "İçecek Tutarı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Atıştırmalıklar:";
            // 
            // textBoxGıda
            // 
            this.textBoxGıda.Location = new System.Drawing.Point(165, 88);
            this.textBoxGıda.Name = "textBoxGıda";
            this.textBoxGıda.Size = new System.Drawing.Size(216, 22);
            this.textBoxGıda.TabIndex = 3;
            // 
            // textBoxİcecek
            // 
            this.textBoxİcecek.Location = new System.Drawing.Point(165, 135);
            this.textBoxİcecek.Name = "textBoxİcecek";
            this.textBoxİcecek.Size = new System.Drawing.Size(216, 22);
            this.textBoxİcecek.TabIndex = 4;
            // 
            // textBoxAtistirmalik
            // 
            this.textBoxAtistirmalik.Location = new System.Drawing.Point(165, 180);
            this.textBoxAtistirmalik.Name = "textBoxAtistirmalik";
            this.textBoxAtistirmalik.Size = new System.Drawing.Size(216, 22);
            this.textBoxAtistirmalik.TabIndex = 5;
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button.Location = new System.Drawing.Point(165, 259);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(124, 29);
            this.button.TabIndex = 6;
            this.button.Text = "Kaydet";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 346);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(458, 171);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Gıdalar";
            this.columnHeader1.Width = 169;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İçecekler";
            this.columnHeader2.Width = 155;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Atıştmalıklar";
            this.columnHeader3.Width = 465;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.button);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxAtistirmalik);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxİcecek);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxGıda);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 507);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mutfak";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.listView2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxİnternet);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxSu);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxelektrik);
            this.groupBox2.Location = new System.Drawing.Point(476, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 507);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Faturalar";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(6, 346);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(458, 180);
            this.listView2.TabIndex = 7;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Elektrik";
            this.columnHeader4.Width = 179;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Su";
            this.columnHeader5.Width = 155;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "İnternet";
            this.columnHeader6.Width = 465;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(165, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Elektrik:";
            // 
            // textBoxİnternet
            // 
            this.textBoxİnternet.Location = new System.Drawing.Point(165, 174);
            this.textBoxİnternet.Name = "textBoxİnternet";
            this.textBoxİnternet.Size = new System.Drawing.Size(216, 22);
            this.textBoxİnternet.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Su:";
            // 
            // textBoxSu
            // 
            this.textBoxSu.Location = new System.Drawing.Point(165, 129);
            this.textBoxSu.Name = "textBoxSu";
            this.textBoxSu.Size = new System.Drawing.Size(216, 22);
            this.textBoxSu.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "İnternet:";
            // 
            // textBoxelektrik
            // 
            this.textBoxelektrik.Location = new System.Drawing.Point(165, 75);
            this.textBoxelektrik.Name = "textBoxelektrik";
            this.textBoxelektrik.Size = new System.Drawing.Size(216, 22);
            this.textBoxelektrik.TabIndex = 3;
            // 
            // FrmStoklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(938, 550);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmStoklar";
            this.Text = "Giderler & Faturalar";
            this.Load += new System.EventHandler(this.FrmStoklar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxGıda;
        private System.Windows.Forms.TextBox textBoxİcecek;
        private System.Windows.Forms.TextBox textBoxAtistirmalik;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxİnternet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxelektrik;
    }
}