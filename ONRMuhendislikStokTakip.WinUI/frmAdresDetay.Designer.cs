namespace ONRMuhendislikStokTakip.WinUI
{
    partial class frmAdresDetay
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblil = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPostaKodu = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblilce = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alıcı Adı:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(83, 12);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(16, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "...";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(269, 12);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(16, 13);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Alıcı Soyadı:";
            // 
            // lblil
            // 
            this.lblil.AutoSize = true;
            this.lblil.Location = new System.Drawing.Point(83, 58);
            this.lblil.Name = "lblil";
            this.lblil.Size = new System.Drawing.Size(16, 13);
            this.lblil.TabIndex = 3;
            this.lblil.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "İl:";
            // 
            // lblPostaKodu
            // 
            this.lblPostaKodu.AutoSize = true;
            this.lblPostaKodu.Location = new System.Drawing.Point(83, 99);
            this.lblPostaKodu.Name = "lblPostaKodu";
            this.lblPostaKodu.Size = new System.Drawing.Size(16, 13);
            this.lblPostaKodu.TabIndex = 5;
            this.lblPostaKodu.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Posta Kodu:";
            // 
            // lblilce
            // 
            this.lblilce.AutoSize = true;
            this.lblilce.Location = new System.Drawing.Point(269, 58);
            this.lblilce.Name = "lblilce";
            this.lblilce.Size = new System.Drawing.Size(16, 13);
            this.lblilce.TabIndex = 7;
            this.lblilce.Text = "...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(236, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "İlçe:";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(269, 99);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(16, 13);
            this.lblAdres.TabIndex = 9;
            this.lblAdres.Text = "...";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(202, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Açık Adres:";
            // 
            // frmAdresDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 161);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblilce);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblPostaKodu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.label1);
            this.Name = "frmAdresDetay";
            this.Text = "frmAdresDetay";
            this.Load += new System.EventHandler(this.frmAdresDetay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPostaKodu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblilce;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label label12;
    }
}