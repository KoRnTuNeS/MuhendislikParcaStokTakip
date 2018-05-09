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
    public partial class frmSiparisIncele : Form
    {
        public frmSiparisIncele()
        {
            InitializeComponent();
        }
        decimal ToplamFiyat = 0;
        private void Doldur()
        {
            lviSiparisUrunler.Items.Clear();
            foreach (ESiparisUrun item in BLLSiparisUrun.SiparisUrunListele(Form1.sID))
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = BLLKategori.UrunKategoriBul(BLLUrun.UrunBul(item.ProductID).SubCategoryID).CategoryName;
                lvi.SubItems.Add(BLLAltKategori.AltKategoriBul(BLLUrun.UrunBul(item.ProductID).SubCategoryID).SubCategoryName);
                lvi.SubItems.Add(BLLUrun.UrunBul(item.ProductID).ProductName);
                lvi.SubItems.Add(item.Price.ToString("c2"));
                lvi.SubItems.Add(item.Quantity.ToString());
                lvi.SubItems.Add((item.Price * item.Quantity).ToString("c2"));
                lviSiparisUrunler.Items.Add(lvi);                
            }
        }
        private void frmSiparisIncele_Load(object sender, EventArgs e)
        {
            int sID = Form1.sID;
            lblMusteri.Text = BLLMusteri.MusteriBul(BLLSiparis.SiparisBul(sID).CustomerID).Username;
            lblSiparisTarihi.Text = BLLSiparis.SiparisBul(sID).OrderDate.ToString();
            txtKargoKodu.Text = BLLSiparis.SiparisBul(sID).ShippingCode;
            bool aktifMi;
            if (BLLSiparis.SiparisBul(sID).Status == true)
	        {
		        aktifMi = true;
	        }
            else
	        {
                aktifMi = false;
	        }

            chkAktifMi.Checked = aktifMi;
            foreach (ESiparisUrun item in BLLSiparisUrun.SiparisUrunListele(Form1.sID))
            {
                ToplamFiyat += item.Price * item.Quantity;
            }
            lblToplamFiyat.Text = ToplamFiyat.ToString("c2");
            
            Doldur();
        }

        private void linkAdres_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdresDetay f = new frmAdresDetay();
            f.Show();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ESiparis s = BLLSiparis.SiparisBul(frmSiparisler.sID);
            s.ShippingCode = txtKargoKodu.Text;
            string cevap = BLLSiparis.KargoKoduDuzenle(s);
            MessageBox.Show(cevap);
            Form1 f = Application.OpenForms["Form1"] as Form1;
            f.Doldur();
        }
    }
}
