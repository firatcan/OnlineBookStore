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
    public partial class FormKayitOl : Form
    {
        SQL_User userNesnesi;
        Customer CustomerNesnesi = FormAnaEkran.CustomerNesnesi;
        /// <summary>
        /// FormKayitOl constructor
        /// </summary>
        public FormKayitOl()
        {
            InitializeComponent();
            btnGuncelle.Enabled = false;
            btnKayitOlOnay.Enabled = true;
        }
        /// <summary>
        /// butona tiklandiginda musteri kayit eden fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKayitOlOnay_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, btnKayitOlOnay.Name, CustomerNesnesi.userName);
            }
            kayitOlMusteri();
        }
        /// <summary>
        /// musteri kayit eden fonksiyon
        /// </summary>
        private void kayitOlMusteri()
        {
            userNesnesi = new SQL_User();
            bool kontrolName = girdiKontrol(txtName);
            bool kontrolAdres = girdiKontrol(txtAddress);
            bool kontrolEmail = girdiKontrol(txtEmail);
            bool kontrolUserName = girdiKontrol(txtUserName);
            bool kontrolPassword=girdiKontrol(txtPassword);
            if(kontrolName && kontrolAdres && kontrolEmail && kontrolUserName&& kontrolPassword)
            {
                if (userNesnesi.KayitMusteri(txtUserName.Text) && userNesnesi.kayitAdmin(txtUserName.Text))
                {
                    Customer.saveCustomer(this);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bu Kullanıcı Adı Daha Önce Alınmış. Başka Bir Bullanıcı Adı Girin");
                }
            }
            else
            {
                hataDurum(kontrolName, lblYildiz1);
                hataDurum(kontrolAdres, lblYildiz2);
                hataDurum(kontrolEmail, lblYildiz3);
                hataDurum(kontrolUserName, lblYildiz4);
                hataDurum(kontrolPassword, lblYildiz5);
                MessageBox.Show("İşaretli Alanlar Boş Bırakılamaz");
            }
        }
        /// <summary>
        /// zorunlu alanlara bilgi girilmediginda yildizlarin rengi kirmizi olan fonksiyon
        /// </summary>
        /// <param name="kontrol"></param>
        /// <param name="yildiz"></param>
        private void hataDurum(bool kontrol,Label yildiz)
        {
            if(!kontrol)
            {
                yildiz.ForeColor = Color.Red;
            }
            else
            {
                yildiz.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// girilen verilerin eksiksiz olup olmadigini kontrol eden fonksiyon
        /// </summary>
        /// <param name="txtbx"></param>
        /// <returns></returns>
        private bool girdiKontrol(TextBox txtbx)
        {
            int boslukSayac = 0;
            for (int i = 0; i < txtbx.Text.Length; i++)
            {
                if (txtbx.Text[i].Equals(' '))
                {
                    boslukSayac++;
                }
            }
            if (txtbx.Text.Length == boslukSayac)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// butona tiklandiginda guncelleme yapan fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, btnGuncelle.Name, CustomerNesnesi.userName);
            }
            guncelleMusteri();
        }
        /// <summary>
        /// musteri guncelleyen fonksiyon
        /// </summary>
        private void guncelleMusteri()
        {
            userNesnesi = new SQL_User();
            bool kontrolName = girdiKontrol(txtName);
            bool kontrolAdres = girdiKontrol(txtAddress);
            bool kontrolEmail = girdiKontrol(txtEmail);
            bool kontrolUserName = girdiKontrol(txtUserName);
            bool kontrolPassword = girdiKontrol(txtPassword);
            if (kontrolName && kontrolAdres && kontrolEmail && kontrolUserName && kontrolPassword)
            {
                if (userNesnesi.KayitMusteri(txtUserName.Text) && userNesnesi.kayitAdmin(txtUserName.Text))
                {
                    Customer.updateCustomer(this);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bu Kullanıcı Adı Daha Önce Alınmış. Başka Bir Bullanıcı Adı Girin");
                }
            }
            else
            {
                hataDurum(kontrolName, lblYildiz1);
                hataDurum(kontrolAdres, lblYildiz2);
                hataDurum(kontrolEmail, lblYildiz3);
                hataDurum(kontrolUserName, lblYildiz4);
                hataDurum(kontrolPassword, lblYildiz5);
                MessageBox.Show("İşaretli Alanlar Boş Bırakılamaz");
            }
        }
    }
}
