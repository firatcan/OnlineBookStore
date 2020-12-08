using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
namespace OOP2_PROJE
{
    /// <summary>
    /// sepet islemleri bu sinifta yapilir
    /// </summary>
    public class ShoppingCard
    {
        private static ShoppingCard singletonNesnesi = null;
        Customer musteri = Customer.customer;

        static int sayac = 0;
        int kontrol = 0;
        Book kitapSepet;
        Magazine dergiSepet;
        MusicCD cdSepet;
        static List<Product> listeSepet = new List<Product>();
        List<double> tutar = new List<double>();
        public static List<Product> ListeSepet { get => listeSepet; set => listeSepet = value; }

        DataGridView dgwSepet;
        PictureBox pbxUrun;
        Label lblAltToplamim;
        Label lblKargom;
        Label lblToplamim;

        public ArrayList itemsToPurchase;//the list of itemsToPurchase currently in the shopping cart (you can use arraylist)
        public double paymentAmount;
        /// <summary>
        /// sinifin singleton olmasini saglar
        /// </summary>
        public static ShoppingCard shoppingCard
        {
            get
            {
                if (singletonNesnesi == null)
                {
                    singletonNesnesi = new ShoppingCard();
                }
                return singletonNesnesi;
            }
        }
        
        /// <summary>
        /// constructer
        /// </summary>
        private ShoppingCard()
        {

        }
        
