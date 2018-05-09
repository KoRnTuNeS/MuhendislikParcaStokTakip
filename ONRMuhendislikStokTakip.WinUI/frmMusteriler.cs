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
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }

        public void Doldur()
        {
            lviMusteriler.Items.Clear();
            foreach (EMusteri item in BLLMusteri.Listele())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.ID.ToString();
                lvi.SubItems.Add(item.Firstname);
                lvi.SubItems.Add(item.Lastname);
                lvi.SubItems.Add(item.Mail);
                lvi.SubItems.Add(item.Phone);
                lvi.SubItems.Add(item.RegisteredDate.ToString());

                lviMusteriler.Items.Add(lvi);
            }
        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        public static int mID;
        private void lviMusteriler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            mID = Convert.ToInt32(lviMusteriler.SelectedItems[0].SubItems[0].Text);
            EMusteri m = BLLMusteri.MusteriBul(mID);
            lblSecilen.Text = m.Firstname + " " + m.Lastname;
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            frmMusteriEkle f = new frmMusteriEkle();
            f.Show();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            EMusteri m = BLLMusteri.MusteriBul(mID);
            string cevap = BLLMusteri.Sil(m);
            MessageBox.Show(cevap);
            Doldur();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            frmMusteriDuzenle f = new frmMusteriDuzenle();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAdresListele f = new frmAdresListele();
            f.Show();
        }
    }
}
