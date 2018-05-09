namespace ONRMuhendislikStokTakip.WinUI
{
    partial class frmSiparisler
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
            this.lviSiparisler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnIncele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSiparisID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lviSiparisler
            // 
            this.lviSiparisler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lviSiparisler.Location = new System.Drawing.Point(13, 108);
            this.lviSiparisler.Name = "lviSiparisler";
            this.lviSiparisler.Size = new System.Drawing.Size(674, 328);
            this.lviSiparisler.TabIndex = 0;
            this.lviSiparisler.UseCompatibleStateImageBehavior = false;
            this.lviSiparisler.View = System.Windows.Forms.View.Details;
            this.lviSiparisler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lviSiparisler_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Müşteri";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adres Adı";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Durum";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sipariş Tarihi";
            this.columnHeader5.Width = 85;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Kargo Kodu";
            this.columnHeader6.Width = 97;
            // 
            // btnIncele
            // 
            this.btnIncele.Location = new System.Drawing.Point(108, 39);
            this.btnIncele.Name = "btnIncele";
            this.btnIncele.Size = new System.Drawing.Size(75, 23);
            this.btnIncele.TabIndex = 1;
            this.btnIncele.Text = "İncele";
            this.btnIncele.UseVisualStyleBackColor = true;
            this.btnIncele.Click += new System.EventHandler(this.btnIncele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(562, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sipariş ID:";
            // 
            // lblSiparisID
            // 
            this.lblSiparisID.AutoSize = true;
            this.lblSiparisID.Location = new System.Drawing.Point(623, 44);
            this.lblSiparisID.Name = "lblSiparisID";
            this.lblSiparisID.Size = new System.Drawing.Size(16, 13);
            this.lblSiparisID.TabIndex = 2;
            this.lblSiparisID.Text = "...";
            // 
            // frmSiparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 448);
            this.Controls.Add(this.lblSiparisID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIncele);
            this.Controls.Add(this.lviSiparisler);
            this.Name = "frmSiparisler";
            this.Text = "frmSiparisler";
            this.Load += new System.EventHandler(this.frmSiparisler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lviSiparisler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnIncele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSiparisID;
    }
}