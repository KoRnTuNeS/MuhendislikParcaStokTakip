using ONRMuhendislikStokTakip.DAL;
using ONRMuhendislikStokTakip.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ONRMuhendislikStokTakip.BLL
{
    public class BLLSiparis
    {
        public static List<ESiparis> Listele()
        {
            return DALSiparis.Listele();
        }

        public static string Durum(bool p)
        {
            if (p == true)
            {
                return "Aktif";
            }
            else
            {
                return "Pasif";
            }
        }

        public static string KargoKodu(string p)
        {
            if (p == null)
            {
                return "Beklemede";
            }
            else
            {
                return p;
            }
        }

        public static ESiparis SiparisBul(int sID)
        {
            return DALSiparis.SiparisBul(sID);
        }

        public static string KargoKoduDuzenle(ESiparis s)
        {
            if (s.ShippingCode != "")
            {
                DALSiparis.KargoKoduDuzenle(s);
                return "Kargo kodu girildi...";
            }
            else
            {
                return "Hatalı işlem...";
            }
        }
    }
}
