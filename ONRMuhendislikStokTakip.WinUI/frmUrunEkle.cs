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
    public partial class frmUrunEkle : Form
    {
        public frmUrunEkle()
        {
            InitializeComponent();
        }

        private void frmUrunEkle_Load(object sender, EventArgs e)
        {
            cmbAltKategori.Enabled = false;
            cmbKategori.DataSource = BLLKategori.Listele();
            cmbKategori.DisplayMember = "CategoryName";
            cmbKategori.ValueMember = "ID";


            cmbMarka.DataSource = BLLMarka.Listele();
            cmbMarka.DisplayMember = "BrandName";
            cmbMarka.ValueMember = "ID";
        }

        private void cmbKategori_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbKategori.SelectedValue);
            cmbAltKategori.Enabled = true;
            cmbAltKategori.DataSource = BLLAltKategori.AltKategoriListele(id);
            cmbAltKategori.DisplayMember = "SubCategoryName";
            cmbAltKategori.ValueMember = "ID";
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

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(@"C:\Users\Public\ONRMuhendislik"))
                Directory.CreateDirectory(@"C:\Users\Public\ONRMuhendislik");

            if (!Directory.Exists(@"C:\Users\Public\ONRMuhendislik\Ürün Resimleri"))
                Directory.CreateDirectory(@"C:\Users\Public\ONRMuhendislik\Ürün Resimleri");

            EUrun u = new EUrun();
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
            string cevap = BLLUrun.Ekle(u);
            if (cevap == "Eklendi...")
            {
                File.Copy(BLLMarka.ResimKontrol(pictureBox1.ImageLocation), @"C:\Users\Public\ONRMuhendislik\Ürün Resimleri\" + resimAdi + ".jpg");
            }           
            MessageBox.Show(cevap);
            frmUrunler f = Application.OpenForms["frmUrunler"] as frmUrunler;
            f.Doldur();
        }      
    }
}
