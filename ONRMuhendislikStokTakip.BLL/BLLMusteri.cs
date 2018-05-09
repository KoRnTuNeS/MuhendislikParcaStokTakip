using ONRMuhendislikStokTakip.DAL;
using ONRMuhendislikStokTakip.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ONRMuhendislikStokTakip.BLL
{
    public class BLLMusteri
    {
        public static List<EMusteri> Listele()
        {
            return DALMusteri.Listele();
        }
        public static string Ekle(EMusteri m)
        {
            if (m.Mail != "" && m.Password != "" && m.Firstname != "" && m.Lastname != "" && m.Phone != "")
            {
                if (DALMusteri.Ekle(m) > 0)
                {
                    return "Eklendi";
                }
                else
                {
                    return "Aynı müşteri var, farklı bir isim giriniz...";
                }
            }
            return "Hatalı işlem";
        }

        public static EMusteri MusteriBul(int mID)
        {
            return DALMusteri.MusteriBul(mID);
        }

        public static string Sil(EMusteri m)
        {
            if (m.ID > 0)
            {
                DALMusteri.Sil(m);
                return "Silindi";
            }
            else
            {
                return "Hatalı işlem...";
            }
        }

        public static string Duzenle(EMusteri m)
        {
            if (m.ID < 0 || m.Firstname == "" || m.Lastname == "" || m.Username == "" || m.Password == "" || m.Mail == "" || m.Phone == "")
            {
                return "Hatalı işlem...";
            }
            else
            {
                DALMusteri.Duzenle(m);
                return "Düzenlendi...";
            }
        }
    }
}
