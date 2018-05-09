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
    public partial class frmAdresDetay : Form
    {
        public frmAdresDetay()
        {
            InitializeComponent();
        }

        private void frmAdresDetay_Load(object sender, EventArgs e)
        {
            EAdres a = BLLAdres.AdresBul(BLLSiparis.SiparisBul(Form1.sID).AddressID);
            lblAd.Text = a.Firstname;
            lblSoyad.Text = a.Lastname;
            lblil.Text = a.City;
            lblilce.Text = a.Town;
            lblPostaKodu.Text = a.PostalCode.ToString();
            lblAdres.Text = a.Address;
        }
    }
}
