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
    public partial class frmSiparisler : Form
    {
        public frmSiparisler()
        {
            InitializeComponent();
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

        private void frmSiparisler_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        public static int sID;
        private void lviSiparisler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            sID = Convert.ToInt32(lviSiparisler.SelectedItems[0].SubItems[0].Text);
            ESiparis s = BLLSiparis.SiparisBul(sID);
            lblSiparisID.Text = s.ID.ToString();
        }

        private void btnIncele_Click(object sender, EventArgs e)
        {
            frmSiparisIncele f = new frmSiparisIncele();
            f.Show();
        }
    }
}
