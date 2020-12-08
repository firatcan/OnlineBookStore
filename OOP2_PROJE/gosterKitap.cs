using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_PROJE
{/// <summary>
/// grup urunleri listesini alir ve book nesnelerini yerlestirir
/// </summary>
    class gosterKitap :gosterUrun
    {
        /// <summary>
        /// book'lari grup urunlerınde artan sekılde gosterır
        /// </summary>
        /// <param name="bookListesi"></param>
        /// <param name="formUrunleriListesi"></param>
        /// <returns></returns>
        public int kitaplariGoster(ref List<Book> bookListesi,ref List<grupUrunleri> formUrunleriListesi)
        {
           
            tiklanmaDurumu = 1;// kitap göstermek için tıklandığında 1 olacak.
            for (int i = 0; i < bookListesi.Count; i++)
            {
                
                    formUrunleriListesi[i].grupUrunleriGoster(bookListesi[i]);
                   
            }
            return tiklanmaDurumu;
        }

        /// <summary>
        /// book'lari grup urunlerınde azalan sekılde gosterır
        /// </summary>
        /// <param name="bookListesi"></param>
        /// <param name="formUrunleriListesi"></param>
        /// <returns></returns>
        public int kitaplariGeriGoster(ref List<Book> bookListesi, ref List<grupUrunleri> formUrunleriListesi)
        {
           
            tiklanmaDurumu = 1;// kitap göstermek için tıklandığında 1 olacak.
            
            for (int i = 0; i < 5; i++)
            {
                if (-1 < i)
                {
                    
                    formUrunleriListesi[i].grupUrunleriGoster(bookListesi[i]);
                    
                }
            }
            return tiklanmaDurumu;
        }


    }
}
