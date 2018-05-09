using ONRMuhendislikStokTakip.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ONRMuhendislikStokTakip.DAL
{
    public class DALSiparis
    {
        public static List<ESiparis> Listele()
        {
            SqlCommand cmd = new SqlCommand("sp_SiparisListele", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<ESiparis> sListe = new List<ESiparis>();
            while (dr.Read())
            {
                ESiparis s = new ESiparis();
                s.ID = Convert.ToInt32(dr["ID"].ToString());
                s.CustomerID = Convert.ToInt32(dr["CustomerID"].ToString());
                s.AddressID = Convert.ToInt32(dr["AddressID"].ToString());
                s.Status = Convert.ToBoolean(dr["Status"].ToString());
                s.OrderDate = Convert.ToDateTime(dr["OrderDate"].ToString());
                s.ShippingCode = dr["ShippingCode"].ToString();
                sListe.Add(s);
            }
            dr.Close();
            baglanti.conn.Close();
            return sListe;
        }

        public static ESiparis SiparisBul(int sID)
        {
            SqlCommand cmd = new SqlCommand("sp_SiparisBul", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sID", sID);
            baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            ESiparis s = new ESiparis();
            while (dr.Read())
            {
                s.ID = Convert.ToInt32(dr["ID"].ToString());
                s.CustomerID = Convert.ToInt32(dr["CustomerID"].ToString());
                s.AddressID = Convert.ToInt32(dr["AddressID"].ToString());
                s.Status = Convert.ToBoolean(dr["Status"].ToString());
                s.OrderDate = Convert.ToDateTime(dr["OrderDate"].ToString());
                s.ShippingCode = dr["ShippingCode"].ToString();
            }
            dr.Close();
            baglanti.conn.Close();
            return s;
        }

        public static void KargoKoduDuzenle(ESiparis s)
        {
            SqlCommand cmd = new SqlCommand("sp_KargoKoduDuzenle", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", s.ID);
            cmd.Parameters.AddWithValue("@kargoKodu", s.ShippingCode);
            baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            baglanti.conn.Close();
        }
    }
}
