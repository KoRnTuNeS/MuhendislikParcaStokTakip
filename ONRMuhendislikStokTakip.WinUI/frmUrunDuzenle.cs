using ONRMuhendislikStokTakip.BLL;
using ONRMuhendislikStokTakip.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ONRMuhendislikStokTakip.WinUI
{
    public partial class frmUrunDuzenle : Form
    {
        public frmUrunDuzenle()
        {
            InitializeComponent();
        }

        private void btnGozat_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult cevap = ofd.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName; //filename dosyanın adresini bize teslim eder.
                btnGozat.Visible = false;
            }
        }

        private void resmiDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnGozat.Visible = true;
            btnGozat.PerformClick(); //otomatik tıklatma
            btnGozat.Visible = false;
        }
        EUrun u;
        private void frmUrunDuzenle_Load(object sender, EventArgs e)
        {
            u = BLLUrun.UrunBul(frmUrunler.urunID);

            cmbKategori.DataSource = BLLKategori.Listele();
            cmbKategori.DisplayMember = "CategoryName";
            cmbKategori.ValueMember = "ID";
            cmbKategori.SelectedValue = BLLKategori.UrunKategoriBul(u.SubCategoryID).ID;


            cmbMarka.DataSource = BLLMarka.Listele();
            cmbMarka.DisplayMember = "BrandName";
            cmbMarka.ValueMember = "ID";
            cmbMarka.SelectedValue = BLLMarka.MarkaBul(u.BrandID).ID;


            int id = BLLKategori.UrunKategoriBul(u.SubCategoryID).ID;

            cmbAltKategori.DataSource = BLLAltKategori.AltKategoriListele(id);
            cmbAltKategori.DisplayMember = "SubCategoryName";
            cmbAltKategori.ValueMember = "ID";
            cmbAltKategori.SelectedValue = BLLAltKategori.AltKategoriBul(u.SubCategoryID).ID;


            txtUrunAdi.Text = u.ProductName;
            numFiyat.Value = u.Price;
            numStok.Value = u.Stock;
            txtAciklama.Text = u.Description;
            pictureBox1.ImageLocation = u.MasterPhotoPath;
            btnGozat.Visible = false;
        }

        private void cmbKategori_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbKategori.SelectedValue);
            
            cmbAltKategori.DataSource = BLLAltKategori.AltKategoriListele(id);
            cmbAltKategori.DisplayMember = "SubCategoryName";
            cmbAltKategori.ValueMember = "ID";            
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            string eskiFoto = u.MasterPhotoPath;
            u.SubCategoryID = Convert.ToInt32(cmbAltKategori.SelectedValue);
            u.BrandID = Convert.ToInt32(cmbMarka.SelectedValue);
            u.ProductName = txtUrunAdi.Text;
            u.Price = Convert.ToDecimal(numFiyat.Value);
            u.Stock = Convert.ToInt32(numStok.Value);
            u.Description = txtAciklama.Text;
            Guid resimAdi = Guid.NewGuid();
            if (BLLUrun.ResimKontrol(pictureBox1.ImageLocation) == "Hata")
            {
                MessageBox.Show("Resim seçiniz...");
                return;
            }
            u.MasterPhotoPath = @"C:\Users\Public\ONRMuhendislik\Ürün Resimleri\" + resimAdi + ".jpg";
            File.Copy(BLLMarka.ResimKontrol(pictureBox1.ImageLocation), @"C:\Users\Public\ONRMuhendislik\Ürün Resimleri\" + resimAdi + ".jpg");
            if (File.Exists(eskiFoto))
            {
                File.Delete(eskiFoto);
            }
            string cevap = BLLUrun.Duzenle(u);
            MessageBox.Show(cevap);
            frmUrunler f = Application.OpenForms["frmUrunler"] as frmUrunler;
            f.Doldur();
        }
    }
}
