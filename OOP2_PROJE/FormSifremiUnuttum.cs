using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace OOP2_PROJE
{
    public partial class FormSifremiUnuttum : Form
    {
        /// <summary>
        /// FormSifremiUnuttum constructor
        /// </summary>
        public FormSifremiUnuttum()
        {
            InitializeComponent();
        }
        /// <summary>
        /// butona tiklandiginda girilen kullanici adinin mailine sifre gonderen fonksiyon 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMailGonder_Click(object sender, EventArgs e)
        {
            int boslukSayac = 0;
            for (int i = 0; i < txtKullaniciAdiAl.Text.Length; i++)
            {
                if (txtKullaniciAdiAl.Text[i].Equals(' '))
                {
                    boslukSayac++;
                }
            }
            if (txtKullaniciAdiAl.Text.Length != boslukSayac)
            {
                string mail = "";
                string sifre = "";
                SQL_User user = new SQL_User();
                if (user.mailDonder(txtKullaniciAdiAl.Text, ref mail,ref sifre))
                {
                    mailSifreGonder(mail,sifre);
                }
                else
                {
                    MessageBox.Show("Girilen Kullanıcı Adı Bulunamadı");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Boş Bırakılamaz.");
            }
        }
        /// <summary>
        /// mail gonderen fonksiyon
        /// </summary>
        /// <param name="mail"></param>
        /// <param name="sifren"></param>
        private void mailSifreGonder(string mail,string sifren)
        {
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;//------------
            sc.Host = "smtp.gmail.com";//gonderen tipi
            sc.EnableSsl = true;//internet adreslerini https oldugunu soyler guvenlı ınternet protokolu
            sc.Credentials = new NetworkCredential("sametsalgin1070@gmail.com", "SasaTurk1453");//hesaba gırıs adres ve sıfre(-------------@gmail.com)deneme amaclı acıldı
            MailMessage mesaj = new MailMessage();
            mesaj.From = new MailAddress("sametsalgin1070@gmail.com");//kimden
            mesaj.To.Add(mail);//kime
            mesaj.Subject = "SİFRE HATIRLATMA";//konu baslık
            mesaj.IsBodyHtml = true;//html kodları calısır
            mesaj.Body = "'"+txtKullaniciAdiAl.Text +"' kullanıcı adına sahip hesabınızın şifresi: "+sifren ;//mesaj içerik

            sc.Send(mesaj);//gonderme
            MessageBox.Show("iletildi");
            this.Close();
        }
        /// <summary>
        /// FormSifremiUnuttum Load fonksiyonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSifremiUnuttum_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
