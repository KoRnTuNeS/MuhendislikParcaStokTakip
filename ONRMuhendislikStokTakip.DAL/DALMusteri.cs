using ONRMuhendislikStokTakip.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ONRMuhendislikStokTakip.DAL
{
    public class DALMusteri
    {
        public static List<EMusteri> Listele()
        {
            SqlCommand cmd = new SqlCommand("sp_MusteriListele", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<EMusteri> mListe = new List<EMusteri>();
            while (dr.Read())
            {
                EMusteri m = new EMusteri();
                m.ID = Convert.ToInt32(dr["ID"].ToString());
                m.Firstname = dr["Firstname"].ToString();
                m.Lastname = dr["Lastname"].ToString();
                m.Mail = dr["Mail"].ToString();
                m.Phone = dr["Phone"].ToString();
                m.RegisteredDate = Convert.ToDateTime(dr["RegisteredDate"].ToString());
                mListe.Add(m);
            }
            dr.Close();
            baglanti.conn.Close();
            return mListe;
        }

        public static int Ekle(EMusteri m)
        {
            SqlCommand cmd = new SqlCommand("sp_MusteriEkle", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@kulAdi", m.Username);
            cmd.Parameters.AddWithValue("@sifre", m.Password);
            cmd.Parameters.AddWithValue("@ad", m.Firstname);
            cmd.Parameters.AddWithValue("@soyad", m.Lastname);
            cmd.Parameters.AddWithValue("@mail", m.Mail);
            cmd.Parameters.AddWithValue("telefon", m.Phone);
            baglanti.conn.Open();
            int sayi = cmd.ExecuteNonQuery();
            baglanti.conn.Close();
            return sayi;
        }

        public static EMusteri MusteriBul(int mID)
        {
            SqlCommand cmd = new SqlCommand("sp_MusteriBul", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mID", mID);
            baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            EMusteri m = new EMusteri();
            while (dr.Read())
            {
                m.ID = Convert.ToInt32(dr["ID"].ToString());
                m.Username = dr["Username"].ToString();
                m.Password = dr["Password"].ToString();
                m.Firstname = dr["Firstname"].ToString();
                m.Lastname = dr["Lastname"].ToString();
                m.Mail = dr["Mail"].ToString();
                m.Phone = dr["Phone"].ToString();
                m.RegisteredDate = Convert.ToDateTime(dr["RegisteredDate"].ToString());
            }
            dr.Close();
            baglanti.conn.Close();
            return m;
        }

        public static void Sil(EMusteri m)
        {
            SqlCommand cmd = new SqlCommand("sp_MusteriSil", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mID", m.ID);
            baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            baglanti.conn.Close();
        }

        public static void Duzenle(EMusteri m)
        {
            SqlCommand cmd = new SqlCommand("sp_MusteriDuzenle", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", m.ID);
            cmd.Parameters.AddWithValue("@kulAdi", m.Username);
            cmd.Parameters.AddWithValue("@sifre", m.Password);
            cmd.Parameters.AddWithValue("@ad", m.Firstname);
            cmd.Parameters.AddWithValue("@soyad", m.Lastname);
            cmd.Parameters.AddWithValue("@mail", m.Mail);
            cmd.Parameters.AddWithValue("@telefon", m.Phone);
            baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            baglanti.conn.Close();
        }
    }
}
