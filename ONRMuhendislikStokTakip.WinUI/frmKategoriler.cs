using ONRMuhendislikStokTakip.BLL;
using ONRMuhendislikStokTakip.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ONRMuhendislikStokTakip.WinUI
{
    public partial class frmKategoriler : Form
    {
        public frmKategoriler()
        {
            InitializeComponent();
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            EKategori k = new EKategori();
            k.CategoryName = txtKategoriAdi.Text;
            string cevap = BLLKategori.Ekle(k);
            MessageBox.Show(cevap);
            Doldur();
        }

        private void Doldur()
        {
            lviKategoriler.Items.Clear();
            foreach (EKategori item in BLLKategori.Listele())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.ID.ToString();
                lvi.SubItems.Add(item.CategoryName.ToString());

                lviKategoriler.Items.Add(lvi);
            }
        }

        private void frmKategoriler_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        public static int katID;
        private void lviKategoriler_DoubleClick(object sender, EventArgs e)
        {
            katID = Convert.ToInt32(lviKategoriler.SelectedItems[0].SubItems[0].Text);
            EKategori k = BLLKategori.KategoriBul(katID);
            txtKategoriAdi.Text = k.CategoryName;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            EKategori k = BLLKategori.KategoriBul(katID);
            string cevap = BLLKategori.Sil(k);
            MessageBox.Show(cevap);
            Doldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            EKategori k = BLLKategori.KategoriBul(katID);
            k.CategoryName = txtKategoriAdi.Text;
            string cevap = BLLKategori.Duzenle(k);
            MessageBox.Show(cevap);
            Doldur();
        }
        
        private void btnIncele_Click(object sender, EventArgs e)
        {
            frmAltKategori f = new frmAltKategori();
            f.Show();
        }
    }
}
