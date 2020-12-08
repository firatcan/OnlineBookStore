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
    public partial class FormEkleAdmin : Form
    {
        SqlConnection bagla = new SqlConnection("Data Source=.;Initial Catalog=BookStore;Integrated Security=true");
        SQL_User userNesnesi;
        /// <summary>
        /// FormEkleAdmin constructor
        /// </summary>
        public FormEkleAdmin()
        {
            InitializeComponent();
            tabloGoster();
        }
        /// <summary>
        /// butona tiklandiginda eklenen adminin bilgileri girildikten sonra kayit eden fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKayitOlOnay_Click(object sender, EventArgs e)
        {
            AdminUser adminUserNesnesi = FormAnaEkran.AdminUserNesnesi;
            adminUserNesnesi.logAdmin(this, btnKayitOlOnay.Name, adminUserNesnesi.userName);
            kayitOlAdmin();
        }
        /// <summary>
        /// girilen bilgilerin kontrolunun yapildigi fonksiyon
        /// bu fonksiyonda girilen kullanici adinin durumu kontrol ediliyor
        /// eger bu kullanici adi baska bir kullanici tarafindan alindiysa girilen kullanici adinin degistirilmesi isteniyor
        /// </summary>
        private void kayitOlAdmin()
        {
            userNesnesi = new SQL_User();
            bool kontrolName = girdiKontrol(txtName);
            bool kontrolAdres = girdiKontrol(txtAddress);
            bool kontrolEmail = girdiKontrol(txtEmail);
            bool kontrolUserName = girdiKontrol(txtUserName);
            bool kontrolPassword = girdiKontrol(txtPassword);
            if (kontrolName && kontrolAdres && kontrolEmail && kontrolUserName && kontrolPassword)
            {
                if (userNesnesi.kayitAdmin(txtUserName.Text) && userNesnesi.kayitAdmin(txtUserName.Text))
                {
                    AdminUser.addAdmin(this);
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
        /// girilen bilgilerde hata varsa textboxlarin yanindaki yildizlar kirmizi oluyor
        /// </summary>
        /// <param name="kontrol"></param>
        /// <param name="yildiz"></param>
        private void hataDurum(bool kontrol, Label yildiz)
        {
            if (!kontrol)
            {
                yildiz.ForeColor = Color.Red;
            }
            else
            {
                yildiz.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// bilgilerin girilmesi zorunlu alanlarin dolulugunu kontrol eden fonksiyon
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
        /// silmek istediginiz uyeyi tablodan sectiginizde silen fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DialogResult res = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Confirmation", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string silinecekVeri = dgvAdmin.SelectedCells[0].Value.ToString();
                bagla.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM TableAdmin WHERE adminID= '" + silinecekVeri + "'", bagla);

                komut.ExecuteNonQuery();
                bagla.Close();
                tabloGoster();
            }
        }
        /// <summary>
        /// verileri dgwAdmin datagridview tablosunda gosteren fonksiyon
        /// </summary>
        private void tabloGoster()
        {
            userNesnesi = new SQL_User();
            DataTable tablo = new DataTable();
            userNesnesi.adminGoster(tablo);
            dgvAdmin.DataSource = tablo;
        }
        /// <summary>
        /// FormEkleAdmin Load fonksiyonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEkleAdmin_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
