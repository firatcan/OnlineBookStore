using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_PROJE
{
    class mailAt:Imail
    {
        private string e_mail;

        public string E_mail { get => e_mail; set => e_mail = value; }

        public void update(absSiparis urun1)
        {
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;//------------
            sc.Host = "smtp.gmail.com";//gonderen tipi
            sc.EnableSsl = true;//internet adreslerini https oldugunu soyler guvenlı ınternet protokolu
            sc.Credentials = new NetworkCredential("sametsalgin1070@gmail.com", "SasaTurk1453");//hesaba gırıs adres ve sıfre(-------------@gmail.com)deneme amaclı acıldı
            MailMessage mesaj = new MailMessage();
            mesaj.From = new MailAddress("sametsalgin1070@gmail.com");//kimden
            mesaj.BodyEncoding = System.Text.Encoding.UTF8;
            mesaj.To.Add(urun1.MusteriMail);//kime
            mesaj.Subject = "SİPARİS VERİLDİ";//konu baslık
            mesaj.IsBodyHtml = true;//html kodları calısır
            mesaj.Body = "";
            for (int i = 0; i < urun1.Urunler.Count; i++)
            {
                mesaj.Body += urun1.Urunler[i].Adet + " TANE " + urun1.Urunler[i].Name + " ADLI URUN " + urun1.Urunler[i].Price + "TL TUTARINDA " + System.Environment.NewLine + "URUN ALDI" + System.Environment.NewLine +"MUSTERİ ADİ : "+urun1.MusteriAd;
            }
            


            sc.Send(mesaj);//gonderme
        }
    }
}
