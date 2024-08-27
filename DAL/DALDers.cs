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
    public class DALDers
    {
        public static List<EntityDers> DersListesi()
        {
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand komut2 = new SqlCommand("Select * From Dersler", Connection.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityDers entityDers = new EntityDers();
                entityDers.ID = Convert.ToInt32(dr["Dersid"].ToString());
                entityDers.DERSAD = dr["DersAd"].ToString();
                entityDers.MIN = Convert.ToInt32(dr["DersMinKontenjan"].ToString());
                entityDers.MAX = Convert.ToInt32(dr["DersMaksKontenjan"].ToString());

                degerler.Add(entityDers);
            }
            dr.Close();
            return degerler;
        }

        public static int TalepEkle(EntityBasvuruFormu basvuruFormu)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into BasvuruFormu (Ogrenciid, Dersid) values(@p1,@p2)", Connection.bgl);
            sqlCommand.Parameters.AddWithValue("@p1", basvuruFormu.BASVURUOGRID);
            sqlCommand.Parameters.AddWithValue("@p2", basvuruFormu.BASVURUDERSID);
            if (sqlCommand.Connection.State != ConnectionState.Open)
            {
                sqlCommand.Connection.Open();
            }
            return sqlCommand.ExecuteNonQuery();
        }
    }
}
