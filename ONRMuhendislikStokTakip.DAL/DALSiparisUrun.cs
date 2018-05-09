using ONRMuhendislikStokTakip.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ONRMuhendislikStokTakip.DAL
{
    public class DALSiparisUrun
    {
        public static List<ESiparisUrun> SiparisUrunListele(int p)
        {
            SqlCommand cmd = new SqlCommand("sp_SiparisUrunListele", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sID", p);
            baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<ESiparisUrun> suListe = new List<ESiparisUrun>();
            while (dr.Read())
            {
                ESiparisUrun su = new ESiparisUrun();
                su.ID = Convert.ToInt32(dr["ID"].ToString());
                su.OrderID = Convert.ToInt32(dr["OrderID"].ToString());
                su.ProductID = Convert.ToInt32(dr["ProductID"].ToString());
                su.Price = Convert.ToDecimal(dr["Price"].ToString());
                su.Quantity = Convert.ToInt32(dr["Quantity"].ToString());
                suListe.Add(su);
            }
            dr.Close();
            baglanti.conn.Close();
            return suListe;
        }
    }
}
