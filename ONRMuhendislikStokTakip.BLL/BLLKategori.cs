using ONRMuhendislikStokTakip.DAL;
using ONRMuhendislikStokTakip.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ONRMuhendislikStokTakip.BLL
{
    public class BLLKategori
    {
        public static string Ekle(EKategori k)
        {
            if (k.CategoryName != "")
            {
                if (DALKategori.Ekle(k) > 0)
                {
                    return "Eklendi...";
                }
                else
                {
                    return "Aynı kategoriden var, farklı bir isim giriniz...";
                }
            }
            return "Hatalı işlem...";
        }

        public static List<EKategori> Listele()
        {
            return DALKategori.Listele();
        }

        public static EKategori KategoriBul(int katID)
        {
            return DALKategori.KategoriBul(katID);
        }

        

        public static string Sil(EKategori k)
        {
            if (k.ID > 0)
            {
                DALKategori.Sil(k);
                return "Silindi";
            }
            else
            {
                return "Hatalı işlem...";
            }
        }

        public static string Duzenle(EKategori k)
        {
            if (k.ID <= 0 || k.CategoryName == "")
            {
                return "Hatalı işlem...";
            }
            else
            {
                DALKategori.Duzenle(k);
                return "Düzenlendi...";
            }
        }

        //public static string UrunKategoriBul(int p)
        //{
        //    return DALKategori.UrunKategoriBul(p);
        //}

        public static EKategori UrunKategoriBul(int p)
        {
            return DALKategori.UrunKategoriBul(p);
        }
    }
}
