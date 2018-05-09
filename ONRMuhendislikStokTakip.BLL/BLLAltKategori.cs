using ONRMuhendislikStokTakip.DAL;
using ONRMuhendislikStokTakip.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ONRMuhendislikStokTakip.BLL
{
    public class BLLAltKategori
    {

        public static List<EAltKategori> AltKategoriListele(int p)
        {
            return DALAltKategori.ALtKategoriListele(p);
        }

        public static string Ekle(EAltKategori ak)
        {
            if (ak.SubCategoryName != "")
            {
                if (DALAltKategori.Ekle(ak) > 0)
                {
                    return "Eklendi...";
                }
                else
                {
                    return "Aynı alt kategoriden var, farklı bir isim giriniz...";
                }                
            }
            return "Hatalı işlem...";
        }

        public static EAltKategori AltKategoriBul(int altKatID)
        {
            return DALAltKategori.AltKategoriBul(altKatID);
        }

        public static string Sil(EAltKategori ak)
        {
            if (ak.ID > 0)
            {
                DALAltKategori.Sil(ak);
                return "Silindi";
            }
            else
            {
                return "Hatalı işlem...";
            }
        }

        public static string Duzenle(EAltKategori ak)
        {
            if (ak.ID <= 0 || ak.SubCategoryName == "")
            {
                return "Hatalı işlem...";
            }
            else
            {
                DALAltKategori.Duzenle(ak);
                return "Düzenlendi...";
            }
        }
    }
}
