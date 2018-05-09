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
    public partial class frmAltKategori : Form
    {
        public frmAltKategori()
        {
            InitializeComponent();
        }

        public void Doldur()
        {
            lviAltKategori.Items.Clear();
            EKategori k = BLLKategori.KategoriBul(frmKategoriler.katID);
            foreach (EAltKategori item in BLLAltKategori.AltKategoriListele(k.ID))
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.ID.ToString();
                lvi.SubItems.Add(item.SubCategoryName.ToString());

                lviAltKategori.Items.Add(lvi);
            }
        }

        private void frmAltKategori_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            EKategori k = BLLKategori.KategoriBul(frmKategoriler.katID);
            EAltKategori ak = new EAltKategori();
            ak.SubCategoryName = txtAltKategoriAdi.Text;
            ak.CaregoryID = k.ID;
            string cevap = BLLAltKategori.Ekle(ak);
            MessageBox.Show(cevap);
            Doldur();
        }
        public static int altKatID;
        private void lviAltKategori_DoubleClick(object sender, EventArgs e)
        {
            altKatID = Convert.ToInt32(lviAltKategori.SelectedItems[0].SubItems[0].Text);
            EAltKategori ak = BLLAltKategori.AltKategoriBul(altKatID);
            txtAltKategoriAdi.Text = ak.SubCategoryName;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            EAltKategori ak = BLLAltKategori.AltKategoriBul(altKatID);
            string cevap = BLLAltKategori.Sil(ak);
            MessageBox.Show(cevap);
            Doldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            EAltKategori ak = BLLAltKategori.AltKategoriBul(altKatID);
            ak.SubCategoryName = txtAltKategoriAdi.Text;
            string cevap = BLLAltKategori.Duzenle(ak);
            MessageBox.Show(cevap);
            Doldur();
        }
    }
}
