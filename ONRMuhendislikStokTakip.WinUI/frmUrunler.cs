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
    public partial class frmUrunler : Form
    {
        public frmUrunler()
        {
            InitializeComponent();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            frmUrunEkle f = new frmUrunEkle();
            f.Show();
        }

        public void Doldur()
        {
            lviUrunler.Items.Clear();
            foreach (EUrun item in BLLUrun.Listele())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.ID.ToString();
                //lvi.SubItems.Add(BLLKategori.UrunKategoriBul(item.SubCategoryID));
                lvi.SubItems.Add(BLLKategori.UrunKategoriBul(item.SubCategoryID).CategoryName);
                lvi.SubItems.Add(BLLAltKategori.AltKategoriBul(item.SubCategoryID).SubCategoryName);
                lvi.SubItems.Add(BLLMarka.MarkaBul(item.BrandID).BrandName);
                lvi.SubItems.Add(item.ProductName.ToString());
                lvi.SubItems.Add(item.Price.ToString("c2"));
                lvi.SubItems.Add(item.Stock.ToString());
                lvi.SubItems.Add(item.Description.ToString());
                lvi.SubItems.Add(item.MasterPhotoPath.ToString());

                lviUrunler.Items.Add(lvi);
            }
        }

        private void frmUrunler_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        public static int urunID;
        private void lviUrunler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            urunID = Convert.ToInt32(lviUrunler.SelectedItems[0].SubItems[0].Text);
            EUrun u = BLLUrun.UrunBul(urunID);
            lblUrunAdi.Text = u.ProductName;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            EUrun u = BLLUrun.UrunBul(urunID);
            string cevap = BLLUrun.Sil(u);
            if (File.Exists(u.MasterPhotoPath))
            {
                File.Delete(u.MasterPhotoPath);
            }
            MessageBox.Show(cevap);
            Doldur();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            frmUrunDuzenle f = new frmUrunDuzenle();
            f.Show();
        }
    }
}
