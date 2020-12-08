using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OOP2_PROJE
{

    public partial class FormAnaEkran : Form
    {
        int girisResimIndex = 0;
        private static FormAnaEkran singletonNesnesi = null;

        FormSepet sepet = FormSepet.formSepet();
        Book bookNesnesi = new Book();
        Magazine magazineNesnesi = new Magazine();
        MusicCD musicCDnesnesi = new MusicCD();
        List<grupUrunleri> kitapGrup = new List<grupUrunleri>();
        List<grupUrunleri> dergiGrup = new List<grupUrunleri>();
        List<grupUrunleri> musiccdGrup = new List<grupUrunleri>();

        gosterKitap kitapGoster = new gosterKitap();
        gosterDergi dergiGoster = new gosterDergi();
        gosterMusicCD musicCDGoster = new gosterMusicCD();

        private static Customer customerNesnesi;
        private static AdminUser adminUserNesnesi;

        internal static AdminUser AdminUserNesnesi { get => adminUserNesnesi; set => adminUserNesnesi = value; }
        internal static Customer CustomerNesnesi { get => customerNesnesi; set => customerNesnesi = value; }
        static int tiklanmaDurumu = 0;
        
        private FormAnaEkran()
        {
            InitializeComponent();
            linklblCikisYap.Visible = false;

        }
        public static FormAnaEkran formAnaEkran
        {
            get
            {
                if (singletonNesnesi == null)
                {
                    singletonNesnesi = new FormAnaEkran();

                }
                return singletonNesnesi;
            }

        }
        private void linklblUyeGirisi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUyeGirisi formUyeGirisi = new FormUyeGirisi();
            formUyeGirisi.Show();
        }
        private void linklblKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormKayitOl formKayitOl_obj = new FormKayitOl();
            formKayitOl_obj.Show();
        }
        private void linklblCikisYap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, linklblCikisYap.Name, CustomerNesnesi.userName);
                linklblUyeGirisi.Visible = true;
                linklblKayitOl.Visible = true;
                linklblCikisYap.Visible = false;
                List<Product> urunSepet = FormSepet.listeSepet;
                
                SQL_SepetKayit sepetKayit = new SQL_SepetKayit();
                sepetKayit.SepetKaydet(urunSepet, CustomerNesnesi);
                FormSepet.listeSepet.Clear();

                CustomerNesnesi = null;
            }
            else if(adminUserNesnesi!=null)
            {
                FormAdminEkrani formAdminEkrani_obj = FormAdminEkrani.formAdminEkrani;
                adminUserNesnesi = null;
                formAdminEkrani_obj.Close();
                linklblUyeGirisi.Visible = true;
                linklblKayitOl.Visible = true;
                linklblCikisYap.Visible = false;
            }
        }
        private void pbxDergi_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, pbxDergi.Name, CustomerNesnesi.userName);
            }
            SQLdergi sqlDergiCek = new SQLdergi();
            sqlDergiCek.dergiCekGoster();
            this.Hide();
        }
        private void pbxKitap_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, pbxKitap.Name, CustomerNesnesi.userName);
            }
            SQLkitap kitapCek = new SQLkitap();
            kitapCek.kitapCekGoster();
            this.Hide();
        }
        private void pbxCD_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, pbxCD.Name, CustomerNesnesi.userName);
            }
            SQLmusicCd muzikCdCek = new SQLmusicCd();
            muzikCdCek.MusicCdcekGoster();
            this.Hide();
        }
        /// <summary>
        /// form ana ekran yuklenirken calisir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAnaEkran_Load(object sender, EventArgs e)
        {
            grupUrunleri grupUrun = new grupUrunleri();
            grupUrun.grupUrunleriOLustur(ref lbl1AdimKitap, ref lbl1FiyatimKitap, ref pbx1Kitap);
            kitapGrup.Add(grupUrun);
            grupUrun = new grupUrunleri();
            grupUrun.grupUrunleriOLustur(ref lbl2AdimKitap, ref lbl2FiyatimKitap, ref pbx2Kitap);
            kitapGrup.Add(grupUrun);
            grupUrun = new grupUrunleri();
            grupUrun.grupUrunleriOLustur(ref lbl3AdimKitap, ref lbl3FiyatimKitap, ref pbx3Kitap);
            kitapGrup.Add(grupUrun);
            grupUrun = new grupUrunleri();
            grupUrun.grupUrunleriOLustur(ref lbl4AdimKitap, ref lbl4FiyatimKitap, ref pbx4Kitap);
            kitapGrup.Add(grupUrun);
            grupUrun = new grupUrunleri();
            grupUrun.grupUrunleriOLustur(ref lbl5AdimKitap, ref lbl5FiyatimKitap, ref pbx5Kitap);
            kitapGrup.Add(grupUrun);

            panelKitapGoster();

            grupUrun = new grupUrunleri();
            grupUrun.grupUrunleriOLustur(ref lbl1AdimDergi, ref lbl1FiyatimDergi, ref pbx1Dergi);
            dergiGrup.Add(grupUrun);
            grupUrun = new grupUrunleri();
            grupUrun.grupUrunleriOLustur(ref lbl2AdimDergi, ref lbl2FiyatimDergi, ref pbx2Dergi);
            dergiGrup.Add(grupUrun);
            grupUrun = new grupUrunleri();
            grupUrun.grupUrunleriOLustur(ref lbl3AdimDergi, ref lbl3FiyatimDergi, ref pbx3Dergi);
            dergiGrup.Add(grupUrun);
            grupUrun = new grupUrunleri();
            grupUrun.grupUrunleriOLustur(ref lbl4AdimDergi, ref lbl4FiyatimDergi, ref pbx4Dergi);
            dergiGrup.Add(grupUrun);
            grupUrun = new grupUrunleri();
            grupUrun.grupUrunleriOLustur(ref lbl5AdimDergi, ref lbl5FiyatimDergi, ref pbx5Dergi);
            dergiGrup.Add(grupUrun);
            grupUrun = new grupUrunleri();


            panelDergiGoster();


           grupUrun = new grupUrunleri();

            grupUrun.grupUrunleriOLustur(ref lbl1AdimCD, ref lbl1FiyatimCD, ref pbx1CD);
            musiccdGrup.Add(grupUrun);
            grupUrun = new grupUrunleri();
            grupUrun.grupUrunleriOLustur(ref lbl2AdimCD, ref lbl2FiyatimCD, ref pbx2CD);
            musiccdGrup.Add(grupUrun);
            grupUrun = new grupUrunleri();
            grupUrun.grupUrunleriOLustur(ref lbl3AdimCD, ref lbl3FiyatimCD, ref pbx3CD);
            musiccdGrup.Add(grupUrun);
            grupUrun = new grupUrunleri();
            grupUrun.grupUrunleriOLustur(ref lbl4AdimCD, ref lbl4FiyatimCD, ref pbx4CD);
            musiccdGrup.Add(grupUrun);
            grupUrun = new grupUrunleri();
            grupUrun.grupUrunleriOLustur(ref lbl5AdimCD, ref lbl5FiyatimCD, ref pbx5CD);
            musiccdGrup.Add(grupUrun);


            panelCDgoster();
        }
        /// <summary>
        /// sepetteki urunleri gosterir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxSepet_Click(object sender, EventArgs e)
        {
            Customer CustomerNesnesi = FormAnaEkran.CustomerNesnesi;
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, pbxSepet.Name, CustomerNesnesi.userName);
            }
            FormSepet sepet = FormSepet.formSepet();
            sepet.ShowDialog();
        }
        /// <summary>
        /// sepete music Cd ekler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1SepeteEkleCD_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, ((Button)sender).Name, CustomerNesnesi.userName);
            }
            if ((Button)sender == btn1SepeteEkleCD)
            {
                if (musiccdGrup[0].urunDondur() != null)
                {
                    sepet.FormSepeteekle(musiccdGrup[0].urunDondur());
                    MessageBox.Show(musiccdGrup[0].urunDondur().Name + Environment.NewLine + " ADLI URUN SEPETE EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if ((Button)sender == btn2SepeteEkleCD)
            {
                if (musiccdGrup[1].urunDondur() != null)
                {
                    sepet.FormSepeteekle(musiccdGrup[1].urunDondur());
                    MessageBox.Show(musiccdGrup[1].urunDondur().Name + Environment.NewLine + " ADLI URUN SEPETE EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if ((Button)sender == btn3SepeteEkleCD)
            {
                if (musiccdGrup[2].urunDondur() != null)
                {
                    sepet.FormSepeteekle(musiccdGrup[2].urunDondur());
                    MessageBox.Show(musiccdGrup[2].urunDondur().Name + Environment.NewLine + " ADLI URUN SEPETE EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if ((Button)sender == btn4SepeteEkleCD)
            {
                if (musiccdGrup[3].urunDondur() != null)
                {
                    sepet.FormSepeteekle(musiccdGrup[3].urunDondur());
                    MessageBox.Show(musiccdGrup[3].urunDondur().Name + Environment.NewLine + " ADLI URUN SEPETE EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if ((Button)sender == btn5SepeteEkleCD)
            {
                if (musiccdGrup[4].urunDondur() != null)
                {
                    sepet.FormSepeteekle(musiccdGrup[4].urunDondur());
                    MessageBox.Show(musiccdGrup[4].urunDondur().Name + Environment.NewLine + " ADLI URUN SEPETE EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
        /// <summary>
        /// sepete dergi ekler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1SepeteEkleDergi_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, ((Button)sender).Name, CustomerNesnesi.userName);
            }
            if ((Button)sender == btn1SepeteEkleDergi)
            {
                if (dergiGrup[0].urunDondur() != null)
                {
                    sepet.FormSepeteekle(dergiGrup[0].urunDondur());
                    MessageBox.Show(dergiGrup[0].urunDondur().Name + Environment.NewLine + " ADLI URUN SEPETE EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if ((Button)sender == btn2SepeteEkleDergi)
            {
                if (dergiGrup[1].urunDondur() != null)
                {
                    sepet.FormSepeteekle(dergiGrup[1].urunDondur());
                    MessageBox.Show(dergiGrup[1].urunDondur().Name + Environment.NewLine + " ADLI URUN SEPETE EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if ((Button)sender == btn3SepeteEkleDergi)
            {
                if (dergiGrup[2].urunDondur() != null)
                {
                    sepet.FormSepeteekle(dergiGrup[2].urunDondur());
                    MessageBox.Show(dergiGrup[2].urunDondur().Name + Environment.NewLine + " ADLI URUN SEPETE EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if ((Button)sender == btn4SepeteEkleDergi)
            {
                if (dergiGrup[3].urunDondur() != null)
                {
                    sepet.FormSepeteekle(dergiGrup[3].urunDondur());
                    MessageBox.Show(dergiGrup[3].urunDondur().Name + Environment.NewLine + " ADLI URUN SEPETE EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if ((Button)sender == btn5SepeteEkleDergi)
            {
                if (dergiGrup[4].urunDondur() != null)
                {
                    sepet.FormSepeteekle(dergiGrup[4].urunDondur());
                    MessageBox.Show(dergiGrup[4].urunDondur().Name + Environment.NewLine + " ADLI URUN SEPETE EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        /// <summary>
        /// sepete kitap ekler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1SepeteEkleKitap_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, ((Button)sender).Name, CustomerNesnesi.userName);
            }
            if ((Button)sender == btn1SepeteEkleKitap)
            {
                if (kitapGrup[0].urunDondur() != null)
                {
                    sepet.FormSepeteekle(kitapGrup[0].urunDondur());
                    MessageBox.Show(kitapGrup[0].urunDondur().Name + Environment.NewLine + " ADLI URUN SEPETE EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if ((Button)sender == btn2SepeteEkleKitap)
            {
                if(kitapGrup[1].urunDondur()!=null)
                { 
                sepet.FormSepeteekle(kitapGrup[1].urunDondur());
                MessageBox.Show(kitapGrup[1].urunDondur().Name + Environment.NewLine + " ADLI URUN SEPETE EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if ((Button)sender == btn3SepeteEkleKitap)
            {
                if (kitapGrup[2].urunDondur() != null)
                {
                    sepet.FormSepeteekle(kitapGrup[2].urunDondur());
                    MessageBox.Show(kitapGrup[2].urunDondur().Name + Environment.NewLine + " ADLI URUN SEPETE EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if ((Button)sender == btn4SepeteEkleKitap)
            {
                if (kitapGrup[3].urunDondur() != null)
                {
                    sepet.FormSepeteekle(kitapGrup[3].urunDondur());
                    MessageBox.Show(kitapGrup[3].urunDondur().Name + Environment.NewLine + " ADLI URUN SEPETE EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if ((Button)sender == btn5SepeteEkleKitap)
            {
                if (kitapGrup[4].urunDondur() != null)
                {
                    sepet.FormSepeteekle(kitapGrup[4].urunDondur());
                    MessageBox.Show(kitapGrup[4].urunDondur().Name + Environment.NewLine + " ADLI URUN SEPETE EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
        /// <summary>
        /// giris yapan musterinin bilgilerini gosterir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProfilim_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, btnProfilim.Name, CustomerNesnesi.userName);
                CustomerNesnesi.printCustomerDetails();
            }
        }
        List<Book> kitapListesi = new List<Book>();
        /// <summary>
        /// ekrandaki panelde kitaplari gosterir
        /// </summary>
        public void panelKitapGoster()
        {
            SQLkitap kit = new SQLkitap();
            kit.kitaplariSQLdenCek();
            kitapListesi = kit.dondur();
            tiklanmaDurumu = kitapGoster.kitaplariGoster(ref kitapListesi, ref kitapGrup);
        }
        /// <summary>
        /// ekrandaki panelde kitaplari geri butonu ile gosterir.
        /// </summary>
        private void panelKitapGeriGoster()
        {
            SQLkitap kit = new SQLkitap();
            kit.kitaplariSQLdenGeriCek();
            kitapListesi = kit.dondur();
            tiklanmaDurumu = kitapGoster.kitaplariGeriGoster(ref kitapListesi, ref kitapGrup);
        }

        List<Magazine> dergiListesi = new List<Magazine>();
        /// <summary>
        /// ekrandaki panelde dergileri gosterir
        /// </summary>
        public void panelDergiGoster()
        {
            SQLdergi der = new SQLdergi();
            der.dergileriSQLdenCek();
            dergiListesi = der.dondur();
            tiklanmaDurumu = dergiGoster.dergileriGoster(ref dergiListesi, ref dergiGrup);
        }
        /// <summary>
        /// ekrandaki panelde dergileri geri butonu ile gosterir
        /// </summary>
        private void panelDergiGeriGoster()
        {
            SQLdergi der = new SQLdergi();
            der.dergileriSQLdenGeriCek();
            dergiListesi = der.dondur();
            tiklanmaDurumu = dergiGoster.dergileriGeriGoster(ref dergiListesi, ref dergiGrup);
        }
        List<MusicCD> cdListesi = new List<MusicCD>();
        /// <summary>
        /// ekrandaki panelde music cd'leri gosterir
        /// </summary>
        public void panelCDgoster()
        {
            SQLmusicCd cd = new SQLmusicCd();
            cd.muzikCDleriSQLdenCek();
            cdListesi = cd.dondur();
            tiklanmaDurumu = musicCDGoster.muzikCDleriGoster(ref cdListesi, ref musiccdGrup);
        }
        private void panelCDGerigoster()
        {
            SQLmusicCd cd = new SQLmusicCd();
            cd.muzikCDleriSQLdenGeriCek();
            cdListesi = cd.dondur();
            tiklanmaDurumu = musicCDGoster.muzikCDleriGeriGoster(ref cdListesi, ref musiccdGrup);
        }
        private void btnIleriGosterKitap_Click_1(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, btnIleriGosterKitap.Name, CustomerNesnesi.userName);
            }
            if (SQLkitap.veriAdetSay < SQLkitap.sqlAdetBul)
            {
                panelKitapGoster();
            }
        }

        private void btnIleriGosterDergi_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, btnIleriGosterDergi.Name, CustomerNesnesi.userName);
            }
            if (SQLdergi.veriAdetSay < SQLdergi.sqlAdetBul)
            {
                panelDergiGoster();
            }
        }

        private void btnIleriGosterCD_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, btnIleriGosterCD.Name, CustomerNesnesi.userName);
            }
            if (SQLmusicCd.veriAdetSay < SQLmusicCd.sqlAdetBul)
            {
                panelCDgoster();
            }
            
        }

        private void btnGeriGosterKitap_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, btnGeriGosterKitap.Name, CustomerNesnesi.userName);
            }
            if (SQLkitap.veriAdetSay >5)
            {
                panelKitapGeriGoster();
            }
        }

        private void btnGeriGosterCD_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, btnGeriGosterCD.Name, CustomerNesnesi.userName);
            }
            if (SQLmusicCd.veriAdetSay > 5)
            {
                panelCDGerigoster();
            }
        }

        private void btnGeriGosterDergi_Click(object sender, EventArgs e)
        {
            if(CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, btnGeriGosterDergi.Name, CustomerNesnesi.userName);
            }
            if (SQLdergi.veriAdetSay > 5)
            {
                panelDergiGeriGoster();
            }
        }

        private void btnSiparislerim_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, btnSiparislerim.Name,  CustomerNesnesi.userName);
                CustomerNesnesi.printCustomerPurchases();
            }
        }

        private void pbx1Kitap_Click(object sender, EventArgs e)
        {
            Customer CustomerNesnesi = Customer.customer;

            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, ((PictureBox)sender).Name, CustomerNesnesi.userName);
            }
            if ((PictureBox)sender == pbx1Kitap)
            {
                if (kitapGrup[0].urunDondur() != null)
                {
                    FormUrun urun = new FormUrun(kitapGrup[0].urunDondur(), 1);
                    urun.Show();
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if ((PictureBox)sender == pbx2Kitap)
            {
                if (kitapGrup[1].urunDondur() != null)
                {
                    FormUrun urun = new FormUrun(kitapGrup[1].urunDondur(), 1);
                    urun.Show();
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if ((PictureBox)sender == pbx3Kitap)
            {
                if (kitapGrup[2].urunDondur() != null)
                {
                    FormUrun urun = new FormUrun(kitapGrup[2].urunDondur(), 1);
                    urun.Show();
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if ((PictureBox)sender == pbx4Kitap)
            {
                if (kitapGrup[3].urunDondur() != null)
                {
                    FormUrun urun = new FormUrun(kitapGrup[3].urunDondur(), 1);
                    urun.Show();
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if ((PictureBox)sender == pbx5Kitap)
            {
                if (kitapGrup[4].urunDondur() != null)
                {
                    FormUrun urun = new FormUrun(kitapGrup[4].urunDondur(), 1);
                    urun.Show();
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void pbx1Dergi_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, ((PictureBox)sender).Name, CustomerNesnesi.userName);
            }
            if ((PictureBox)sender == pbx1Dergi)
            {
                if (dergiGrup[0].urunDondur() != null)
                {
                    FormUrun urun = new FormUrun(dergiGrup[0].urunDondur(), 2);
                    urun.Show();
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if ((PictureBox)sender == pbx2Dergi)
            {
                if (dergiGrup[1].urunDondur() != null)
                {
                    FormUrun urun = new FormUrun(dergiGrup[1].urunDondur(), 2);
                    urun.Show();
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if ((PictureBox)sender == pbx3Dergi)
            {
                if (dergiGrup[2].urunDondur() != null)
                {
                    FormUrun urun = new FormUrun(dergiGrup[2].urunDondur(), 2);
                    urun.Show();
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if ((PictureBox)sender == pbx4Dergi)
            {
                if (dergiGrup[3].urunDondur() != null)
                {
                    FormUrun urun = new FormUrun(dergiGrup[3].urunDondur(), 2);
                    urun.Show();
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if ((PictureBox)sender == pbx5Dergi)
            {
                if (dergiGrup[4].urunDondur() != null)
                {
                    FormUrun urun = new FormUrun(dergiGrup[4].urunDondur(), 2);
                    urun.Show();
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void pbx1CD_Click(object sender, EventArgs e)
        {
            Customer CustomerNesnesi = Customer.customer;

            if ((PictureBox)sender == pbx1CD)
            {
                if (CustomerNesnesi != null)
                {
                    CustomerNesnesi.logCustomer(this, pbx1CD.Name,  CustomerNesnesi.userName);
                }
                if (musiccdGrup[0].urunDondur() != null)
                {
                    FormUrun urun = new FormUrun(musiccdGrup[0].urunDondur(), 3);
                    urun.Show();
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if ((PictureBox)sender == pbx2CD)
            {
                if (CustomerNesnesi != null)
                {
                    CustomerNesnesi.logCustomer(this, pbx2CD.Name,  CustomerNesnesi.userName);
                }
                if (musiccdGrup[1].urunDondur() != null)
                {
                    FormUrun urun = new FormUrun(musiccdGrup[1].urunDondur(), 3);
                    urun.Show();
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if ((PictureBox)sender == pbx3CD)
            {
                if (CustomerNesnesi != null)
                {
                    CustomerNesnesi.logCustomer(this, pbx3CD.Name,  CustomerNesnesi.userName);
                }
                if (musiccdGrup[2].urunDondur() != null)
                {
                    FormUrun urun = new FormUrun(musiccdGrup[2].urunDondur(), 3);
                    urun.Show();
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if ((PictureBox)sender == pbx4CD)
            {
                if (CustomerNesnesi != null)
                {
                    CustomerNesnesi.logCustomer(this, pbx4CD.Name,  CustomerNesnesi.userName);
                }
                if (musiccdGrup[3].urunDondur() != null)
                {
                    FormUrun urun = new FormUrun(musiccdGrup[3].urunDondur(), 3);
                    urun.Show();
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if ((PictureBox)sender == pbx5CD)
            {
                if (CustomerNesnesi != null)
                {
                    CustomerNesnesi.logCustomer(this, pbx5CD.Name,  CustomerNesnesi.userName);
                }
                if (musiccdGrup[4].urunDondur() != null)
                {
                    FormUrun urun = new FormUrun(musiccdGrup[4].urunDondur(), 3);
                    urun.Show();
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
