using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace OOP2_PROJE
{/// <summary>
/// sql_veri sinifindan inherit eder music-cd nesnelerinin sql islemlerini yapar
/// </summary>
    class SQLmusicCd:SQL_Veri
    {
        public static int idSayac = 0;
        public static int sqlAdetBul = 0;
        public static int listekontrol = 0;
        public static int veriAdetSay = 0;
        public static int gerisayac = 0;
        public static int sonid = 0;
        MusicCD MusicCDNesnesi = new MusicCD(); 
        FormUrunler formUrunler_obj = new FormUrunler();
        static List<MusicCD> muzikCDListesi = new List<MusicCD>();
        /// <summary>
        /// music-cd kayitlarini 5li olmak sartiyla sqlden ceker
        /// </summary>
        public void muzikCDleriSQLdenCek()
        {
            VeriSayaci();
            int flag = 0;
            int id=0;
            if (muzikCDListesi.Count == 0)
            {
                id = 1;
                veriAdetSay = 0;
                listekontrol = 0;
            }
            else if(muzikCDListesi.Count==1)
            {
                id = int.Parse(muzikCDListesi[0].ID) + 1;
                listekontrol = 0;
            }
            else if (muzikCDListesi.Count == 2)
            {
                id = int.Parse(muzikCDListesi[1].ID) + 1;
                listekontrol = 0;
            }
            else if (muzikCDListesi.Count == 3)
            {
                id = int.Parse(muzikCDListesi[2].ID) + 1;
                listekontrol = 0;
            }
            else if (muzikCDListesi.Count == 4)
            {
                id = int.Parse(muzikCDListesi[3].ID) + 1;
                listekontrol = 0;
            }
            else if (muzikCDListesi.Count == 5)
            {
                id = int.Parse(muzikCDListesi[4].ID) + 1;
                listekontrol = 1;
            }
            for (int i = 0; i < 5; i++)
            {
                bagla.Open();
                komut = new SqlCommand("SELECT * FROM TableMusicCD WHERE musicCDID='" + id + "'", bagla);
                VeriOku = komut.ExecuteReader();
                flag = 0;
                while (VeriOku.Read())
                {
                    flag = 1;
                    MusicCD nesneTut = new MusicCD();
                    MusicCDNesnesi.ID = VeriOku["musicCDID"].ToString();
                    MusicCDNesnesi.Name = VeriOku["musicCDName"].ToString();
                    MusicCDNesnesi.Price = double.Parse(VeriOku["musicCDPrice"].ToString())/100;
                    MusicCDNesnesi.Singer = VeriOku["musicCDSinger"].ToString();
                    MusicCDNesnesi.ImageLocation = VeriOku["musicCDImageLocation"].ToString();

                    nesneTut.ID = MusicCDNesnesi.ID;
                    nesneTut.Name = MusicCDNesnesi.Name;
                    nesneTut.Price = MusicCDNesnesi.Price;
                    nesneTut.Singer = MusicCDNesnesi.Singer;
                    nesneTut.ImageLocation = MusicCDNesnesi.ImageLocation;
                    

                    if (listekontrol == 0)
                    {
                        muzikCDListesi.Add(nesneTut);
                        veriAdetSay++;
                    }
                    if (listekontrol == 1)
                    {
                        muzikCDListesi[i] = nesneTut;
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
        /// music-cd kayitlarini sqlden ceker fakat bır onceki 5liyi kontrol ederek ceker
        /// </summary>
        public void muzikCDleriSQLdenGeriCek()
        {
            VeriSayaci();
            int flag = 0;
            int id;
            int bessayaci = 0;
            id = int.Parse(muzikCDListesi[0].ID) - 1;


            for (int i = 5; i > 0; i--)
            {

                bagla.Open();

                komut = new SqlCommand("SELECT * FROM TableMusicCD WHERE musicCDID='" + id + "'", bagla);


                VeriOku = komut.ExecuteReader();
                flag = 0;
                while (VeriOku.Read())
                {
                    flag = 1;
                    MusicCD nesneTut = new MusicCD();
                    MusicCDNesnesi.ID = VeriOku["musicCDID"].ToString();
                    MusicCDNesnesi.Name = VeriOku["musicCDName"].ToString();
                    MusicCDNesnesi.Price = double.Parse(VeriOku["musicCDPrice"].ToString())/100;
                    MusicCDNesnesi.Singer = VeriOku["musicCDSinger"].ToString();
                    MusicCDNesnesi.ImageLocation = VeriOku["musicCDImageLocation"].ToString();

                    nesneTut.ID = MusicCDNesnesi.ID;
                    nesneTut.Name = MusicCDNesnesi.Name;
                    nesneTut.Price = MusicCDNesnesi.Price;
                    nesneTut.Singer = MusicCDNesnesi.Singer;
                    nesneTut.ImageLocation = MusicCDNesnesi.ImageLocation;
                    /*tutulmus olan nesneTut verilerini kitapListesine ekliyoruz*/

                    muzikCDListesi[i - 1] = nesneTut;
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
        /// music-cd kayitlarini sqlden 5li sekilde ceker ve formUrunler ekranına aktarir
        /// </summary>
        public void MusicCdcekGoster()
        {
            muzikCDListesi = new List<MusicCD>();
            muzikCDleriSQLdenCek();
            formUrunler_obj.Show();
            formUrunler_obj.muzikCDleriGoster(muzikCDListesi);
        }
        /// <summary>
        /// sqldeki ekli son elemanin id sini ve toplam eleman sayisini bulur 
        /// </summary>
        public void VeriSayaci()
        {
            bagla.Open();
            komut = new SqlCommand("SELECT COUNT(*) FROM TableMusicCD", bagla);
            sqlAdetBul = int.Parse(komut.ExecuteScalar().ToString());
            if (sqlAdetBul > 0)
            {
                komut = new SqlCommand("SELECT TOP(1) musicCDID FROM TableMusicCD ORDER BY 1 DESC", bagla);
                sonid = int.Parse(komut.ExecuteScalar().ToString());
            }
            bagla.Close();
        }
        /// <summary>
        /// sql veri tabanina musıc-cd kayıtlarını duzgun sekilde ekler
        /// </summary>
        /// <param name="muzikCD"></param>
        public void MusicCdSQLeEkle(MusicCD muzikCD)
        {
            bagla.Open();
            muzikCD.Name=muzikCD.Name.Replace("'", " ");
            SqlCommand komut = new SqlCommand("INSERT INTO TableMusicCD(musicCDName,musicCDPrice,musicCDSinger,musicCDType,musicCDImageLocation)" +
                " VALUES('" + muzikCD.Name + "','" + 100*muzikCD.Price + "','" + muzikCD.Singer + "','" + muzikCD.Type + "','" + muzikCD.ImageLocation + "')", bagla);
            komut.ExecuteNonQuery();
            bagla.Close();
            MessageBox.Show("eklendi");
        }
        /// <summary>
        /// sqldeki tum veriyi ceker ve adminin silme islemini yapacagi zaman calisir
        /// </summary>
        /// <param name="tablo"></param>
        public void MusicCdGoster(DataTable tablo)
        {
            bagla.Open();
            SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM TableMusicCD", bagla);
            adap.Fill(tablo);
            bagla.Close();
        }
        public void cdAra(string aranan, ref DataTable tablo)
        {

            bagla.Open();
            SqlDataAdapter adap = new SqlDataAdapter("SELECT magazineName FROM TableMagazine WHERE magazineName like '%" + aranan + "%'", bagla);
            adap.Fill(tablo);
            bagla.Close();

        }
        /// <summary>
        /// siniftali 5li listeyi geri dondurur
        /// </summary>
        /// <returns></returns>
        public List<MusicCD> dondur()
        {
            return muzikCDListesi;
        }
    }
}
