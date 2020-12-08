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
{/// <summary>
/// admin veya customer girisi yapan ekran
/// </summary>
    public partial class FormUyeGirisi : Form
    {
        FormAnaEkran form1AnaEkran_obj = FormAnaEkran.formAnaEkran;
        FormAdminEkrani formAdminEkrani_obj = FormAdminEkrani.formAdminEkrani;
        
        SQL_User userNesnesi;
        /// <summary>
        /// formu baslatir ve yeri belirtir
        /// </summary>
        public FormUyeGirisi()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Top = 25;
            this.Left = 934;
        }
        /// <summary>
        /// giris yapan butonun onayidir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUyeGirisiOnay_Click(object sender, EventArgs e)
        {
            GirisYapan();
        }
        /// <summary>
        /// giris yapan kullanicinin bilgilerini alir
        /// </summary>
        public void GirisYapan()
        {
            userNesnesi = new SQL_User();
            if (userNesnesi.GirisYapanMusteri(txtKullaniciAdiUyeGirisi.Text,txtSifreUyeGirisi.Text))
            {
                form1AnaEkran_obj.linklblUyeGirisi.Visible = false;
                form1AnaEkran_obj.linklblKayitOl.Visible = false;
                MessageBox.Show("Musteri Girişi Yapıldı", "Close Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
               
                SQL_SepetKayit sepetKayit = new SQL_SepetKayit();
                ShoppingCard card = ShoppingCard.shoppingCard;
                FormSepet sepet = FormSepet.formSepet();
                FormSepet.listeSepet.Clear();
                ShoppingCard.ListeSepet.Clear();
                sepet.esle();
                sepet.dgwColonDoldur();
                List<Product> cekilenListe = sepetKayit.SepettenCek();
                
                card.dgwDoldur();
                for (int i = 0; i < cekilenListe.Count; i++)
                {
                    sepet.FormSepeteekle(cekilenListe[i]);
                }
                this.Close();
                form1AnaEkran_obj.linklblCikisYap.Visible = true;
                form1AnaEkran_obj.BringToFront();
            }
            else if (userNesnesi.GirisYapanAdmin(txtKullaniciAdiUyeGirisi.Text, txtSifreUyeGirisi.Text))
            {
                form1AnaEkran_obj.linklblUyeGirisi.Visible = false;
                form1AnaEkran_obj.linklblKayitOl.Visible = false;
                form1AnaEkran_obj.linklblCikisYap.Visible = true;
                formAdminEkrani_obj.lblAdminAdi.Text = FormAnaEkran.AdminUserNesnesi.name;
                formAdminEkrani_obj.lblAdminKullaniciAdi.Text = FormAnaEkran.AdminUserNesnesi.userName;
                MessageBox.Show("Admin Girişi Yapıldı", "Close Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                formAdminEkrani_obj.Show();
            }
            else
            {
                MessageBox.Show("Girdiğiniz Bilgilere Ait Kullanıcı Bulunamadı", "Close Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// sifreyi gostermez ekranda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSifreUyeGirisi_TextChanged(object sender, EventArgs e)
        {
            txtSifreUyeGirisi.PasswordChar = '*';
        }
        /// <summary>
        /// sifremi unuttum ekranina gecer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            FormSifremiUnuttum unuttum = new FormSifremiUnuttum();
            unuttum.Show();
        }
    }
}
