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
    public partial class frmMusteriDuzenle : Form
    {
        public frmMusteriDuzenle()
        {
            InitializeComponent();
        }
        EMusteri m;
        private void frmMusteriDuzenle_Load(object sender, EventArgs e)
        {
            m = BLLMusteri.MusteriBul(frmMusteriler.mID);
            txtMail.Text = m.Mail;
            txtSifre.Text = m.Password;
            txtAdi.Text = m.Firstname;
            txtSoyadi.Text = m.Lastname;
            txtTelefon.Text = m.Phone;
        }
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            m.Username = txtMail.Text;
            m.Password = txtSifre.Text;
            m.Firstname = txtAdi.Text;
            m.Lastname = txtSoyadi.Text;
            m.Mail = txtMail.Text;
            m.Phone = txtTelefon.Text;
            string cevap = BLLMusteri.Duzenle(m);
            MessageBox.Show(cevap);
            frmMusteriler f = Application.OpenForms["frmMusteriler"] as frmMusteriler;
            f.Doldur();

        }        
    }
}
