using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_PROJE
{
    public partial class FormOdemeEkrani : Form
    {
        double tutar;
        ShoppingCard sepetSinif = ShoppingCard.shoppingCard;
        Customer CustomerNesnesi = FormAnaEkran.CustomerNesnesi;
        /// <summary>
        /// FormOdemeEkrani constructor 
        /// </summary>
        /// <param name="tutar"></param>
        public FormOdemeEkrani(double tutar)
        {
            this.tutar = tutar;

            InitializeComponent();
            lblTutar.Text = Convert.ToString(tutar);
            lblTutar1.Text = Convert.ToString(tutar);
        }
        /// <summary>
        /// checked true oldugunda kayitli adres esas alinir 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rediobtnKayitli_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, radiobtnKayitli1.Name, CustomerNesnesi.userName);
            }
            txtAdres.Visible = false;
            lblAdres.Visible = false;
        }
        /// <summary>
        /// checked true oldugunda urunu gondermek icin yeni adres girilmesi istenir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radiobtnYeniAdres_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, radiobtnYeniAdres.Name, CustomerNesnesi.userName);
            }
            txtAdres.Visible = true;
            lblAdres.Visible = true;
        }
        /// <summary>
        /// girilen bilgilerin tamligini kontrol eden fonksiyon
        /// </summary>
        /// <param name="txtbx"></param>
        /// <returns></returns>
        private bool girdiKontrol(string txtbx)
        {
            int dolulukSayac = 0;
            for (int i = 0; i < txtbx.Length; i++)
            {
                if (!txtbx[i].Equals(' '))
                {
                    dolulukSayac++;
                }
            }
            if (txtbx.Length != dolulukSayac)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// butona tiklandiginda urunu alan fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, btnOnayla.Name,  CustomerNesnesi.userName);
                bool kontrolKart = girdiKontrol(mtxtKart.Text);
                bool kontrolSonKullanma = girdiKontrol(mtxtSnKullanma.Text);
                bool kontrolCvc = girdiKontrol(mtxtCvc.Text);
                bool kontrolText = girdiKontrol(mtxtTelefon.Text);
                if (radiobtnYeniAdres.Checked == true)
                {
                    bool kontrolAdres = girdiKontrol(txtAdres1.Text);
                }
                else if (radiobtnYeniAdres1.Checked == true)
                {
                    bool kontrolAdres1 = girdiKontrol(txtAdres1.Text);
                }

                if (kontrolKart && kontrolSonKullanma && kontrolCvc && kontrolText)
                {

                    absSiparis siparis1 = new absSiparis("sametsalgin10@gmail.com",CustomerNesnesi.name);
                    siparis1.Mail.Add(new mailAt { E_mail = "sametsalgin10@gmail.com" });
                    siparis1.onayekle(sepetSinif.dondurliste());
                    

                    sepetSinif.sendInvoidcebyEmail();
                    cardEkle();
                    ShoppingCard card = ShoppingCard.shoppingCard;
                    card.dgwSil();

                    FormSiparisAlındı tsk = FormSiparisAlındı.formSiparisAlındı;
                    tsk.ShowDialog();
                    


                    

                    
                }
                else
                {
                    MessageBox.Show("Bilgilerin Eksiksiz Doldurulması Gerekmektedir");
                }
            }
            else
                MessageBox.Show("giris yapmalısınız");
        }
        /// <summary>
        /// alinan urunleri shoppingcard'a ekleyen fonksiyon
        /// </summary>
        public void cardEkle()
        {
            List<Product> listSepet = ShoppingCard.ListeSepet;
            Customer customerNesnesi = FormAnaEkran.CustomerNesnesi;

            SQL_ShoppingCard sqlShopCard = new SQL_ShoppingCard();
            for (int i = 0; i < listSepet.Count; i++)
            {
                sqlShopCard.CardKaydet(int.Parse(customerNesnesi.id), listSepet[i].Adet, listSepet[i].Name, listSepet[i].Price.ToString());
            }
        }
        /// <summary>
        /// kapida odeme icin onay fonksiyonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOnayla1_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is MaskedTextBox)
                {
                    if (((MaskedTextBox)ctl).MaskFull == false)
                    {
                        MessageBox.Show(((MaskedTextBox)ctl).Name + " isimli maskedtextbox içeriği eksik");
                    }
                }
            }
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, btnOnayla1.Name, CustomerNesnesi.userName);
                sepetSinif.sendInvoidcebyEmail();
                cardEkle();
                FormSiparisAlındı tsk = FormSiparisAlındı.formSiparisAlındı;
                tsk.Show();
            }
        }
        /// <summary>
        /// checked true oldugunda kapida odeme icin yeni adres girilmesi gerekir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radiobtnYeniAdres1_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, radiobtnYeniAdres1.Name, CustomerNesnesi.userName);
            }

            txtAdres1.Visible = true;
            lblAdres1.Visible = true;
        }
        /// <summary>
        /// checked true oldugunda kapida odeme icin kayitli adres esas alinir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radiobtnKayitli1_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, radiobtnKayitli1.Name, CustomerNesnesi.userName);
            }

            txtAdres1.Visible = false;
            lblAdres1.Visible = false;
        }
        /// <summary>
        /// FormOdemeEkrani Load fonksiyonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormOdemeEkrani_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void FormOdemeEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
