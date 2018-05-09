using ONRMuhendislikStokTakip.DAL;
using ONRMuhendislikStokTakip.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ONRMuhendislikStokTakip.BLL
{
    public class BLLMarka
    {
        public static string Ekle(EMarka m)
        {
            if (m.BrandName != "" && m.BrandPhotoPath != "")
            {
                if (DALMarka.Ekle(m) > 0)
                {
                    return "Eklendi...";
                }
                else
                {
                    return "Aynı marka var, farklı bir isim giriniz...";
                }
            }
            return "Hatalı işlem...";
        }

        public static List<EMarka> Listele()
        {
            return DALMarka.Listele();
        }

        public static EMarka MarkaBul(int mID)
        {
            return DALMarka.MarkaBul(mID);
        }

        public static string Sil(EMarka m)
        {
            if (m.ID > 0)
            {
                DALMarka.Sil(m);
                return "Silindi";
            }
            else
            {
                return "Hatalı işlem...";
            }
        }        
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

        public static string Duzenle(EMarka m)
        {
            if (m.ID < 0 || m.BrandName == "" || m.BrandPhotoPath == "")
            {
                return "Hatalı işlem...";
            }
            else
            {
                DALMarka.Duzenle(m);
                return "Düzenlendi...";
            }
        }
    }
}
