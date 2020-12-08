using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_PROJE
{/// <summary>
/// grup urunleri listesini alir ve magazine nesnelerini yerlestirir
/// </summary>
    class gosterDergi :gosterUrun
    {
        public static int dergiSayac = 0;
        public static int dergiGeriSayac = dergiSayac;

        /// <summary>
        /// magazine'leri grup urunlerınde artan sekılde gosterır
        /// </summary>
        /// <param name="magazineListesi"></param>
        /// <param name="formUrunleriListesi"></param>
        /// <returns></returns>
        public int dergileriGoster(ref List<Magazine> magazineListesi,ref List<grupUrunleri> formUrunleriListesi)
        {

            tiklanmaDurumu = 2;// dergi göstermek için tıklandığında 2 olacak.

            for (int i = 0; i < magazineListesi.Count; i++)
            {
                
                    int mod = i % 5;
                    formUrunleriListesi[i].grupUrunleriGoster(magazineListesi[i]);
                
            }
            return tiklanmaDurumu;
        }
        /// <summary>
        /// magazine'leri grup urunlerınde azalan sekılde gosterır
        /// </summary>
        /// <param name="magazineListesi"></param>
        /// <param name="formUrunleriListesi"></param>
        /// <returns></returns>
        public int dergileriGeriGoster(ref List<Magazine> magazineListesi, ref List<grupUrunleri> formUrunleriListesi)
        {
            dergiSayac = dergiGeriSayac;
            tiklanmaDurumu = 2;// dergi göstermek için tıklandığında 2 olacak.


            for (int i = 0; i < 5; i++)
            {
                if (-1 < i)
                {
                    int mod = i % 5;
                    formUrunleriListesi[mod].grupUrunleriGoster(magazineListesi[i]);
                    
                }
            }
            return tiklanmaDurumu;
        }
    }
}
