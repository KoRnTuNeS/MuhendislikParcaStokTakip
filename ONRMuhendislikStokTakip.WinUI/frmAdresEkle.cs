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
    public partial class frmAdresEkle : Form
    {
        public frmAdresEkle()
        {
            InitializeComponent();
        }
        EMusteri m;
        private void frmAdresEkle_Load(object sender, EventArgs e)
        {
            m = BLLMusteri.MusteriBul(frmMusteriler.mID);
            lblKullanici.Text = m.Mail;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            EAdres a = new EAdres();
            a.CustomerID = m.ID;
            a.AddressName = txtAdresAdi.Text;
            a.Firstname = txtAliciAdi.Text;
            a.Lastname = txtAliciSoyadi.Text;
            a.City = txtil.Text;
            a.Town = txtilce.Text;
            a.PostalCode = Convert.ToInt32(txtPostaKodu.Text);
            a.Address = txtAdres.Text;
            string cevap = BLLAdres.Ekle(a);
            MessageBox.Show(cevap);
            frmAdresListele f = Application.OpenForms["frmAdresListele"] as frmAdresListele;
            f.Doldur();
        }
    }
}
