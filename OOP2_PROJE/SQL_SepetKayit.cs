using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OOP2_PROJE
{/// <summary>
/// sql deki sepet islemlerini yapar ve sql_veri sinifindan inherit eder
/// </summary>
    class SQL_SepetKayit : SQL_Veri
    {
        /// <summary>
        /// sepetteki urunleri sqle kaydeder
        /// </summary>
        /// <param name="gelenUrun"></param>
        /// <param name="cust"></param>
        public void SepetKaydet(List<Product> gelenUrun, Customer cust)
        {
            SqlCommand komut;

            bagla.Open();
            komut = new SqlCommand("UPDATE TableSepet SET sonGiris=0 WHERE customerID= '" + cust.id + "'and sonGiris=1", bagla);
            komut.ExecuteNonQuery();

            bagla.Close();
            for (int i = 0; i < gelenUrun.Count; i++)
            {
                bagla.Open();
                komut = new SqlCommand("INSERT INTO TableSepet(customerID,alindi,urunAdi,adet,fiyat,sonGiris,imageLocation)" +
                " VALUES('" + cust.id + "','" + 0 + "','" + gelenUrun[i].Name + "','" + gelenUrun[i].Adet + "','" + gelenUrun[i].Price + "','" + 1 + "','" + gelenUrun[i].ImageLocation + "')", bagla);
                komut.ExecuteNonQuery();

                bagla.Close();
            }


        }
        /// <summary>
        /// sqldeki urunleri sepete kaydeder
        /// </summary>
        /// <returns></returns>
        public List<Product> SepettenCek()
        {
            Customer cust = FormAnaEkran.CustomerNesnesi;
            List<Product> cekilen = new List<Product>();
            bagla.Open();
            SqlCommand komut;
            komut = new SqlCommand("SELECT * FROM TableSepet WHERE customerID='" + cust.id + "' and sonGiris=1", bagla);
            VeriOku = komut.ExecuteReader();
            Book biNesne = new Book();
            while (VeriOku.Read())
            {
                Book ikiNesne = new Book();
                biNesne.Name = VeriOku["urunAdi"].ToString();
                biNesne.Adet = int.Parse(VeriOku["adet"].ToString());
                biNesne.Price = double.Parse(VeriOku["fiyat"].ToString());
                biNesne.ImageLocation = VeriOku["imageLocation"].ToString();
                ////
                ///
                ikiNesne.Name = biNesne.Name;
                ikiNesne.Adet = biNesne.Adet;
                ikiNesne.Price = biNesne.Price;
                ikiNesne.ImageLocation = biNesne.ImageLocation;
                cekilen.Add(ikiNesne);
            }
            bagla.Close();
            return cekilen;
        }
    }
}
