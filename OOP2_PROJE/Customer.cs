using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OOP2_PROJE
{
    class Customer:User
    {
        private static Customer singletonNesnesi=null;
        LogKayit kayit_islemi = new LogKayit();

        public string ID { get => id; set => id = value; }
        public String Name { get => name; set => name = value; }
        public String Address { get => address; set => address = value; }
        public String Email { get => email; set => email = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        /// <summary>
        /// Customer constructor
        /// </summary>
        private Customer()
        {

        }
        /// <summary>
        /// customer singleton fonksiyonu
        /// </summary>
        public static Customer customer
        {
            get
            {
                if(singletonNesnesi==null)
                {
                    singletonNesnesi = new Customer();
                }
                return singletonNesnesi;
            }
        }
        /// <summary>
        /// musteri bilgilerini FormProfilim ekraninda gosteren fonksiyon
        /// </summary>
        public void printCustomerDetails()
        {
            if (singletonNesnesi != null)
            {
                FormProfilim formProfilim_obj = new FormProfilim();
                formProfilim_obj.lblProfilAdi.Text = singletonNesnesi.name;
                formProfilim_obj.lblProfilAdres.Text = singletonNesnesi.address;
                formProfilim_obj.lblProfilEmail.Text = singletonNesnesi.email;
                formProfilim_obj.lblProfilKullaniciAdi.Text = singletonNesnesi.userName;
                formProfilim_obj.Show();
            }
        }
        /// <summary>
        /// musteri kayit fonksiyonu
        /// </summary>
        /// <param name="formKayitOl_obj"></param>
        public static void saveCustomer(FormKayitOl formKayitOl_obj)
        {
            Customer customer = new Customer();
            SQL_User sqlUser = new SQL_User();

            customer.name = formKayitOl_obj.txtName.Text;
            customer.address = formKayitOl_obj.txtAddress.Text;
            customer.email = formKayitOl_obj.txtEmail.Text;
            customer.userName = formKayitOl_obj.txtUserName.Text;
            customer .password= formKayitOl_obj.txtPassword.Text;

            sqlUser.saveCustomer(customer);
            
            formKayitOl_obj.Close();
            MessageBox.Show("Kayıt Oldunuz", "Close Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// musteri bilgi guncelleme fonksiyonu
        /// </summary>
        /// <param name="formKayitOl_obj"></param>
        public static void updateCustomer(FormKayitOl formKayitOl_obj)
        {
            Customer customer = Customer.customer;
            SQL_User sqlUser = new SQL_User();
            
            customer.name = formKayitOl_obj.txtName.Text;
            customer.address = formKayitOl_obj.txtAddress.Text;
            customer.email = formKayitOl_obj.txtEmail.Text;
            customer.userName = formKayitOl_obj.txtUserName.Text;
            customer.password = formKayitOl_obj.txtPassword.Text;

            sqlUser.updateCustomer(customer);

            formKayitOl_obj.Close();
            MessageBox.Show("Güncelleme Yapıldı", "Close Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// musteri tarafindan tiklanan butonlarin log kayitlarini tutan fonksiyon
        /// </summary>
        /// <param name="form_obj"></param>
        /// <param name="butonAdi"></param>
        /// <param name="kullaniciAdi"></param>
        public void logCustomer(Form form_obj, string butonAdi, string kullaniciAdi)
        {
            string tiklanmaZamani= DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();

            kayit_islemi.kayit(form_obj, butonAdi, tiklanmaZamani, kullaniciAdi);
        }
        /// <summary>
        /// musterinin satin aldigi butun urunleri gosteren fonksiyon
        /// </summary>
        public void printCustomerPurchases()
        {
            FormSiparisler siparisler = new FormSiparisler();
            siparisler.dgvDoldur();
            siparisler.Show();
        }
    }
}
