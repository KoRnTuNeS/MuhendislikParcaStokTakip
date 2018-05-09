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
    public partial class frmAdresDuzenle : Form
    {
        public frmAdresDuzenle()
        {
            InitializeComponent();
        }
        EAdres a;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            a.AddressName = txtAdresAdi.Text;
            a.Firstname = txtAliciAdi.Text;
            a.Lastname = txtAliciSoyadi.Text;
            a.City = txtil.Text;
            a.Town = txtilce.Text;
            a.PostalCode = Convert.ToInt32(txtPostaKodu.Text);
            a.Address = txtAdres.Text;
            string cevap = BLLAdres.Duzenle(a);
            MessageBox.Show(cevap);
            frmAdresListele f = Application.OpenForms["frmAdresListele"] as frmAdresListele;
            f.Doldur();
        }

        private void frmAdresDuzenle_Load(object sender, EventArgs e)
        {
            a = BLLAdres.AdresBul(frmAdresListele.aID);
            lblKullanici.Text = BLLMusteri.MusteriBul(a.CustomerID).Username;
            txtAdresAdi.Text = a.AddressName;
            txtAliciAdi.Text = a.Firstname;
            txtAliciSoyadi.Text = a.Lastname;
            txtil.Text = a.City;
            txtilce.Text = a.Town;
            txtPostaKodu.Text = a.PostalCode.ToString();
            txtAdres.Text = a.Address;
        }
    }
}
