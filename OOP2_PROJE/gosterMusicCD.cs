using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_PROJE
{
    /// <summary>
    /// grup urunleri listesini alir ve musicCD nesnelerini yerlestirir
    /// </summary>
    class gosterMusicCD:gosterUrun
    {
        public static int muzikCdSayac = 0;
        public static int muzikCdGeriSayac = muzikCdSayac;
        /// <summary>
        /// musicCDleri grup urunlerınde artan sekılde gosterır
        /// </summary>
        /// <param name="musicCDListesi"></param>
        /// <param name="formUrunleriListesi"></param>
        /// <returns></returns>
        public int muzikCDleriGoster(ref List<MusicCD> musicCDListesi, ref List<grupUrunleri> formUrunleriListesi)
        {
            tiklanmaDurumu = 3;// music cd göstermek için tıklandığında 3 olacak.
           

            for (int i = 0; i < musicCDListesi.Count; i++)
            {
                    formUrunleriListesi[i].grupUrunleriGoster(musicCDListesi[i]);
            }
            return tiklanmaDurumu;
        }
        /// <summary>
        /// musicCDleri grup urunlerınde azalan sekılde gosterır
        /// </summary>
        /// <param name="musicCDListesi"></param>
        /// <param name="formUrunleriListesi"></param>
        /// <returns></returns>
        public int muzikCDleriGeriGoster(ref List<MusicCD> musicCDListesi, ref List<grupUrunleri> formUrunleriListesi)
        {
            tiklanmaDurumu = 3;// music cd göstermek için tıklandığında 3 olacak.
            
            for (int i = 0; i < 5; i++)
            {
                if (-1 < i)
                {
                    formUrunleriListesi[i].grupUrunleriGoster(musicCDListesi[i]);
                }
            }
            return tiklanmaDurumu;
        }

    }
}