        public enum paymentType
        {
            cash,
            creditCard
        }
        /// <summary>
        /// sepetteki form urunlerini sinifa tanimlar
        /// </summary>
        /// <param name="dgwSepet"></param>
        /// <param name="pbxUrun"></param>
        /// <param name="lblAltToplamim"></param>
        /// <param name="lblKargom"></param>
        /// <param name="lblToplamim"></param>
        public void sepetFormEslestir(ref DataGridView dgwSepet,ref PictureBox pbxUrun,ref Label lblAltToplamim,ref Label lblKargom,ref Label lblToplamim)
        {
            this.dgwSepet = dgwSepet;
            this.pbxUrun = pbxUrun;
            this.lblAltToplamim = lblAltToplamim;
            this.lblKargom = lblKargom;
            this.lblToplamim = lblToplamim;
        }
        /// <summary>
        /// urunleri sepette gosterir
        /// </summary>
        public void printProducts()
        {
            dgwDoldur();
        }
        /// <summary>
        /// sepete urun ekler
        /// </summary>
        /// <param name="gelenSepetUrun"></param>
        /// <param name="listeSepet1"></param>
        public void addProduct(Product gelenSepetUrun, ref List<Product> listeSepet1)//(itemToPurchase) - add an item to the shopping cart
        {
            ListeSepet = listeSepet1;
            kontrol = 0;
            for (int i = 0; i < ListeSepet.Count; i++)
            {
                if (ListeSepet[i].Name == gelenSepetUrun.Name)
                {
                    ListeSepet[i].Adet += 1;

                    tutar[i] += ListeSepet[i].Price;
                    gelenSepetUrun = null;

                    kontrol = 1;
                    break;
                }
            }
            if (kontrol == 0)
            {
                tutar.Add(gelenSepetUrun.Price);
                gelenSepetUrun.Adet = 1;
                ListeSepet.Add(gelenSepetUrun);
            }
            if (sayac != 0)
            {
                dgwDoldur();
            }
        }
        /// <summary>
        /// sepetten urun siler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void removeProduct(object sender, DataGridViewCellEventArgs e)//(itemToPurchase) - remove an item from the shopping card
        {
            DataGridView x = (DataGridView)sender;
            if (e.ColumnIndex == 1)
            {
                if (ListeSepet[e.RowIndex].Adet == 1)
                {
                    ListeSepet.RemoveAt(e.RowIndex);
                    dgwSepet.DataSource = null;
                    dgwSepet.Rows.Clear();
                    dgwDoldur();

                }
                else
                {
                    ListeSepet[e.RowIndex].Adet--;
                    x.Rows[e.RowIndex].Cells[2].Value = "         " + ListeSepet[e.RowIndex].Adet;
                    tutar[e.RowIndex] -= ListeSepet[e.RowIndex].Price;

                    x.Rows[e.RowIndex].Cells[5].Value = +tutar[e.RowIndex];
                }
                toplamTutarHesapla();
            }
            else if (e.ColumnIndex == 3)
            {
                ListeSepet[e.RowIndex].Adet++;
                x.Rows[e.RowIndex].Cells[2].Value = "         " + ListeSepet[e.RowIndex].Adet;
                tutar[e.RowIndex] += ListeSepet[e.RowIndex].Price;

                x.Rows[e.RowIndex].Cells[5].Value = +tutar[e.RowIndex];
                toplamTutarHesapla();
            }
            else if (e.ColumnIndex == 4)
            {
                ListeSepet.RemoveAt(e.RowIndex);
                dgwSepet.DataSource = null;
                dgwSepet.Rows.Clear();
                if (ListeSepet.Count >= 2)
                    dgwSepet.Rows.Add(ListeSepet.Count - 1);
                else
                { sayac = 0; }
                dgwDoldur();
                toplamTutarHesapla();
            }
        }
        /// <summary>
        /// odeme ekranina gecer email gonderir
        /// </summary>
        public void placeOrder()// – perform the payment for the items in the cart and send invoice to custumer’s email
        {
            ListeSepet = ShoppingCard.ListeSepet;
            if (ListeSepet.Count > 0)
            {
                double tutar = Convert.ToDouble(lblToplamim.Text);
                FormOdemeEkrani odeme = new FormOdemeEkrani(tutar);
                odeme.Show();
            }
            else
            {
                MessageBox.Show("urun yok");
            }           
        }
        /// <summary>
        /// siparis iptal eder
        /// </summary>
        public void cancelOrder()// – cancel the order o sendInvoicebySMS()
        {
            MessageBox.Show("siparis iptal edildi");
        }
        /// <summary>
        /// musteriye siparis ile ilgili  mail atar
        /// </summary>
        public void sendInvoidcebyEmail()
        {

            SmtpClient sc = new SmtpClient();
            sc.Port = 587;//------------
            sc.Host = "smtp.gmail.com";//gonderen tipi
            sc.EnableSsl = true;//internet adreslerini https oldugunu soyler guvenlı ınternet protokolu
            sc.Credentials = new NetworkCredential("sametsalgin1070@gmail.com", "SasaTurk1453");//hesaba gırıs adres ve sıfre(-------------@gmail.com)deneme amaclı acıldı
            MailMessage mesaj = new MailMessage();
            mesaj.From = new MailAddress("sametsalgin1070@gmail.com");//kimden
            mesaj.BodyEncoding = System.Text.Encoding.UTF8;
            mesaj.To.Add(musteri.Email);//kime
            mesaj.Subject = "SİPARİS ALINDI(E-FATURA)";//konu baslık
            mesaj.IsBodyHtml = true;//html kodları calısır
            mesaj.Body = "";
            for (int i = 0; i < ListeSepet.Count; i++)
            {
                mesaj.Body += ListeSepet[i].Adet +" TANE " +ListeSepet[i].Name + " ADLI URUN "+ListeSepet[i].Price+"TL TUTARINDA "+ System.Environment.NewLine;
            }
            mesaj.Body += musteri.Name+Environment.NewLine+musteri.address;//mesaj içerik


            sc.Send(mesaj);//gonderme
            MessageBox.Show("iletildi");
        }
        /// <summary>
        /// sqldeki verileri ceker ve sepete aktarir
        /// </summary>
        /// <param name="cekilenUrunler"></param>
        public void SqlSepettenCek(List<Product> cekilenUrunler)
        {
            ListeSepet = cekilenUrunler;
            dgwDoldur();
        }
        /// <summary>
        /// sepetteki datagridviewi doldurur nesneler ile
        /// </summary>
        public void dgwDoldur()
        {
            //if (ListeSepet.Count > 0 && kontrol == 0)
            //    dgwSepet.Rows.Add(1);
            if(ListeSepet.Count!=0)
            {
               // dgwSepet.DataSource = "";
                dgwSepet.DataSource = null;
                dgwSepet.Rows.Clear();
            }
            
            for (int i = 0; i < ListeSepet.Count; i++)
            {
                if (ListeSepet.Count > 0 /*&& kontrol == 0*/)
                    dgwSepet.Rows.Add(1);
                try
                {

                    kitapSepet = (Book)ListeSepet[i];

                }
                catch
                { }
                try
                {
                    cdSepet = (MusicCD)ListeSepet[i];
                }
                catch { }
                try
                {

                    dergiSepet = (Magazine)ListeSepet[i];
                }
                catch { }
                if (kitapSepet != null)
                {
                    dgwSepet.Rows[i].Cells[0].Value = kitapSepet.Name;
                    dgwSepet.Rows[i].Cells[1].Value = "             -         ";
                    dgwSepet.Rows[i].Cells[2].Value = "          " + kitapSepet.Adet;
                    dgwSepet.Rows[i].Cells[3].Value = "             +          ";
                    dgwSepet.Rows[i].Cells[4].Value = "             X";
                    dgwSepet.Rows[i].Cells[5].Value = tutar[i];
                    pbxUrun.ImageLocation = kitapSepet.Cover_page_picture;
                    kitapSepet = null;

                }
                else if (dergiSepet != null)
                {
                    dgwSepet.Rows[i].Cells[0].Value = dergiSepet.Name;
                    dgwSepet.Rows[i].Cells[1].Value = "             -         ";
                    dgwSepet.Rows[i].Cells[2].Value = "          " + dergiSepet.Adet;
                    dgwSepet.Rows[i].Cells[3].Value = "             +         ";
                    dgwSepet.Rows[i].Cells[4].Value = "             X";
                    dgwSepet.Rows[i].Cells[5].Value = tutar[i];
                    pbxUrun.ImageLocation = dergiSepet.ImageLocation;
                    dergiSepet = null;


                }
                else
                {
                    dgwSepet.Rows[i].Cells[0].Value = cdSepet.Name;
                    dgwSepet.Rows[i].Cells[1].Value = "             -        ";
                    dgwSepet.Rows[i].Cells[2].Value = "          " + cdSepet.Adet;
                    dgwSepet.Rows[i].Cells[3].Value = "             +        ";
                    dgwSepet.Rows[i].Cells[4].Value = "             X";
                    dgwSepet.Rows[i].Cells[5].Value = tutar[i];
                    pbxUrun.ImageLocation = cdSepet.ImageLocation;
                    cdSepet = null;
                }

            }
            if (sayac == 0)
                sayac++;
            toplamTutarHesapla();
        }
        /// <summary>
        /// toplam tutari hesaplar
        /// </summary>
        public void toplamTutarHesapla()
        {
            if(listeSepet.Count>0)
            {
                double altTutar = 0;

                for (int i = 0; i < ListeSepet.Count; i++)
                {
                    altTutar += Convert.ToDouble(dgwSepet.Rows[i].Cells[5].Value);

                }
                if (altTutar >= 150)
                {
                    lblKargom.Text = "0";
                    lblAltToplamim.Text = altTutar.ToString();
                    lblToplamim.Text = lblAltToplamim.Text;

                }
                else if (altTutar < 150 && altTutar > 0)
                {
                    lblKargom.Text = "5";

                    lblAltToplamim.Text = altTutar.ToString();
                    altTutar += 5;
                    lblToplamim.Text = altTutar.ToString();
                }
            }
            else
            {
                lblKargom.Text = "0";
                lblAltToplamim.Text = "--------";
                lblToplamim.Text = "--------";
            }
        }
        /// <summary>
        /// sepetteki datagirdviewi bosaltir
        /// </summary>
        public void dgwSil()
        {
            ListeSepet.Clear();
        }
        public List<Product> dondurliste()
        {
            return listeSepet;
        }
    }
}
