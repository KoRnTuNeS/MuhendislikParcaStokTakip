using ONRMuhendislikStokTakip.BLL;
using ONRMuhendislikStokTakip.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ONRMuhendislikStokTakip.WinUI
{
    public partial class frmMarkalar : Form
    {
        public frmMarkalar()
        {
            InitializeComponent();
        }

        private void btnGozat_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult cevap = ofd.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName; //filename dosyanın adresini bize teslim eder.
                btnGozat.Visible = false;
            }
        }

        private void resmiDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnGozat.Visible = true;
            btnGozat.PerformClick(); //otomatik tıklatma
            btnGozat.Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(@"C:\Users\Public\ONRMuhendislik"))
            Directory.CreateDirectory(@"C:\Users\Public\ONRMuhendislik");

            if (!Directory.Exists(@"C:\Users\Public\ONRMuhendislik\Marka Resimleri"))
                Directory.CreateDirectory(@"C:\Users\Public\ONRMuhendislik\Marka Resimleri");

            EMarka m = new EMarka();
            m.BrandName = txtMarkaAdi.Text;
            Guid resimAdi = Guid.NewGuid();
            if (BLLMarka.ResimKontrol(pictureBox1.ImageLocation) == "Hata")
            {
                MessageBox.Show("Resim seçiniz...");
                return;
            }

            m.BrandPhotoPath = @"C:\Users\Public\ONRMuhendislik\Marka Resimleri\" + resimAdi + ".jpg";
            string cevap = BLLMarka.Ekle(m);
            if (cevap == "Eklendi...")
            {
                File.Copy(BLLMarka.ResimKontrol(pictureBox1.ImageLocation), @"C:\Users\Public\ONRMuhendislik\Marka Resimleri\" + resimAdi + ".jpg");
            }
            MessageBox.Show(cevap);
            Doldur();
        }
        private void Doldur()
        {
            lviMarkalar.Items.Clear();
            foreach (EMarka item in BLLMarka.Listele())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.ID.ToString();
                lvi.SubItems.Add(item.BrandName.ToString());
                lvi.SubItems.Add(item.BrandPhotoPath.ToString());

                lviMarkalar.Items.Add(lvi);
            }
        }

        private void frmMarkalar_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        public static int mID;
        private void lviMarkalar_DoubleClick(object sender, EventArgs e)
        {
            mID = Convert.ToInt32(lviMarkalar.SelectedItems[0].SubItems[0].Text);
            EMarka m = BLLMarka.MarkaBul(mID);
            txtMarkaAdi.Text = m.BrandName;
            pictureBox1.ImageLocation = m.BrandPhotoPath;
            btnGozat.Visible = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            EMarka m = BLLMarka.MarkaBul(mID);
            string cevap = BLLMarka.Sil(m);
            if (File.Exists(m.BrandPhotoPath))
            {
                File.Delete(m.BrandPhotoPath);
            }
            MessageBox.Show(cevap);
            Doldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            EMarka m = BLLMarka.MarkaBul(mID);
            string eskiFoto = m.BrandPhotoPath;
            m.BrandName = txtMarkaAdi.Text;
            Guid resimAdi = Guid.NewGuid();
            if (BLLMarka.ResimKontrol(pictureBox1.ImageLocation) == "Hata")
            {
                MessageBox.Show("Resim seçiniz...");
                return;
            }
            m.BrandPhotoPath = @"C:\Users\Public\ONRMuhendislik\Marka Resimleri\" + resimAdi + ".jpg";
            File.Copy(BLLMarka.ResimKontrol(pictureBox1.ImageLocation), @"C:\Users\Public\ONRMuhendislik\Marka Resimleri\" + resimAdi + ".jpg");
            if (File.Exists(eskiFoto))
            {
                File.Delete(eskiFoto);
            }
            string cevap = BLLMarka.Duzenle(m);
            MessageBox.Show(cevap);
            Doldur();
        }
    }
}
