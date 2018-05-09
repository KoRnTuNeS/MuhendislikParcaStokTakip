using ONRMuhendislikStokTakip.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ONRMuhendislikStokTakip.DAL
{
    public class DALMarka
    {
        public static int Ekle(EMarka m)
        {
            SqlCommand cmd = new SqlCommand("sp_MarkaEkle", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mAdi", m.BrandName);
            cmd.Parameters.AddWithValue("@mFotoYolu", m.BrandPhotoPath);
            baglanti.conn.Open();
            int sayi = cmd.ExecuteNonQuery();
            baglanti.conn.Close();
            return sayi;
        }

        public static List<EMarka> Listele()
        {
            SqlCommand cmd = new SqlCommand("sp_MarkaListele", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<EMarka> mliste = new List<EMarka>();
            while (dr.Read())
            {
                EMarka m = new EMarka();
                m.ID = Convert.ToInt32(dr["ID"].ToString());
                m.BrandName = dr["BrandName"].ToString();
                m.BrandPhotoPath = dr["BrandPhotoPath"].ToString();
                mliste.Add(m);
            }
            dr.Close();
            baglanti.conn.Close();
            return mliste;
        }

        public static EMarka MarkaBul(int mID)
        {
            SqlCommand cmd = new SqlCommand("sp_MarkaBul", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            baglanti.conn.Open();
            cmd.Parameters.AddWithValue("@mID", mID);
            SqlDataReader dr = cmd.ExecuteReader();
            EMarka m = new EMarka();
            while (dr.Read())
            {
                m.ID = Convert.ToInt32(dr["ID"].ToString());
                m.BrandName = dr["BrandName"].ToString();
                m.BrandPhotoPath = dr["BrandPhotoPath"].ToString();
            }
            dr.Close();
            baglanti.conn.Close();
            return m;
        }

        public static void Sil(EMarka m)
        {
            SqlCommand cmd = new SqlCommand("sp_MarkaSil", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", m.ID);
            baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            baglanti.conn.Close();
        }

        public static void Duzenle(EMarka m)
        {
            SqlCommand cmd = new SqlCommand("sp_MarkaDuzenle", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mID", m.ID);
            cmd.Parameters.AddWithValue("@mAdi", m.BrandName);
            cmd.Parameters.AddWithValue("@mFotoYolu", m.BrandPhotoPath);
            baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            baglanti.conn.Close();
        }
    }
}
