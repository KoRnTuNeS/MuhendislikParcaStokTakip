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
    public partial class frmMusteriEkle : Form
    {
        public frmMusteriEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            EMusteri m = new EMusteri();
            m.Username = txtMail.Text;
            m.Password = txtSifre.Text;
            m.Firstname = txtAdi.Text;
            m.Lastname = txtSoyadi.Text;
            m.Mail = txtMail.Text;
            m.Phone = txtTelefon.Text;
            m.RegisteredDate = DateTime.Now;
            string cevap = BLLMusteri.Ekle(m);
            MessageBox.Show(cevap);
            frmMusteriler f = Application.OpenForms["frmMusteriler"] as frmMusteriler;
            f.Doldur();
        }
    }
}
