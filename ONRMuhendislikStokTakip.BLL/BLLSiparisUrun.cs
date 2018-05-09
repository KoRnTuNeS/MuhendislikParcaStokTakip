using ONRMuhendislikStokTakip.DAL;
using ONRMuhendislikStokTakip.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ONRMuhendislikStokTakip.BLL
{
    public class BLLSiparisUrun
    {
        public static List<ESiparisUrun> SiparisUrunListele(int p)
        {
            return DALSiparisUrun.SiparisUrunListele(p);
        }
    }
}
