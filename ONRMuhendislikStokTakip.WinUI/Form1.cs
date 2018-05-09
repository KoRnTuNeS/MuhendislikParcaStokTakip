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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            frmKategoriler f = new frmKategoriler();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMarkalar f = new frmMarkalar();
            f.Show();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            frmUrunler f = new frmUrunler();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMusteriler f = new frmMusteriler();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSiparisler f = new frmSiparisler();
            f.Show();
        }

        private void btnIncele_Click(object sender, EventArgs e)
        {
            frmSiparisIncele f = new frmSiparisIncele();
            f.Show();
        }
        public void Doldur()
        {
            lviSiparisler.Items.Clear();
            foreach (ESiparis item in BLLSiparis.Listele())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.ID.ToString();
                lvi.SubItems.Add(BLLMusteri.MusteriBul(item.CustomerID).Username);
                lvi.SubItems.Add(BLLAdres.AdresBul(item.AddressID).AddressName);
                lvi.SubItems.Add(BLLSiparis.Durum(item.Status));
                lvi.SubItems.Add(item.OrderDate.ToString());
                lvi.SubItems.Add(BLLSiparis.KargoKodu(item.ShippingCode));

                lviSiparisler.Items.Add(lvi);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Doldur();

        }
        public static int sID;
        private void lviSiparisler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            sID = Convert.ToInt32(lviSiparisler.SelectedItems[0].SubItems[0].Text);
            ESiparis s = BLLSiparis.SiparisBul(sID);
            frmSiparisIncele frm = new frmSiparisIncele();
            frm.Show();
        }
    }
}
