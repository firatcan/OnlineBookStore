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
    public partial class FormUrun : Form
    {
        Book kitap;
        Magazine dergi;
        MusicCD cd;
        grupUrunleri grupUrun;
        FormSepet sepet = FormSepet.formSepet();
        Customer CustomerNesnesi = Customer.customer;
        static int durum;
        /// <summary>
        /// FormUrun constructor
        /// </summary>
        public FormUrun()
        {
        }
        /// <summary>
        /// FormUrun constructor
        /// </summary>
        /// <param name="gelenUrun"></param>
        /// <param name="hangisi"></param>
        public FormUrun(Product gelenUrun,int hangisi)
        {
            grupUrun = new grupUrunleri();

            if (gelenUrun.GetType().ToString() == "OOP2_PROJE.Book")
            {
                kitap = (Book)gelenUrun;
                durum = 1;
            }
            else if (gelenUrun.GetType().ToString() == "OOP2_PROJE.Magazine")
            {
                dergi = (Magazine)gelenUrun;
                durum = 2;
            }
            else if (gelenUrun.GetType().ToString() == "OOP2_PROJE.MusicCD")
            {
                cd = (MusicCD)gelenUrun;
                durum = 3;
            }
            
            InitializeComponent();
        }
        /// <summary>
        /// FormUrun Load fonksiyonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormUrun_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            switch (durum)
            {
                case 1:
                    grupUrun.grupUrunleriOLustur(ref lblAdim, ref lblKonum, ref lblFiyatim, ref lblYazarim, ref lblSayfam, ref lblYayinim, ref lblIsbn1, ref pbxUrun);
                    grupUrun.grupUrunleriGoster(kitap);
                    break;
                case 2:
                    lblYayinci.Text = "Sayı : ";
                    grupUrun.grupUrunleriOLustur(ref lblAdim, ref lblKonum, ref lblFiyatim, ref lblYazarim, ref lblSayfam, ref lblYayinim, ref lblIsbn1, ref pbxUrun);
                    grupUrun.grupUrunleriGoster(dergi);
                    lblKonu.Visible = false;
                    lblKonum.Visible = false;
                    lblSayfa.Visible = false;
                    lblSayfam.Visible = false;
                    lblYazar.Visible = false;
                    lblYazarim.Visible = false;
                    lblIsbn.Visible = false;
                    lblIsbn1.Visible = false;
                    break;
                case 3:
                    grupUrun.grupUrunleriOLustur(ref lblAdim, ref lblKonum, ref lblFiyatim, ref lblYazarim, ref lblSayfam, ref lblYayinim, ref lblIsbn1, ref pbxUrun);
                    grupUrun.grupUrunleriGoster(cd);
                    lblSayfa.Visible = false;
                    lblSayfam.Visible = false;
                    lblYayinci.Visible = false;
                    lblYayinim.Visible = false;
                    lblYazar.Text = "Şarkıcı";
                    lblIsbn.Visible = false;
                    lblIsbn1.Visible = false;
                    break;
            }
            
        }
        /// <summary>
        /// butona tiklandiginda giris yapan musterinin bilgilerini gosteren fonksiyonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProfilim_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, btnProfilim.Name,  CustomerNesnesi.userName);
                CustomerNesnesi.printCustomerDetails();
            }
        }
        /// <summary>
        /// anasayfa fotografina tiklandiginda FormAnaEkran formuna yonlendiren fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxAnaEkran_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, pbxAnaEkran.Name,  CustomerNesnesi.userName);
                this.Close();
            }
            FormAnaEkran anaEkran = FormAnaEkran.formAnaEkran;
            anaEkran.Show();
            this.Close();
        }
        /// <summary>
        /// butona tiklandiginda urunu sepete ekleyen fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1SepeteEkle_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, btn1SepeteEkle.Name,  CustomerNesnesi.userName);
                this.Close();
            }
            if (durum == 1)
            {
                sepet.FormSepeteekle(kitap);
                MessageBox.Show(kitap.Name + Environment.NewLine + " ADLI URUN SEPETE EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (durum == 2)
            {
                sepet.FormSepeteekle(dergi);
                MessageBox.Show(dergi.Name + Environment.NewLine + " ADLI URUN SEPETE EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (durum == 3)
            {
                sepet.FormSepeteekle(cd);
                MessageBox.Show(cd.Name + Environment.NewLine + " ADLI URUN SEPETE EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// giris yapan musterinin satin aldigi urunleri gosteren fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSiparislerim_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, btnSiparislerim.Name,  CustomerNesnesi.userName);
                CustomerNesnesi.printCustomerPurchases();
            }
        }

        private void FormUrun_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
