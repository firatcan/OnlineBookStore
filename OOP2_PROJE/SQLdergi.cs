using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Windows.Forms;

namespace OOP2_PROJE
{
    /// <summary>
    /// sql_veri sinifindan inherit eder ve sql ile ilgili magazine islemlerini burada yapar
    /// </summary>
    class SQLdergi:SQL_Veri
    {
        public static int idSayac = 0;
        public static int bessayaci = 0;
        public static int sqlAdetBul = 0;
        public static int listekontrol = 0;
        public static int veriAdetSay = 0;
        public static int gerisayac = 0;
        public static int sonid = 0;
        Magazine magazineNesnesi = new Magazine();
        FormUrunler formUrunler_obj = new FormUrunler();
        static List<Magazine> dergiListesi = new List<Magazine>();
        /// <summary>
        /// dergileri sql veri tabanindan ceker ve 5li sekilde ekrana verir
        /// </summary>
        public void dergileriSQLdenCek()
        {
            VeriSayaci();
            int flag = 0;
            int id=1;
            if (dergiListesi.Count == 0)
            {
                id = 1;
                veriAdetSay = 0;
                listekontrol = 0;
            }
            else if(dergiListesi.Count==1)
            {
                id = int.Parse(dergiListesi[0].ID) + 1;
                listekontrol = 0;
            }
            else if (dergiListesi.Count == 2)
            {
                id = int.Parse(dergiListesi[1].ID) + 1;
                listekontrol = 0;
            }
            else if (dergiListesi.Count == 3)
            {
                id = int.Parse(dergiListesi[2].ID) + 1;
                listekontrol = 0;
            }
            else if (dergiListesi.Count == 4)
            {
                id = int.Parse(dergiListesi[3].ID) + 1;
                listekontrol = 0;
            }
            else if (dergiListesi.Count == 5)
            {
                id = int.Parse(dergiListesi[4].ID) + 1;
                listekontrol = 1;
            }
            for (int i = 0; i < 5; i++)
            {

                bagla.Open();
                komut = new SqlCommand("SELECT * FROM TableMagazine WHERE magazineID='" + id + "'", bagla);
                
                VeriOku = komut.ExecuteReader();
                flag = 0;
                while (VeriOku.Read())
                {
                    flag = 1;
                    Magazine nesneTut = new Magazine();
                    magazineNesnesi.ID = VeriOku["magazineID"].ToString();
                    magazineNesnesi.Name = VeriOku["magazineName"].ToString();
                    magazineNesnesi.Price = double.Parse(VeriOku["magazinePrice"].ToString())/100;
                    magazineNesnesi.Issue = VeriOku["magazineIssue"].ToString();
                    magazineNesnesi.ImageLocation = VeriOku["magazineImageLocation"].ToString();
                    /* verileri nesneTut ile teker teker Book Class turunde tutuyoruz*/
                    nesneTut.ID = magazineNesnesi.ID;
                    nesneTut.Name = magazineNesnesi.Name;
                    nesneTut.Price = magazineNesnesi.Price;
                    nesneTut.Issue = magazineNesnesi.Issue;
                    nesneTut.ImageLocation = magazineNesnesi.ImageLocation;
                    /*tutulmus olan nesneTut verilerini kitapListesine ekliyoruz*/

                    if (listekontrol == 0)
                    {
                        dergiListesi.Add(nesneTut);
                        veriAdetSay++;
                    }
                    if (listekontrol == 1)
                    {
                        dergiListesi[i] = nesneTut;
                        veriAdetSay++;
                    }
                    id++;
                }
                if (flag == 0)
                {
                    i--;
                    id++;
                }
                bagla.Close();
                if (sqlAdetBul == veriAdetSay)
                {
                    gerisayac += veriAdetSay;
                    break;
                }
            }
            gerisayac += veriAdetSay;
        }
        /// <summary>
        /// dergileri sqlden bir onceki 5 liye gore kontrol ederek ceker
        /// </summary>
        public void dergileriSQLdenGeriCek()
        {
            VeriSayaci();
            int flag = 0;
            int id;
            int bessayaci = 0;
            id = int.Parse(dergiListesi[0].ID) - 1;
            for (int i = 5; i > 0; i--)
            {

                bagla.Open();
                komut = new SqlCommand("SELECT * FROM TableMagazine WHERE magazineID='" + id + "'", bagla);
                VeriOku = komut.ExecuteReader();
                flag = 0;
                while (VeriOku.Read())
                {
                    flag = 1;
                    Magazine nesneTut = new Magazine();
                    magazineNesnesi.ID = VeriOku["magazineID"].ToString();
                    magazineNesnesi.Name = VeriOku["magazineName"].ToString();
                    magazineNesnesi.Price = double.Parse(VeriOku["magazinePrice"].ToString())/100;
                    magazineNesnesi.Issue = VeriOku["magazineIssue"].ToString();
                    magazineNesnesi.ImageLocation = VeriOku["magazineImageLocation"].ToString();
                    /* verileri nesneTut ile teker teker Book Class turunde tutuyoruz*/
                    nesneTut.ID = magazineNesnesi.ID;
                    nesneTut.Name = magazineNesnesi.Name;
                    nesneTut.Price = magazineNesnesi.Price;
                    nesneTut.Issue = magazineNesnesi.Issue;
                    nesneTut.ImageLocation = magazineNesnesi.ImageLocation;
                    /*tutulmus olan nesneTut verilerini kitapListesine ekliyoruz*/

                    dergiListesi[i - 1] = nesneTut;
                    bessayaci++;
                    id--;
                }
                if (flag == 0)
                {
                    i++;
                    id--;
                }
                if (id < 0)
                    break;
                bagla.Close();
                if (bessayaci == 5)
                {
                    veriAdetSay -= 5;
                    if (veriAdetSay % 5 != 0)
                    {
                        for (int k = 0; k < 5; k++)
                        {
                            veriAdetSay++;
                            if (veriAdetSay % 5 == 0)
                                break;
                        }
                    }
                    break;
                }
                
            }

        }
        /// <summary>
        /// dergileri sql tabanin ceker ve formurunler ekranina aktarir
        /// </summary>
        public void dergiCekGoster()
        {
            dergiListesi = new List<Magazine>();
            dergileriSQLdenCek();
            formUrunler_obj.Show();
           
            formUrunler_obj.dergileriGoster(dergiListesi);
        }
        /// <summary>
        /// magazine nesnesini sql veri tabanina ekler
        /// </summary>
        /// <param name="dergi"></param>
        public void dergileriSQLeEkle(Magazine dergi)
        {
            bagla.Open();
            dergi.Name=dergi.Name.Replace("'", " ").Replace(":", " ");
            SqlCommand komut = new SqlCommand("INSERT INTO TableMagazine(magazineName,magazinePrice,magazineIssue,magazineType,magazineImageLocation)" +
                " VALUES('" + dergi.Name + "','" + 100*dergi.Price + "','" + dergi.Issue + "','" + dergi.Type + "','" + dergi.ImageLocation + "')", bagla);
           
            komut.ExecuteNonQuery();
            bagla.Close();
            MessageBox.Show("eklendi");
        }
        /// <summary>
        /// sqldeki veri sayisini ve son verinin idsini bulur
        /// </summary>
        public void VeriSayaci()
        {
            bagla.Open();
            komut = new SqlCommand("SELECT COUNT(*) FROM TableMagazine", bagla);
            sqlAdetBul = int.Parse(komut.ExecuteScalar().ToString());
            if (sqlAdetBul > 0)
            {
                komut = new SqlCommand("SELECT TOP(1) magazineID FROM TableMagazine ORDER BY 1 DESC", bagla);
                sonid = int.Parse(komut.ExecuteScalar().ToString());
            }
            bagla.Close();
        }
        /// <summary>
        /// admin veri silmek istedigi zaman ekrana verileri doldurur
        /// </summary>
        /// <param name="tablo"></param>
        public void dergiGoster(DataTable tablo)
        {
            bagla.Open();
            SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM TableMagazine", bagla);
            adap.Fill(tablo);
            bagla.Close();
        }
        public void dergiAra(string aranan, ref DataTable tablo)
        {

            bagla.Open();
            SqlDataAdapter adap = new SqlDataAdapter("SELECT magazineName FROM TableMagazine WHERE magazineName like '%" + aranan + "%'", bagla);
            adap.Fill(tablo);
           
            bagla.Close();

        }
        /// <summary>
        /// 5li dergi nesnelerini dondurur
        /// </summary>
        /// <returns></returns>
        public List<Magazine> dondur()
        {
            return dergiListesi;
        }
    }
}
