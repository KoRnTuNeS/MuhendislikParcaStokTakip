using ONRMuhendislikStokTakip.DAL;
using ONRMuhendislikStokTakip.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ONRMuhendislikStokTakip.BLL
{
    public class BLLUrun
    {
        public static string ResimKontrol(string p)
        {
            if (p == null)
            {
                return "Hata";
            }
            else
            {
                return p;
            }
        }

        public static string Ekle(EUrun u)
        {
            if (u.ProductName != "" && u.SubCategoryID > 0 && u.BrandID > 0 && u.Price > 0 && u.Stock > 0 && u.MasterPhotoPath != "")
            {
                if (DALUrun.Ekle(u) > 0)
                {
                    return "Eklendi...";
                }
                else
                {
                    return "Aynı ürün var, farklı bir isim giriniz...";
                }
            }
            return "Hatalı işlem...";
        }

        public static List<EUrun> Listele()
        {
            return DALUrun.Listele();
        }

        public static EUrun UrunBul(int urunID)
        {
            return DALUrun.UrunBul(urunID);
        }

        public static string Sil(EUrun u)
        {
            if (u.ID > 0)
            {
                DALUrun.Sil(u);
                return "Silindi...";
            }
            else
            {
                return "Hatalı işlem...";
            }
        }

        public static string Duzenle(EUrun u)
        {
            if (u.SubCategoryID <= 0 || u.BrandID <= 0 || u.ProductName == "" || u.Price <=0 || u.Stock < 0 || u.MasterPhotoPath == "")
            {
                return "Hatalı işlem";
            }
            else
            {
                DALUrun.Duzenle(u);
                return "Düzenlendi...";
            }
        }
    }
}
