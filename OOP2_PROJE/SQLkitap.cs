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
    /// sql_veri sinifindan inherit eder sqldeki book nesnesi ile ilgili islemler burada yapilir.
    /// </summary>
    class SQLkitap:SQL_Veri
    {
        public static int gerisayac = 0;
        public static int denemesayac = 0;
        public static int sqlAdetBul = 0;
        public static int veriAdetSay = 0;
        public static int sonid = 0;
        Book bookNesnesi = new Book();
        FormUrunler formUrunler_obj = new FormUrunler();
        static List<Book> kitapListesi = new List<Book>();
        /// <summary>
        /// sql deki kitap nesnelerini 5 li sekilde ceker
        /// </summary>
        public void kitaplariSQLdenCek()
        {
            VeriSayaci();
            int flag = 0;
            int id=0;
            if (kitapListesi.Count == 0)
            {
                id = 1;
                veriAdetSay = 0;
                denemesayac = 0;
            }
            else if(kitapListesi.Count==1)
            {
                id=int.Parse( kitapListesi[0].ID)+1;
                denemesayac = 0;
            }
            else if (kitapListesi.Count == 2)
            {
                id = int.Parse(kitapListesi[1].ID) + 1;
                denemesayac = 0;
            }
            else if (kitapListesi.Count == 3)
            {
                id = int.Parse(kitapListesi[2].ID) + 1;
                denemesayac = 0;
            }
            else if (kitapListesi.Count == 4)
            {
                id = int.Parse(kitapListesi[3].ID) + 1;
                denemesayac = 0;
            }
            else if (kitapListesi.Count == 5)
            {
                id = int.Parse(kitapListesi[4].ID) + 1;
                denemesayac = 1;
            }
            for (int i = 0; i < 5; i++)
            {
                
                bagla.Open();

                komut = new SqlCommand("SELECT * FROM TableBook WHERE bookID='" + id + "'", bagla);
                VeriOku = komut.ExecuteReader();
                flag = 0;
                while (VeriOku.Read())
                {
                    flag = 1;
                    Book nesneTut = new Book();
                    Book bookNesnesi1 = new Book();

                    bookNesnesi1.ID = VeriOku["bookID"].ToString();
                    bookNesnesi1.Name = VeriOku["bookName"].ToString();
                    bookNesnesi1.Price = double.Parse(VeriOku["bookPrice"].ToString())/100;
                    bookNesnesi1.Author = VeriOku["bookAuthor"].ToString();
                    bookNesnesi1.Publisher = VeriOku["bookPublisher"].ToString();
                    bookNesnesi1.Page = int.Parse(VeriOku["bookPage"].ToString());
                    bookNesnesi1.IsbnNumber = VeriOku["bookISBN"].ToString();
                    bookNesnesi1.Cover_page_picture = VeriOku["bookImageLocation"].ToString();
                    bookNesnesi1.TypeOfBook = VeriOku["bookType"].ToString();                   
                    /* verileri nesneTut ile teker teker Book Class turunde tutuyoruz*/
                    nesneTut.ID = bookNesnesi.ID;
                    nesneTut.Name = bookNesnesi.Name;
                    nesneTut.Price = bookNesnesi.Price;
                    nesneTut.Author = bookNesnesi.Author;
                    nesneTut.Publisher = bookNesnesi.Publisher;
                    nesneTut.Page = bookNesnesi.Page;
                    nesneTut.IsbnNumber = bookNesnesi.IsbnNumber;
                    nesneTut.Cover_page_picture = bookNesnesi.Cover_page_picture;
                    nesneTut.TypeOfBook = bookNesnesi.TypeOfBook;
                    /*tutulmus olan nesneTut verilerini kitapListesine ekliyoruz*/

                    if (denemesayac==0)
                    {
                        kitapListesi.Add(bookNesnesi1);
                        veriAdetSay++;
                    }
                    if (denemesayac == 1)
                    {
                        kitapListesi[i] = bookNesnesi1;
                        veriAdetSay++;
                    }
                    id++;
                }
                if(flag==0)
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
            denemesayac = 0;
        }
       /// <summary>
       /// sqldeki kitaplari bir onceki 5liye kontrol ederek ceker
       /// </summary>
        public void kitaplariSQLdenGeriCek()
        {
            VeriSayaci();
            int flag = 0;
            int id;
            int bessayaci = 0;
            id = int.Parse(kitapListesi[0].ID) - 1;


            for (int i = 5; i > 0; i--)
            {

                bagla.Open();

                komut = new SqlCommand("SELECT * FROM TableBook WHERE bookID='" + id + "'", bagla);


                VeriOku = komut.ExecuteReader();
                flag = 0;
                while (VeriOku.Read())
                {
                    flag = 1;
                    Book nesneTut = new Book();
                    bookNesnesi.ID = VeriOku["bookID"].ToString();
                    bookNesnesi.Name = VeriOku["bookName"].ToString();
                    bookNesnesi.Price = double.Parse(VeriOku["bookPrice"].ToString())/100;
                    bookNesnesi.Author = VeriOku["bookAuthor"].ToString();
                    bookNesnesi.Publisher = VeriOku["bookPublisher"].ToString();
                    bookNesnesi.Page = int.Parse(VeriOku["bookPage"].ToString());
                    bookNesnesi.IsbnNumber = VeriOku["bookISBN"].ToString();
                    bookNesnesi.Cover_page_picture = VeriOku["bookImageLocation"].ToString();
                    bookNesnesi.TypeOfBook = VeriOku["bookType"].ToString();
                    /* verileri nesneTut ile teker teker Book Class turunde tutuyoruz*/
                    nesneTut.ID = bookNesnesi.ID;
                    nesneTut.Name = bookNesnesi.Name;
                    nesneTut.Price = bookNesnesi.Price;
                    nesneTut.Author = bookNesnesi.Author;
                    nesneTut.Publisher = bookNesnesi.Publisher;
                    nesneTut.Page = bookNesnesi.Page;
                    nesneTut.IsbnNumber = bookNesnesi.IsbnNumber;
                    nesneTut.Cover_page_picture = bookNesnesi.Cover_page_picture;
                    nesneTut.TypeOfBook = bookNesnesi.TypeOfBook;
                    /*tutulmus olan nesneTut verilerini kitapListesine ekliyoruz*/

                    kitapListesi[i-1] = nesneTut;
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
                    if(veriAdetSay%5!=0)
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
        /// sql tabanindaki son id yi ve toplam veri sayisini verir
        /// </summary>
        public void VeriSayaci()
        {
            bagla.Open();
            komut = new SqlCommand("SELECT COUNT(*) FROM TableBook", bagla);
            sqlAdetBul = int.Parse(komut.ExecuteScalar().ToString());
            if (sqlAdetBul > 0)
            {
                komut = new SqlCommand("SELECT TOP(1) bookID FROM TableBook ORDER BY 1 DESC", bagla);
                sonid = int.Parse(komut.ExecuteScalar().ToString());
            }
            bagla.Close();

        }
        /// <summary>
        /// kitaplari sql tabanindan ceker ve form urunler ekranina 5li sekilde aktarir
        /// </summary>
        public void kitapCekGoster()
        {
            kitapListesi = new List<Book>();
            kitaplariSQLdenCek();
            formUrunler_obj.Show();
            formUrunler_obj.kitaplariGoster(kitapListesi);
        }
        /// <summary>
        /// kitap nesnesini sql tabanina kaydeder
        /// </summary>
        /// <param name="kitap"></param>
        public void kitaplariSQLeEkle(Book kitap)
        {
            bagla.Open();
           kitap.Name= kitap.Name.Replace("'", " ");
            SqlCommand komut = new SqlCommand("INSERT INTO TableBook(bookName,bookPrice,bookISBN,bookAuthor,bookPublisher,bookPage,bookImageLocation,bookType)" +
                " VALUES('" + kitap.Name + "','" + 100*kitap.Price + "','" + kitap.IsbnNumber + "','" + kitap.Author + "','" + kitap.Publisher + "','" + kitap.Page + 
                "','" + kitap.Cover_page_picture + "','" + kitap.TypeOfBook + "')", bagla);


            komut.ExecuteNonQuery();
            bagla.Close();
            MessageBox.Show("eklendi");
        }
        /// <summary>
        /// kullanici veri silmek istediginde tum veriyi ceker ve gosterir
        /// </summary>
        /// <param name="tablo"></param>
        public void kitapGoster(DataTable tablo)
        {
            bagla.Open();
            SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM TableBook", bagla);
            adap.Fill(tablo);
            bagla.Close();
        }
        /// <summary>
        /// uygun kitaplari arar
        /// </summary>
        /// <param name="aranan"></param>
        /// <param name="tablo"></param>
        public void kitapAra(string aranan, ref DataTable tablo)
        {

            bagla.Open();
            SqlDataAdapter adap = new SqlDataAdapter("SELECT bookName FROM TableBook WHERE bookName like '%" + aranan + "%'", bagla);
            adap.Fill(tablo);
            bagla.Close();

        }

        public void kitabigoster(string aranan)
        {
            bagla.Open();

            komut = new SqlCommand("SELECT * FROM TableBook WHERE bookName like '%" + aranan + "%'", bagla);


            VeriOku = komut.ExecuteReader();
            VeriOku.Read();
            Book nesneTut = new Book();
            bookNesnesi.ID = VeriOku["bookID"].ToString();
            bookNesnesi.Name = VeriOku["bookName"].ToString();
            bookNesnesi.Price = double.Parse(VeriOku["bookPrice"].ToString()) / 100;
            bookNesnesi.Author = VeriOku["bookAuthor"].ToString();
            bookNesnesi.Publisher = VeriOku["bookPublisher"].ToString();
            bookNesnesi.Page = int.Parse(VeriOku["bookPage"].ToString());
            bookNesnesi.IsbnNumber = VeriOku["bookISBN"].ToString();
            bookNesnesi.Cover_page_picture = VeriOku["bookImageLocation"].ToString();
            bookNesnesi.TypeOfBook = VeriOku["bookType"].ToString();
            /* verileri nesneTut ile teker teker Book Class turunde tutuyoruz*/
            nesneTut.ID = bookNesnesi.ID;
            nesneTut.Name = bookNesnesi.Name;
            nesneTut.Price = bookNesnesi.Price;
            nesneTut.Author = bookNesnesi.Author;
            nesneTut.Publisher = bookNesnesi.Publisher;
            nesneTut.Page = bookNesnesi.Page;
            nesneTut.IsbnNumber = bookNesnesi.IsbnNumber;
            nesneTut.Cover_page_picture = bookNesnesi.Cover_page_picture;
            nesneTut.TypeOfBook = bookNesnesi.TypeOfBook;
            FormUrun arananurun = new FormUrun(nesneTut, 1);
            arananurun.Show();




        }

            /// <summary>
            /// 5li kitap nesnesini dondurur.
            /// </summary>
            /// <returns></returns>
            public List<Book> dondur()
        {
            return kitapListesi;
        }
    }
}
