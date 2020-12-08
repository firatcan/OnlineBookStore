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
using System.Collections;

namespace OOP2_PROJE
{
    /// <summary>
    /// 5li sekilde urunleri gosteririr
    /// </summary>
    public partial class FormUrunler : Form
    {
        List<grupUrunleri> formUrunleriListesi = new List<grupUrunleri>();

        FormSepet sepet = FormSepet.formSepet();
        Customer CustomerNesnesi = FormAnaEkran.CustomerNesnesi;
        gosterKitap kitapGoster = new gosterKitap();
        gosterDergi dergiGoster = new gosterDergi();
        gosterMusicCD musicCDGoster = new gosterMusicCD();
        
        public static int tiklanmaDurumu = 0;
        /// <summary>
        /// form yuklenirken ekrandaki form urunlerini listeye kaydeder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormUrunler_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            grupUrunleri grupUrun = new grupUrunleri();
            grupUrun.grupUrunleriOLustur(ref lbl1Adim, ref lbl1Konum, ref lbl1Fiyatim, ref pbx1);
            formUrunleriListesi.Add(grupUrun);
            grupUrun = new grupUrunleri();
            grupUrun.grupUrunleriOLustur(ref lbl2Adim, ref lbl2Konum, ref lbl2Fiyatim, ref pbx2);
            formUrunleriListesi.Add(grupUrun);
            grupUrun = new grupUrunleri();
            grupUrun.grupUrunleriOLustur(ref lbl3Adim, ref lbl3Konum, ref lbl3Fiyatim, ref pbx3);
            formUrunleriListesi.Add(grupUrun);
            grupUrun = new grupUrunleri();
            grupUrun.grupUrunleriOLustur(ref lbl4Adim, ref lbl4Konum, ref lbl4Fiyatim, ref pbx4);
            formUrunleriListesi.Add(grupUrun);
            grupUrun = new grupUrunleri();
            grupUrun.grupUrunleriOLustur(ref lbl5Adim, ref lbl5Konum, ref lbl5Fiyatim, ref pbx5);
            formUrunleriListesi.Add(grupUrun);
        }
        public FormUrunler()
        {
            InitializeComponent();
        }
        /// <summary>
        /// kitaplari formda gosterir
        /// </summary>
        /// <param name="bookListesi"></param>
      
        internal void kitaplariGoster(List<Book> bookListesi)
        {

            tiklanmaDurumu = kitapGoster.kitaplariGoster(ref bookListesi, ref formUrunleriListesi);
        }
        /// <summary>
        /// dergileri formda gosterir
        /// </summary>
        /// <param name="magazineListesi"></param>

