using ONRMuhendislikStokTakip.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ONRMuhendislikStokTakip.DAL
{
    public class DALUrun
    {
        public static int Ekle(EUrun u)
        {
            SqlCommand cmd = new SqlCommand("sp_UrunEkle", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@urunAdi", u.ProductName);
            cmd.Parameters.AddWithValue("@altKatID", u.SubCategoryID);
            cmd.Parameters.AddWithValue("@markaID", u.BrandID);
            cmd.Parameters.AddWithValue("@fiyat", u.Price);
            cmd.Parameters.AddWithValue("@stok", u.Stock);
            cmd.Parameters.AddWithValue("@aciklama", u.Description);
            cmd.Parameters.AddWithValue("@fotoYolu", u.MasterPhotoPath);
            baglanti.conn.Open();
            int sayi = cmd.ExecuteNonQuery();
            baglanti.conn.Close();
            return sayi;
        }

        public static List<EUrun> Listele()
        {
            SqlCommand cmd = new SqlCommand("sp_UrunListele", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<EUrun> uListe = new List<EUrun>();
            while (dr.Read())
            {
                EUrun u = new EUrun();
                u.ID = Convert.ToInt32(dr["ID"].ToString());
                u.SubCategoryID = Convert.ToInt32(dr["SubCategoryID"].ToString());
                u.BrandID = Convert.ToInt32(dr["BrandID"].ToString());
                u.ProductName = dr["ProductName"].ToString();
                u.Price = Convert.ToDecimal(dr["Price"].ToString());
                u.Stock = Convert.ToInt32(dr["Stock"].ToString());
                u.Description = dr["Description"].ToString();
                u.MasterPhotoPath = dr["MasterPhotoPath"].ToString();
                uListe.Add(u);
            }
            dr.Close();
            baglanti.conn.Close();
            return uListe;
        }

        public static EUrun UrunBul(int urunID)
        {
            SqlCommand cmd = new SqlCommand("sp_UrunBul", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            baglanti.conn.Open();
            cmd.Parameters.AddWithValue("@uID", urunID);
            SqlDataReader dr = cmd.ExecuteReader();
            EUrun u = new EUrun();
            while (dr.Read())
            {
                u.ID = Convert.ToInt32(dr["ID"].ToString());
                u.SubCategoryID = Convert.ToInt32(dr["SubCategoryID"].ToString());
                u.BrandID = Convert.ToInt32(dr["BrandID"].ToString());
                u.ProductName = dr["ProductName"].ToString();
                u.Price = Convert.ToDecimal(dr["Price"].ToString());
                u.Stock = Convert.ToInt32(dr["Stock"].ToString());
                u.Description = dr["Description"].ToString();
                u.MasterPhotoPath = dr["MasterPhotoPath"].ToString();
            }
            dr.Close();
            baglanti.conn.Close();
            return u;
        }

        public static void Sil(EUrun u)
        {
            SqlCommand cmd = new SqlCommand("sp_UrunSil", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", u.ID);
            baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            baglanti.conn.Close();
        }

        public static void Duzenle(EUrun u)
        {
            SqlCommand cmd = new SqlCommand("sp_UrunDuzenle", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", u.ID);
            cmd.Parameters.AddWithValue("@urunAdi", u.ProductName);
            cmd.Parameters.AddWithValue("@altKatID", u.SubCategoryID);
            cmd.Parameters.AddWithValue("@markaID", u.BrandID);
            cmd.Parameters.AddWithValue("@fiyat", u.Price);
            cmd.Parameters.AddWithValue("@stok", u.Stock);
            cmd.Parameters.AddWithValue("aciklama", u.Description);
            cmd.Parameters.AddWithValue("@fotoYolu", u.MasterPhotoPath);
            baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            baglanti.conn.Close();
        }
    }
}
