using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_PROJE
{
    class absSiparis
    {
        private string musteriMail;
        List<Product> urunler = new List<Product>();
        public string Musteri { get => MusteriMail; set => MusteriMail = value; }
        List<Imail> mail = new List<Imail>();
        private string musteriAd;


        internal List<Imail> Mail { get => mail; set => mail = value; }
        public List<Product> Urunler { get => urunler; set => urunler = value; }
        public string MusteriMail { get => musteriMail; set => musteriMail = value; }
        public string MusteriAd { get => musteriAd; set => musteriAd = value; }

        public absSiparis(string musteriMail,string musteriad)
        {
            this.MusteriMail = musteriMail;
            this.MusteriAd = musteriad;
            
        }
        public void onayekle(List<Product> urunler)
        {
            this.Urunler = urunler;
            notify();

        }
        public void notify()
        {
            Mail[0].update(this);
        }

    }
}
