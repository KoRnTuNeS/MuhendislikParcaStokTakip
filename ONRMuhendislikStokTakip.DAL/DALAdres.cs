using ONRMuhendislikStokTakip.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ONRMuhendislikStokTakip.DAL
{
    public class DALAdres
    {
        public static int Ekle(EAdres a)
        {
            SqlCommand cmd = new SqlCommand("sp_AdresEkle", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mID", a.CustomerID);
            cmd.Parameters.AddWithValue("@adresAdi", a.AddressName);
            cmd.Parameters.AddWithValue("@mAdi", a.Firstname);
            cmd.Parameters.AddWithValue("@mSoyadi", a.Lastname);
            cmd.Parameters.AddWithValue("@il", a.City);
            cmd.Parameters.AddWithValue("@ilce", a.Town);
            cmd.Parameters.AddWithValue("@postaKodu", a.PostalCode);
            cmd.Parameters.AddWithValue("@adres", a.Address);
            baglanti.conn.Open();
            int sayi = cmd.ExecuteNonQuery();
            baglanti.conn.Close();
            return sayi;
        }

        public static List<EAdres> MusteriAdresListele(int p)
        {
            SqlCommand cmd = new SqlCommand("sp_MusteriAdresListele", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mID", p);
            baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<EAdres> aListe = new List<EAdres>();
            while (dr.Read())
            {
                EAdres a = new EAdres();
                a.ID = Convert.ToInt32(dr["ID"].ToString());
                a.CustomerID = Convert.ToInt32(dr["CustomerID"].ToString());
                a.AddressName = dr["AddressName"].ToString();
                a.Firstname = dr["Firstname"].ToString();
                a.Lastname = dr["Lastname"].ToString();
                a.City = dr["City"].ToString();
                a.Town = dr["Town"].ToString();
                a.PostalCode = Convert.ToInt32(dr["PostalCode"].ToString());
                a.Address = dr["Address"].ToString();
                aListe.Add(a);
            }
            dr.Close();
            baglanti.conn.Close();
            return aListe;
        }

        public static EAdres AdresBul(int aID)
        {
            SqlCommand cmd = new SqlCommand("sp_AdresBul", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@aID", aID);
            baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            EAdres a = new EAdres();
            while (dr.Read())
            {
                a.ID = Convert.ToInt32(dr["ID"].ToString());
                a.CustomerID = Convert.ToInt32(dr["CustomerID"].ToString());
                a.AddressName = dr["AddressName"].ToString();
                a.Firstname = dr["Firstname"].ToString();
                a.Lastname = dr["Lastname"].ToString();
                a.City = dr["City"].ToString();
                a.Town = dr["Town"].ToString();
                a.PostalCode = Convert.ToInt32(dr["PostalCode"].ToString());
                a.Address = dr["Address"].ToString();
            }
            dr.Close();
            baglanti.conn.Close();
            return a;
        }

        public static void Sil(EAdres a)
        {
            SqlCommand cmd = new SqlCommand("sp_AdresSil", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@aID", a.ID);
            baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            baglanti.conn.Close();
        }

        public static void Duzenle(EAdres a)
        {
            SqlCommand cmd = new SqlCommand("sp_AdresDuzenle", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", a.ID);
            cmd.Parameters.AddWithValue("@adresAdi", a.AddressName);
            cmd.Parameters.AddWithValue("@aliciAdi", a.Firstname);
            cmd.Parameters.AddWithValue("@aliciSoyadi", a.Lastname);
            cmd.Parameters.AddWithValue("@il", a.City);
            cmd.Parameters.AddWithValue("@ilce", a.Town);
            cmd.Parameters.AddWithValue("@postaKodu", a.PostalCode);
            cmd.Parameters.AddWithValue("@adres", a.Address);
            baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            baglanti.conn.Close();
        }
    }
}
