using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DAL
{
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci ogrenci)
        {
            SqlCommand komut1 = new SqlCommand("insert into Ogrenci (OgrAd, OgrSoyad,OgrNumara, OgrFotograf, OgrSifre) values(@p1, @p2, @p3, @p4, @p5)", Connection.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }

            komut1.Parameters.AddWithValue("@p1", ogrenci.AD);
            komut1.Parameters.AddWithValue("@p2", ogrenci.SOYAD);
            komut1.Parameters.AddWithValue("@p3", ogrenci.NUMARA);
            komut1.Parameters.AddWithValue("@p4", ogrenci.FOTOGRAF);
            komut1.Parameters.AddWithValue("@p5", ogrenci.SIFRE);
            return komut1.ExecuteNonQuery();
        }

        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut2 = new SqlCommand("Select * From Ogrenci", Connection.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci entityOgrenci = new EntityOgrenci();
                entityOgrenci.ID = Convert.ToInt32(dr["Ogrid"].ToString());
                entityOgrenci.AD = dr["OgrAd"].ToString();
                entityOgrenci.SOYAD = dr["OgrSoyad"].ToString();
                entityOgrenci.NUMARA = dr["OgrNumara"].ToString();
                entityOgrenci.FOTOGRAF = dr["OgrFotograf"].ToString();
                entityOgrenci.SIFRE = dr["OgrSifre"].ToString();
                entityOgrenci.BAKIYE = Convert.ToDouble(dr["OgrBakiye"].ToString());
                degerler.Add(entityOgrenci);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciSil(int parametre)
        {
            SqlCommand komut3 = new SqlCommand("Delete From Ogrenci where Ogrid=@p1", Connection.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", parametre);
            return komut3.ExecuteNonQuery() > 0;
        }

        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut4 = new SqlCommand("Select * From Ogrenci where Ogrid=@p1", Connection.bgl);
            komut4.Parameters.AddWithValue("@p1", id);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            SqlDataReader dr = komut4.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci entityOgrenci = new EntityOgrenci();
                entityOgrenci.AD = dr["OgrAd"].ToString();
                entityOgrenci.SOYAD = dr["OgrSoyad"].ToString();
                entityOgrenci.NUMARA = dr["OgrNumara"].ToString();
                entityOgrenci.FOTOGRAF = dr["OgrFotograf"].ToString();
                entityOgrenci.SIFRE = dr["OgrSifre"].ToString();
                entityOgrenci.BAKIYE = Convert.ToDouble(dr["OgrBakiye"].ToString());
                degerler.Add(entityOgrenci);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {
            SqlCommand komut5 = new SqlCommand("Update Ogrenci set OgrAd=@p1, OgrSoyad=@p2, OgrNumara=@p3, OgrFotograf=@p4, OgrSifre=@p5 where Ogrid=@p6", Connection.bgl);
            komut5.Parameters.AddWithValue("@p1",deger.AD);
            komut5.Parameters.AddWithValue("@p2", deger.SOYAD);
            komut5.Parameters.AddWithValue("@p3", deger.NUMARA);
            komut5.Parameters.AddWithValue("@p4", deger.FOTOGRAF);
            komut5.Parameters.AddWithValue("@p5", deger.SIFRE);
            komut5.Parameters.AddWithValue("@p6", deger.ID);

            return komut5.ExecuteNonQuery() > 0;
        }
    }
}
