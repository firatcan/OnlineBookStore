using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace OOP2_PROJE
{/// <summary>
/// sql_veri sinifindan inherit eder sqldeki user islemlerini yapar
/// </summary>
    class SQL_User:SQL_Veri
    {
        Customer customerNesnesi;
        AdminUser adminUserNesnesi;
        FormAnaEkran form1AnaEkran_obj = FormAnaEkran.formAnaEkran;
        public int kullaniciDurumu = 0;
        /// <summary>
        /// giris yapan musteriyi karsilastirir
        /// </summary>
        /// <param name="kullaniciAdi"></param>
        /// <param name="sifre"></param>
        /// <returns></returns>
        public bool GirisYapanMusteri(string kullaniciAdi, string sifre)
        {
            bagla.Open();
            komut = new SqlCommand("SELECT * FROM TableCustomer WHERE customerUserName='" + kullaniciAdi + "' and customerPassword='"+ sifre + "'", bagla);
            SqlDataReader veriOku = komut.ExecuteReader();
            if (veriOku.Read())
            {
                customerNesnesi = Customer.customer;
                FormAnaEkran.CustomerNesnesi = customerNesnesi;
                customerNesnesi.ID = veriOku["customerID"].ToString();
                customerNesnesi.name = veriOku["customerName"].ToString();
                customerNesnesi.Email = veriOku["customerEmail"].ToString();
                customerNesnesi.Address = veriOku["customerAddress"].ToString();
                customerNesnesi.userName = veriOku["customerUserName"].ToString();
                customerNesnesi.Password = veriOku["customerPassword"].ToString();
                kullaniciDurumu = 0;
                form1AnaEkran_obj.linklblCikisYap.Visible = true;
                bagla.Close();

                return true;
            }
            bagla.Close();
            return false;
        }
        /// <summary>
        /// giris yapan admini karsilastirir sql tabaniyla
        /// </summary>
        /// <param name="kullaniciAdi"></param>
        /// <param name="sifre"></param>
        /// <returns></returns>
        public bool GirisYapanAdmin(string kullaniciAdi, string sifre)
        {
            bagla.Close();
            bagla.Open();
            komut = new SqlCommand("SELECT * FROM TableAdmin WHERE adminUserName='" + kullaniciAdi + "' and adminPassword='" + sifre + "'", bagla);
            VeriOku = komut.ExecuteReader();
            if (VeriOku.Read())
            {
                adminUserNesnesi = AdminUser.adminUser;
                FormAnaEkran.AdminUserNesnesi = adminUserNesnesi;
                adminUserNesnesi.id = VeriOku["adminID"].ToString();
                adminUserNesnesi.name = VeriOku["adminName"].ToString();
                adminUserNesnesi.email = VeriOku["adminEmail"].ToString();
                adminUserNesnesi.address = VeriOku["adminAddress"].ToString();
                adminUserNesnesi.userName = VeriOku["adminUserName"].ToString();
                adminUserNesnesi.password = VeriOku["adminPassword"].ToString();
                kullaniciDurumu = 1;
                form1AnaEkran_obj.linklblCikisYap.Visible = true;
                bagla.Close();

                return true;
            }
            bagla.Close();
            return false;
        }
        /// <summary>
        /// ismin benzersiz olmasini kontrol eder
        /// </summary>
        /// <param name="kullaniciAdi"></param>
        /// <returns></returns>
        public bool KayitMusteri(string kullaniciAdi)
        {
            bagla.Open();
            komut = new SqlCommand("SELECT * FROM TableCustomer WHERE customerUserName='" + kullaniciAdi + "'", bagla);
            SqlDataReader veriOku = komut.ExecuteReader();
            if (veriOku.Read())
            {
                if (FormAnaEkran.CustomerNesnesi != null)
                {
                    if (FormAnaEkran.CustomerNesnesi.id == veriOku["customerID"].ToString())
                    {
                        bagla.Close();
                        return true;
                    }
                }
                bagla.Close();
                return false;
            }
            bagla.Close();
            return true;
        }
        /// <summary>
        /// ismin benzersiz olmasini kontrol eder
        /// </summary>
        /// <param name="kullaniciAdi"></param>
        /// <returns></returns>
        public bool kayitAdmin(string kullaniciAdi)
        {
            bagla.Open();
            komut = new SqlCommand("SELECT * FROM TableAdmin WHERE adminUserName='" + kullaniciAdi+ "'", bagla);
            SqlDataReader veriOku = komut.ExecuteReader();
            if (veriOku.Read())
            {
                if(FormAnaEkran.CustomerNesnesi!=null)
                {
                    if(FormAnaEkran.CustomerNesnesi.id==veriOku["adminID"].ToString())
                    {
                        bagla.Close();
                        return true;
                    }
                }
                bagla.Close();
                return false;
            }
            bagla.Close();
            return true;
        }
        /// <summary>
        /// musteri kaydeder
        /// </summary>
        /// <param name="customer"></param>
        public void saveCustomer(Customer customer)
        {
            SqlConnection bagla = new SqlConnection("Data Source=.;Initial Catalog=BookStore;Integrated Security=true");
            bagla.Open();
            SqlCommand komut;
            //SqlDataReader veriOku;
            komut = new SqlCommand("INSERT INTO TableCustomer(customerName, customerAddress, customerEmail, customerUserName, customerPassword,isAdmin) " +
                "VALUES('" + customer.name + "','" + customer.address + "','" + customer.email + "','" + customer.userName + "','" + customer.password + "',0);", bagla);
            
            komut.ExecuteNonQuery();
            bagla.Close();
        }
        /// <summary>
        /// admin kaydeder
        /// </summary>
        /// <param name="adminUser"></param>
        public void saveAdmin(AdminUser adminUser)
        {
            SqlConnection bagla = new SqlConnection("Data Source=.;Initial Catalog=BookStore;Integrated Security=true");
            bagla.Open();
            SqlCommand komut;
            //SqlDataReader veriOku;
            komut = new SqlCommand("INSERT INTO TableAdmin(adminName, adminAddress, adminEmail, adminUserName, adminPassword,isAdmin) " +
                "VALUES('" + adminUser.name + "','" + adminUser.address + "','" + adminUser.email + "','" + adminUser.userName + "','" + adminUser.password + "',1);", bagla);

            komut.ExecuteNonQuery();
            bagla.Close();
        }
        /// <summary>
        /// admin siler
        /// </summary>
        /// <param name="silinecekVeri"></param>
        public void deleteAdmin(string silinecekVeri)
        {
            bagla.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM TableAdmin WHERE adminID= '" + silinecekVeri + "'", bagla);

            komut.ExecuteNonQuery();
            bagla.Close();
        }
        /// <summary>
        /// musteri siler
        /// </summary>
        /// <param name="silinecekVeri"></param>
        public void deleteCustomer(string silinecekVeri)
        {
            bagla.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM TableAdmin WHERE adminID= '" + silinecekVeri + "'", bagla);

            komut.ExecuteNonQuery();
            bagla.Close();
        }
        /// <summary>
        /// adminleri gosterir
        /// </summary>
        /// <param name="tablo"></param>
        public void adminGoster(DataTable tablo)
        {
            bagla.Open();
            SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM TableAdmin", bagla);
            adap.Fill(tablo);
            bagla.Close();
        }
        /// <summary>
        /// musteri gunceller
        /// </summary>
        /// <param name="customer"></param>
        public void updateCustomer(Customer customer)
        {
            SqlConnection bagla = new SqlConnection("Data Source=.;Initial Catalog=BookStore;Integrated Security=true");
            bagla.Open();
            SqlCommand komut;
            //SqlDataReader veriOku;
            komut = new SqlCommand("UPDATE TableCustomer SET customerName='" + customer.name + "'," +
                " customerAddress='" + customer.address + "', customerEmail='" + customer.email + "'" +
                ", customerUserName='" + customer.userName + "', customerPassword='" + customer.password + "'" +
                ",isAdmin=0 WHERE customerID='"+customer.id+"'", bagla);

            komut.ExecuteNonQuery();
            bagla.Close();
            customer.printCustomerDetails();
        }
        /// <summary>
        /// sifremi unuttum fonksiyonu
        /// </summary>
        /// <param name="kullaniciAdi"></param>
        /// <param name="mail"></param>
        /// <param name="sifre"></param>
        /// <returns></returns>
        public bool mailDonder(string kullaniciAdi, ref string mail, ref string sifre)
        {
            bagla.Open();
            komut = new SqlCommand("SELECT * FROM TableCustomer WHERE customerUserName='" + kullaniciAdi + "'", bagla);
            SqlDataReader veriOku = komut.ExecuteReader();
            if (veriOku.Read())
            {
                mail = veriOku["customerEmail"].ToString();
                sifre = veriOku["customerPassword"].ToString();
                bagla.Close();
                return true;
            }
            else
            {
                bagla.Close();
                bagla.Open();
                komut = new SqlCommand("SELECT * FROM TableAdmin WHERE adminUserName='" + kullaniciAdi + "'", bagla);
                veriOku = komut.ExecuteReader();
                if (veriOku.Read())
                {
                    mail = veriOku["adminEmail"].ToString();
                    sifre = veriOku["adminPassword"].ToString();
                    bagla.Close();
                    return true;
                }
            }
            bagla.Close();
            return false;
        }
    }
}
