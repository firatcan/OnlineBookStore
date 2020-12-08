using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_PROJE
{
    /// <summary>
    /// ekrandaki form urunlerinini tutar ve bunlar uzerinde islemleri yapar
    /// </summary>
    class grupUrunleri
    {
        private Label ad = new Label();
        private Label konu = new Label();
        private Label fiyat = new Label();
        private PictureBox imageLocation = new PictureBox();

        private Label yazar = new Label();
        private Label sayfa = new Label();
        private Label yayin = new Label();
        private Label isbn = new Label();

        Book kitap;
        Magazine dergi;
        MusicCD cd;
        /// <summary>
        /// formurunlerdeki form urunlerini kaydeder
        /// </summary>
        /// <param name="ad"></param>
        /// <param name="konu"></param>
        /// <param name="fiyat"></param>
        /// <param name="imageLocation"></param>
        public void grupUrunleriOLustur(ref Label ad, ref Label konu, ref Label fiyat, ref PictureBox imageLocation)
        {
            this.ad = ad;
            this.konu = konu;
            this.fiyat = fiyat;
            this.imageLocation = imageLocation;

        }
        /// <summary>
        /// formAnaEkrandaki formurunlerini kaydeder
        /// </summary>
        /// <param name="ad"></param>
        /// <param name="fiyat"></param>
        /// <param name="imageLocation"></param>
        public void grupUrunleriOLustur(ref Label ad, ref Label fiyat, ref PictureBox imageLocation)
        {
            this.ad = ad;
            this.fiyat = fiyat;
            this.imageLocation = imageLocation;

        }
        /// <summary>
        /// formUrun deki form urunlerini kaydeder
        /// </summary>
        /// <param name="ad"></param>
        /// <param name="konu"></param>
        /// <param name="fiyat"></param>
        /// <param name="yazar"></param>
        /// <param name="sayfa"></param>
        /// <param name="yayin"></param>
        /// <param name="isbn"></param>
        /// <param name="imageLocation"></param>
        public void grupUrunleriOLustur(ref Label ad, ref Label konu, ref Label fiyat, ref Label yazar, ref Label sayfa, ref Label yayin, ref Label isbn, ref PictureBox imageLocation)
        {
            this.ad = ad;
            this.konu = konu;
            this.fiyat = fiyat;
            this.yazar = yazar;
            this.sayfa = sayfa;
            this.yayin = yayin;
            this.isbn = isbn;
            this.imageLocation = imageLocation;

        }
        /// <summary>
        /// book nesnesinin bilgileri form urunlere
        /// </summary>
        /// <param name="gelenNesne"></param>
        public void grupUrunleriGoster(Book gelenNesne)
        {
            kitap = null;
            dergi = null;
            cd = null;
            if(gelenNesne!=null)
            {
                kitap = gelenNesne;
                this.ad.Text = gelenNesne.Name;
                this.yazar.Text = gelenNesne.Author;
                this.yayin.Text = gelenNesne.Publisher;
                this.konu.Text = gelenNesne.TypeOfBook.ToString();
                this.sayfa.Text = gelenNesne.Page.ToString();
                this.fiyat.Text = gelenNesne.Price.ToString()+" TL";
                this.isbn.Text = gelenNesne.IsbnNumber;
                this.imageLocation.ImageLocation = gelenNesne.Cover_page_picture;
            }
        }
        /// <summary>
        /// magazine nesnesinin bilgileri form urunlere
        /// </summary>
        /// <param name="gelenNesne"></param>
        public void grupUrunleriGoster(Magazine gelenNesne)
        {
            kitap = null;
            dergi = null;
            cd = null;
            if (gelenNesne != null)
            {


                dergi = gelenNesne;
                this.ad.Text = gelenNesne.Name;
                this.konu.Text = gelenNesne.Issue.ToString();
                this.fiyat.Text = gelenNesne.Price.ToString() + " TL";
                this.yayin.Text = gelenNesne.Issue;
                this.imageLocation.ImageLocation = gelenNesne.ImageLocation;
            }
        }
        /// <summary>
        /// musicCD nesnesinin bilgileri form urunlere
        /// </summary>
        /// <param name="gelenNesne"></param>
        public void grupUrunleriGoster(MusicCD gelenNesne)
        {
            kitap = null;
            dergi = null;
            cd = null;
            if (gelenNesne != null)
            {

                cd = gelenNesne;
                this.ad.Text = gelenNesne.Name;
                this.konu.Text = gelenNesne.Type.ToString();
                this.yazar.Text = gelenNesne.Singer.ToString();
                this.fiyat.Text = gelenNesne.Price.ToString() + " TL";
                this.imageLocation.ImageLocation = gelenNesne.ImageLocation;
            }
        }
        /// <summary>
        /// form urunun icerisindeki nesneyi geri dondurur
        /// </summary>
        /// <returns></returns>
        public Product urunDondur()
        {
            if(kitap!=null)
            {
                return kitap;
            }
            else if(dergi!=null)
            {
                return dergi;
            }
            else
            {
                return cd;
            }

        }
    }
}