        internal void dergileriGoster(List<Magazine> magazineListesi)
        {
            tiklanmaDurumu = dergiGoster.dergileriGoster(ref magazineListesi, ref formUrunleriListesi);
        }
        /// <summary>
        /// music-cd leri formda gosterir
        /// </summary>
        /// <param name="musicCDListesi"></param>
        internal void muzikCDleriGoster(List<MusicCD> musicCDListesi)
        {
            tiklanmaDurumu = musicCDGoster.muzikCDleriGoster(ref musicCDListesi, ref formUrunleriListesi);
        }
        /// <summary>
        /// kitaplari bir onceki 5li olarak gosterir
        /// </summary>
        /// <param name="bookListesi"></param>
        internal void kitaplariGeriGoster(List<Book> bookListesi)
        {
            tiklanmaDurumu = kitapGoster.kitaplariGeriGoster(ref bookListesi, ref formUrunleriListesi);
        }
        /// <summary>
        /// dergileri bir onceki 5li olarak gosterir
        /// </summary>
        /// <param name="magazineListesi"></param>
        internal void dergileriGeriGoster(List<Magazine> magazineListesi)
        {
            tiklanmaDurumu = dergiGoster.dergileriGeriGoster(ref magazineListesi, ref formUrunleriListesi);
        }
        /// <summary>
        /// music-cd leri bir onceki 5li olarak gosterir
        /// </summary>
        /// <param name="musicCDListesi"></param>
        internal void muzikCDleriGeriGoster(List<MusicCD> musicCDListesi)
        {
            tiklanmaDurumu = musicCDGoster.muzikCDleriGeriGoster(ref musicCDListesi, ref formUrunleriListesi);  
        }
        /// <summary>
        /// bir sonraki 5 liyi gosterir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnIleriGoster_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, btnIleriGoster.Name, CustomerNesnesi.userName);
            }
            switch (tiklanmaDurumu)
            {
                case 1:
                    if (SQLkitap.veriAdetSay < SQLkitap.sqlAdetBul)
                    {
                        SQLkitap kitapCek = new SQLkitap();
                        kitapCek.kitaplariSQLdenCek();
                        kitaplariGoster(kitapCek.dondur());
                    }
                    break;
                case 2:
                    if (SQLdergi.veriAdetSay < SQLdergi.sqlAdetBul)
                    {
                        SQLdergi dergiCek = new SQLdergi();
                        dergiCek.dergileriSQLdenCek();
                        dergileriGoster(dergiCek.dondur());
                    }
                    break;
                case 3:
                    if (SQLmusicCd.veriAdetSay < SQLmusicCd.sqlAdetBul)
                    {
                        SQLmusicCd cdCek = new SQLmusicCd();
                        cdCek.muzikCDleriSQLdenCek();
                        muzikCDleriGoster(cdCek.dondur());
                    }
                    break;
            }
        }
        /// <summary>
        /// bir onceki 5 liyi gosterir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGeriGoster_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, btnGeriGoster.Name,  CustomerNesnesi.userName);
            }
            switch (tiklanmaDurumu)
            {

                case 1:
                    if (SQLkitap.veriAdetSay > 5)
                    {
                        SQLkitap kitapCek = new SQLkitap();
                        kitapCek.kitaplariSQLdenGeriCek();
                        kitaplariGeriGoster(kitapCek.dondur());
                    }
                    break;
                case 2:
                    
                    if (SQLdergi.veriAdetSay > 5)
                    {
                        SQLdergi dergiCek = new SQLdergi();
                        dergiCek.dergileriSQLdenGeriCek();
                        dergileriGeriGoster(dergiCek.dondur());
                    }
                    break;
                case 3:

                    if (SQLmusicCd.veriAdetSay > 5)
                    {
                        SQLmusicCd cdCek = new SQLmusicCd();
                        cdCek.muzikCDleriSQLdenGeriCek();
                        muzikCDleriGeriGoster(cdCek.dondur());
                    }
                    break;
            }
        }
        /// <summary>
        /// kullanicinin profil bilgilerini gosterir
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
        /// <summary>
        /// anasayfaya geri doner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxAnaSayfaFoto_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, pbxAnaSayfaFoto.Name, CustomerNesnesi.userName);
                this.Close();
            }
            FormAnaEkran anaEkran = FormAnaEkran.formAnaEkran;
            this.Close();
            anaEkran.Show();
            
        }
        /// <summary>
        /// kitaplari bu ekranda gosterir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBook_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, btnBook.Name, CustomerNesnesi.userName);
            }

            SQLkitap kitapCek = new SQLkitap();
            if (SQLkitap.veriAdetSay < SQLkitap.sqlAdetBul)
            {
                kitapCek.kitaplariSQLdenCek();
                kitaplariGoster(kitapCek.dondur());
            }
            else if(SQLkitap.veriAdetSay!=0)
            {
                kitapCek.kitaplariSQLdenGeriCek();
                kitaplariGoster(kitapCek.dondur());
            }



        }
        /// <summary>
        /// dergileri bu ekranda gosterir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnMagazine_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, btnMagazine.Name, CustomerNesnesi.userName);
            }
            SQLdergi dergiCek = new SQLdergi();
            if (SQLdergi.veriAdetSay < SQLdergi.sqlAdetBul)
            {
                dergiCek.dergileriSQLdenCek();
                dergileriGoster(dergiCek.dondur());
                gosterDergi.dergiSayac = 0;
            }
            else if(SQLdergi.veriAdetSay!=0)
            {
                dergiCek.dergileriSQLdenGeriCek();
                dergileriGoster(dergiCek.dondur());
            }
        }
        /// <summary>
        /// music-cd leri bu ekranda gosterir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMusicCd_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, btnMusicCd.Name, CustomerNesnesi.userName);
            }
            SQLmusicCd musicCDcek = new SQLmusicCd();
            if (SQLmusicCd.veriAdetSay < SQLmusicCd.sqlAdetBul)
            {
                musicCDcek.muzikCDleriSQLdenCek();
                muzikCDleriGoster(musicCDcek.dondur());
                gosterMusicCD.muzikCdSayac = 0;
                //musicCDcek.MusicCdcekGoster();
            }
            else if(SQLmusicCd.veriAdetSay!=0)
            {
                musicCDcek.muzikCDleriSQLdenGeriCek();
                muzikCDleriGoster(musicCDcek.dondur());
            }
        }
        /// <summary>
        /// tıklanan resmi tum ayrintili sekilde formUrunde gosterir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbx2_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, ((PictureBox)sender).Name, CustomerNesnesi.userName);
            }
            if ((PictureBox)sender == pbx1)
            {
                if (formUrunleriListesi[0].urunDondur() != null)
                {
                    FormUrun urun = new FormUrun(formUrunleriListesi[0].urunDondur(), tiklanmaDurumu);
                    urun.Show();
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if ((PictureBox)sender == pbx2)
            {
                if (formUrunleriListesi[1].urunDondur() != null)
                {
                    FormUrun urun = new FormUrun(formUrunleriListesi[1].urunDondur(), tiklanmaDurumu);
                    urun.Show();
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if ((PictureBox)sender == pbx3)
            {
                if (formUrunleriListesi[2].urunDondur() != null)
                {
                    FormUrun urun = new FormUrun(formUrunleriListesi[2].urunDondur(), tiklanmaDurumu);
                    urun.Show();
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if ((PictureBox)sender == pbx4)
            {
                if (formUrunleriListesi[3].urunDondur() != null)
                {
                    FormUrun urun = new FormUrun(formUrunleriListesi[3].urunDondur(), tiklanmaDurumu);
                    urun.Show();
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if ((PictureBox)sender == pbx5)
            {
                if (formUrunleriListesi[4].urunDondur() != null)
                {
                    FormUrun urun = new FormUrun(formUrunleriListesi[4].urunDondur(), tiklanmaDurumu);
                    urun.Show();
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        /// <summary>
        /// kullanicinin onceki siparislerini gosterir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSiparislerim_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, btnSiparislerim.Name, CustomerNesnesi.userName);
                CustomerNesnesi.printCustomerPurchases();
            }
        }
        /// <summary>
        /// sepeti acar ve sepetteki urunleri gosterir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxSepet_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, pbxSepet.Name, CustomerNesnesi.userName);
            }
            FormSepet sepet = FormSepet.formSepet();
            sepet.ShowDialog();
        }
        /// <summary>
        /// secilen urunu sepete ekler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1SepeteEkle_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, ((Button)sender).Name, CustomerNesnesi.userName);
            }
            if ((Button)sender == btn1SepeteEkle)
            {
                if (formUrunleriListesi[0].urunDondur() != null)
                {
                    sepet.FormSepeteekle(formUrunleriListesi[0].urunDondur());
                    MessageBox.Show(formUrunleriListesi[0].urunDondur().Name + Environment.NewLine + " ADLI URUN SEPETE EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else if ((Button)sender == btn2SepeteEkle)
            {
                if (formUrunleriListesi[1].urunDondur() != null)
                {
                    sepet.FormSepeteekle(formUrunleriListesi[1].urunDondur());
                    MessageBox.Show(formUrunleriListesi[1].urunDondur().Name + Environment.NewLine + " ADLI URUN SEPETE EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if ((Button)sender == btn3SepeteEkle)
            {
                if (formUrunleriListesi[2].urunDondur() != null)
                {
                    sepet.FormSepeteekle(formUrunleriListesi[2].urunDondur());
                    MessageBox.Show(formUrunleriListesi[2].urunDondur().Name + Environment.NewLine + " ADLI URUN SEPETE EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if ((Button)sender == btn4SepeteEkle)
            {
                if (formUrunleriListesi[3].urunDondur() != null)
                {
                    sepet.FormSepeteekle(formUrunleriListesi[3].urunDondur());
                    MessageBox.Show(formUrunleriListesi[3].urunDondur().Name + Environment.NewLine + " ADLI URUN SEPETE EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if ((Button)sender == btn5SepeteEkle)
            {
                if (formUrunleriListesi[4].urunDondur() != null)
                {
                    sepet.FormSepeteekle(formUrunleriListesi[4].urunDondur());
                    MessageBox.Show(formUrunleriListesi[4].urunDondur().Name + Environment.NewLine + " ADLI URUN SEPETE EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("GEÇERLİ ÜRÜN YOK", "ÜRÜN YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        /// <summary>
        /// ana ekrani acar kapatilirken
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormUrunler_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAnaEkran anaEkran = FormAnaEkran.formAnaEkran;
            anaEkran.Show();
        }

        private void pboxAra_Click(object sender, EventArgs e)
        {
            dgwAranan.Visible = true;
            SQLkitap bulkitap = new SQLkitap();
            //SQLdergi buldergi = new SQLdergi();
            //SQLmusicCd bulcd = new SQLmusicCd();

            DataTable tablo = new DataTable();
            string aranan = txtAra.Text.ToString();
            bulkitap.kitapAra(aranan, ref tablo);


            //buldergi.dergiAra(txtAra.Text, ref tablo1);

            //bulcd.cdAra(txtAra.Text, ref tablo2);

            dgwAranan.DataSource = tablo;
            dgwAranan.Columns[0].Width = 300;
            txtAra.Text = "";
        }
        private void dgwAranan_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SQLkitap bulkitap = new SQLkitap();
            bulkitap.kitabigoster(dgwAranan.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void txtAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pboxAra_Click(sender,e);
            }
        }
    }
}

