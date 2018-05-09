using ONRMuhendislikStokTakip.DAL;
using ONRMuhendislikStokTakip.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ONRMuhendislikStokTakip.BLL
{
    public class BLLAdres
    {
        public static string Ekle(EAdres a)
        {
            if (a.CustomerID > 0 && a.AddressName != "" && a.Firstname != "" && a.Lastname != "" && a.City != "" && a.Town != "" && a.PostalCode > 0 && a.Address != "")
            {
                if (DALAdres.Ekle(a) > 0)
                {
                    return "Eklendi...";
                }
                else
                {
                    return "Aynı adres isminden var, farklı bir isim giriniz...";
                }
            }
            return "Hatalı işlem...";
        }

        public static List<EAdres> MusteriAdresListele(int p)
        {
            return DALAdres.MusteriAdresListele(p);
        }

        public static EAdres AdresBul(int aID)
        {
            return DALAdres.AdresBul(aID);
        }

        public static string Sil(EAdres a)
        {
            if (a.ID > 0)
            {
                DALAdres.Sil(a);
                return "Silindi";
            }
            else
            {
                return "Hatalı işlem...";
            }
        }

        public static string Duzenle(EAdres a)
        {
            if (a.ID <= 0 || a.AddressName == "" || a.Firstname == "" || a.Lastname == "" || a.City == "" || a.Town =="" || a.PostalCode <= 0 || a.Address == "")
            {
                return "Hatalı işlem...";
            }
            else
            {
                DALAdres.Duzenle(a);
                return "Düzenlendi...";
            }
        }
    }
}
