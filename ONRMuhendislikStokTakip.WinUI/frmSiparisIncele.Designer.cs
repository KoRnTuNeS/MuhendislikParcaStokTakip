namespace ONRMuhendislikStokTakip.WinUI
{
    partial class frmSiparisIncele
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
            this.lviSiparisUrunler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.linkAdres = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSiparisTarihi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKargoKodu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblToplamFiyat = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAktifMi = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lviSiparisUrunler
            // 
            this.lviSiparisUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lviSiparisUrunler.Location = new System.Drawing.Point(13, 154);
            this.lviSiparisUrunler.Name = "lviSiparisUrunler";
            this.lviSiparisUrunler.Size = new System.Drawing.Size(590, 290);
            this.lviSiparisUrunler.TabIndex = 0;
            this.lviSiparisUrunler.UseCompatibleStateImageBehavior = false;
            this.lviSiparisUrunler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kategori";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Alt Kategori";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyat";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adet";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Toplam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri:";
            // 
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Location = new System.Drawing.Point(74, 13);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(16, 13);
            this.lblMusteri.TabIndex = 1;
            this.lblMusteri.Text = "...";
            // 
            // linkAdres
            // 
            this.linkAdres.AutoSize = true;
            this.linkAdres.Location = new System.Drawing.Point(221, 73);
            this.linkAdres.Name = "linkAdres";
            this.linkAdres.Size = new System.Drawing.Size(34, 13);
            this.linkAdres.TabIndex = 2;
            this.linkAdres.TabStop = true;
            this.linkAdres.Text = "Adres";
            this.linkAdres.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAdres_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Durum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sipariş Tarihi:";
            // 
            // lblSiparisTarihi
            // 
            this.lblSiparisTarihi.AutoSize = true;
            this.lblSiparisTarihi.Location = new System.Drawing.Point(283, 13);
            this.lblSiparisTarihi.Name = "lblSiparisTarihi";
            this.lblSiparisTarihi.Size = new System.Drawing.Size(16, 13);
            this.lblSiparisTarihi.TabIndex = 1;
            this.lblSiparisTarihi.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Kargo Kodu:";
            // 
            // txtKargoKodu
            // 
            this.txtKargoKodu.Location = new System.Drawing.Point(81, 32);
            this.txtKargoKodu.Name = "txtKargoKodu";
            this.txtKargoKodu.Size = new System.Drawing.Size(128, 20);
            this.txtKargoKodu.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Toplam Fiyat:";
            // 
            // lblToplamFiyat
            // 
            this.lblToplamFiyat.AutoSize = true;
            this.lblToplamFiyat.Location = new System.Drawing.Point(490, 13);
            this.lblToplamFiyat.Name = "lblToplamFiyat";
            this.lblToplamFiyat.Size = new System.Drawing.Size(16, 13);
            this.lblToplamFiyat.TabIndex = 1;
            this.lblToplamFiyat.Text = "...";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(106, 69);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.txtKargoKodu);
            this.groupBox1.Location = new System.Drawing.Point(373, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 107);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kargo Kodu Düzenle";
            // 
            // chkAktifMi
            // 
            this.chkAktifMi.AutoSize = true;
            this.chkAktifMi.Location = new System.Drawing.Point(74, 72);
            this.chkAktifMi.Name = "chkAktifMi";
            this.chkAktifMi.Size = new System.Drawing.Size(47, 17);
            this.chkAktifMi.TabIndex = 7;
            this.chkAktifMi.Text = "Aktif";
            this.chkAktifMi.UseVisualStyleBackColor = true;
            // 
            // frmSiparisIncele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 456);
            this.Controls.Add(this.chkAktifMi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkAdres);
            this.Controls.Add(this.lblMusteri);
            this.Controls.Add(this.lblSiparisTarihi);
            this.Controls.Add(this.lblToplamFiyat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lviSiparisUrunler);
            this.Name = "frmSiparisIncele";
            this.Text = "frmSiparisIncele";
            this.Load += new System.EventHandler(this.frmSiparisIncele_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lviSiparisUrunler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.LinkLabel linkAdres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSiparisTarihi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKargoKodu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblToplamFiyat;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAktifMi;
    }
}