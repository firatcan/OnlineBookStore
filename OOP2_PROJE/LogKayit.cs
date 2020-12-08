using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.IO;

namespace OOP2_PROJE
{
    /// <summary>
    /// butun tuslarin log kaydini tutan sinif
    /// </summary>
    class LogKayit
    {
        public SqlConnection bagla = new SqlConnection("Data Source=.;Initial Catalog=BookStore;Integrated Security=true");
        public SqlCommand komut;
        public LogKayit()
        {

        }
        /// <summary>
        /// verileri kaydeder
        /// </summary>
        /// <param name="form_obj"></param>
        /// <param name="butonAdi"></param>
        /// <param name="tiklanmaZamani"></param>
        /// <param name="kullaniciAdi"></param>
        public void kayit(Form form_obj, string butonAdi, string tiklanmaZamani, string kullaniciAdi)
        {
            dosyaYazMusteriLog(form_obj, butonAdi, tiklanmaZamani, kullaniciAdi);
            bagla.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TableLogKayit(FormAdi,ButonAdi,Tarih,MusteriKullaniciAdi)" +
                " VALUES('" + form_obj.Name + "','" + butonAdi + "','" + tiklanmaZamani + "','" + kullaniciAdi + "')", bagla);
            
            komut.ExecuteNonQuery();
            bagla.Close();
        }
        /// <summary>
        /// admin log bilgilerini sqle kaydeder
        /// </summary>
        /// <param name="form_obj"></param>
        /// <param name="butonAdi"></param>
        /// <param name="tiklanmaZamani"></param>
        /// <param name="kullaniciAdi"></param>
        public void adminLogKayit(Form form_obj, string butonAdi, string tiklanmaZamani, string kullaniciAdi)
        {
            dosyaYazAdminLog(form_obj, butonAdi, tiklanmaZamani, kullaniciAdi);
            bagla.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TableAdminLogKayit(FormAdi,ButonAdi,Tarih,AdminKullaniciAdi)" +
                " VALUES('" + form_obj.Name + "','" + butonAdi + "','" + tiklanmaZamani + "','" + kullaniciAdi + "')", bagla);

            komut.ExecuteNonQuery();
            bagla.Close();
        }
        /// <summary>
        /// admin log kayitlarini csv olarak yazar
        /// </summary>
        /// <param name="form_obj"></param>
        /// <param name="butonAdi"></param>
        /// <param name="tiklanmaZamani"></param>
        /// <param name="kullaniciAdi"></param>
        public void dosyaYazAdminLog(Form form_obj, string butonAdi, string tiklanmaZamani, string kullaniciAdi)
        {
            string dosyaAdi = "adminLog.csv";
            string path = "";
            StringBuilder csvYapici = new StringBuilder();
            SaveFileDialog dosyaOlustur = new SaveFileDialog();

            FileInfo dosyabilgisi = new FileInfo(dosyaAdi);
            path = @dosyabilgisi.FullName;
            string yazilacak = form_obj.Name + " , " + butonAdi + " , " + tiklanmaZamani + " , " + kullaniciAdi;

            csvYapici.AppendLine(yazilacak);
            File.AppendAllText(path, csvYapici.ToString());

        }/// <summary>
        /// musteri log kayitlarini csv formatinda verir
        /// </summary>
        /// <param name="form_obj"></param>
        /// <param name="butonAdi"></param>
        /// <param name="tiklanmaZamani"></param>
        /// <param name="kullaniciAdi"></param>
        public void dosyaYazMusteriLog(Form form_obj, string butonAdi, string tiklanmaZamani, string kullaniciAdi)
        {
            string dosyaAdi = "customerLog.csv";
            string path = "";
            StringBuilder csvYapici = new StringBuilder();
            SaveFileDialog dosyaOlustur = new SaveFileDialog();

            FileInfo dosyabilgisi = new FileInfo(dosyaAdi);
            path = @dosyabilgisi.FullName;

            string yazilacak = form_obj.Name + " , " + butonAdi + " , " + tiklanmaZamani + " , " + kullaniciAdi;

            csvYapici.AppendLine(yazilacak);
            File.AppendAllText(path, csvYapici.ToString());
        }
    }
}
