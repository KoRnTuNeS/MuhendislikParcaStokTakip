using ONRMuhendislikStokTakip.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ONRMuhendislikStokTakip.DAL
{
    public class DALAltKategori
    {
        public static List<EAltKategori> ALtKategoriListele(int p)
        {
            SqlCommand cmd = new SqlCommand("select * from SubCategories where CategoryID = @katID", baglanti.conn);
            baglanti.conn.Open();
            cmd.Parameters.AddWithValue("@katID", p);
            SqlDataReader dr = cmd.ExecuteReader();
            List<EAltKategori> akListe = new List<EAltKategori>();
            while (dr.Read())
            {
                EAltKategori ak = new EAltKategori();
                ak.ID = Convert.ToInt32(dr["ID"].ToString());
                ak.CaregoryID = Convert.ToInt32(dr["CategoryID"].ToString());
                ak.SubCategoryName = dr["SubCategoryName"].ToString();
                akListe.Add(ak);
            }
            dr.Close();
            baglanti.conn.Close();
            return akListe;
        }

        public static int Ekle(EAltKategori ak)
        {
            SqlCommand cmd = new SqlCommand("sp_AltKategoriEkle", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@katAdi", ak.SubCategoryName);
            cmd.Parameters.AddWithValue("@katID", ak.CaregoryID);
            baglanti.conn.Open();
            int sayi = cmd.ExecuteNonQuery();
            baglanti.conn.Close();
            return sayi;
        }

        public static EAltKategori AltKategoriBul(int altKatID)
        {
            SqlCommand cmd = new SqlCommand("sp_AltKategoriBul", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            baglanti.conn.Open();
            cmd.Parameters.AddWithValue("@altKatID", altKatID);
            SqlDataReader dr = cmd.ExecuteReader();
            EAltKategori ak = new EAltKategori();
            while (dr.Read())
            {
                ak.ID = Convert.ToInt32(dr["ID"].ToString());
                ak.CaregoryID = Convert.ToInt32(dr["CategoryID"].ToString());
                ak.SubCategoryName = dr["SubCategoryName"].ToString();
            }
            dr.Close();
            baglanti.conn.Close();
            return ak;
        }

        public static void Sil(EAltKategori ak)
        {
            SqlCommand cmd = new SqlCommand("sp_AltKategoriSil", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", ak.ID);
            baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            baglanti.conn.Close();
        }

        public static void Duzenle(EAltKategori ak)
        {
            SqlCommand cmd = new SqlCommand("sp_AltKategoriDuzenle", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("altKatAdi", ak.SubCategoryName);
            cmd.Parameters.AddWithValue("id", ak.ID);
            baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            baglanti.conn.Close();
        }
    }
}
