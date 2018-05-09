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
    public partial class frmAdresListele : Form
    {
        public frmAdresListele()
        {
            InitializeComponent();
        }
        public void Doldur()
        {
            lviAdresler.Items.Clear();
            EMusteri m = BLLMusteri.MusteriBul(frmMusteriler.mID);
            foreach (EAdres item in BLLAdres.MusteriAdresListele(m.ID))
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.ID.ToString();
                lvi.SubItems.Add(item.AddressName.ToString());
                lvi.SubItems.Add(item.Firstname.ToString());
                lvi.SubItems.Add(item.Lastname.ToString());
                lvi.SubItems.Add(item.City.ToString());
                lvi.SubItems.Add(item.Town.ToString());
                lvi.SubItems.Add(item.PostalCode.ToString());
                lvi.SubItems.Add(item.Address.ToString());

                lviAdresler.Items.Add(lvi);
            }
        }
        private void frmAdresListele_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAdresEkle f = new frmAdresEkle();
            f.Show();
        }
        public static int aID;
        private void lviAdresler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            aID = Convert.ToInt32(lviAdresler.SelectedItems[0].SubItems[0].Text);
            EAdres a = BLLAdres.AdresBul(aID);
            lblAdresAdi.Text = a.AddressName;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            EAdres a = BLLAdres.AdresBul(aID);
            string cevap = BLLAdres.Sil(a);
            MessageBox.Show(cevap);
            Doldur();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            frmAdresDuzenle f = new frmAdresDuzenle();
            f.Show();
        }
    }
}
