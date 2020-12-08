using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OOP2_PROJE
{
    class AdminUser:User
    {
        LogKayit kayit_islemi = new LogKayit();
        private static AdminUser singletonNesnesi = null;
        public string ID { get => ID; set => ID = value; }
        public String Name { get => name; set => name = value; }
        public String Address { get => address; set => address = value; }
        public String Email { get => email; set => email = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        /// <summary>
        /// AdminUser constructor
        /// </summary>
        private AdminUser()
        {

        }
        /// <summary>
        /// singleton fonksiyonu
        /// </summary>
        public static AdminUser adminUser
        {
            get
            {
                if (singletonNesnesi == null)
                {
                    singletonNesnesi = new AdminUser();
                }
                return singletonNesnesi;
            }
        }
        /// <summary>
        /// yeni eklenen admini ekleyen fonksiyon
        /// </summary>
        /// <param name="formEkleAdmin_obj"></param>
        public static void addAdmin(FormEkleAdmin formEkleAdmin_obj)
        {
            AdminUser admin = AdminUser.adminUser;
            admin.name = formEkleAdmin_obj.txtName.Text;
            admin.address = formEkleAdmin_obj.txtAddress.Text;
            admin.email = formEkleAdmin_obj.txtEmail.Text;
            admin.userName = formEkleAdmin_obj.txtUserName.Text;
            admin.password = formEkleAdmin_obj.txtPassword.Text;
            SQL_User user = new SQL_User();
            user.saveAdmin(admin);
            formEkleAdmin_obj.Close();

            MessageBox.Show("Kayıt İşlemi Tamamlandı", "Close Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// admin tarafindan urun ekleme yapan fonksiyon
        /// </summary>
        /// <param name="product"></param>
        public void addNewItem(Product product)
        {
            string tip = product.GetType().ToString();
            if (tip == "OOP2_PROJE.Book")
            {
                addNewBook((Book)product);
            }
            else if (tip == "OOP2_PROJE.Magazine")
            {
                addNewMagaxine((Magazine)product);
            }
            else if (tip == "OOP2_PROJE.MusicCD")
            {
                addNewMusicCD((MusicCD)product);
            }
        }
        /// <summary>
        /// kitap eklemek icin kullanilan fonksiyon 
        /// </summary>
        /// <param name="bookNesnesi"></param>
        private void addNewBook(Book bookNesnesi)
        {
            SQLkitap kitap = new SQLkitap();
            kitap.kitaplariSQLeEkle(bookNesnesi);
        }
        /// <summary>
        /// dergi eklemek icin kullanilan fonksiyon
        /// </summary>
        /// <param name="magazineNesnesi"></param>
        private void addNewMagaxine(Magazine magazineNesnesi)
        {
            SQLdergi dergi = new SQLdergi();
            dergi.dergileriSQLeEkle(magazineNesnesi);
        }
        /// <summary>
        /// muzik cd eklemek icin kullanilan fonksiyon
        /// </summary>
        /// <param name="musicCDnesnesi"></param>
        private void addNewMusicCD(MusicCD musicCDnesnesi)
        {
            SQLmusicCd muzikCd = new SQLmusicCd();
            muzikCd.MusicCdSQLeEkle(musicCDnesnesi);
        }
        /// <summary>
        /// admin tarafindan tiklanan butonlarin log kayitlarini tutan fonksiyon
        /// </summary>
        /// <param name="form_obj"></param>
        /// <param name="butonAdi"></param>
        /// <param name="kullaniciAdi"></param>
        public void logAdmin(Form form_obj, string butonAdi, string kullaniciAdi)
        {
            string tiklanmaZamani = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();

            kayit_islemi.adminLogKayit(form_obj, butonAdi, tiklanmaZamani, kullaniciAdi);
        }

    }
}
