using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ONRMuhendislikStokTakip.DAL
{
    class baglanti
    {
        public static SqlConnection conn = new SqlConnection("Server=ALPERPC\\SQLEXPRESS;DataBase=ONRMuhendislik;Integrated Security=true");
    }
}
