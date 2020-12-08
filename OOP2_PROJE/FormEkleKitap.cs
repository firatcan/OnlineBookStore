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
using System.IO;
using HtmlAgilityPack;
using System.Net;
using System.Drawing.Imaging;

namespace OOP2_PROJE
{
    public partial class FormEkleKitap : Form
    {
        SqlConnection bagla = new SqlConnection("Data Source=.;Initial Catalog=BookStore;Integrated Security=true");
        SQLkitap kitap = new SQLkitap();
        Book bookNesnesi = new Book();
        int dgwsirasi = 0;
        string gecicifiyat;
        /// <summary>
        /// FormEkleKitap constructor
        /// </summary>
        public FormEkleKitap()
        {
            InitializeComponent();
            tabloGoster();
            pbxKitapFotograf.ImageLocation = @"KitapFotograf\kitapFotografVarsayilan.jpg";
        }
        /// <summary>
        /// admin tarafindan butona tiklandiginda kitap ekleyen fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            AdminUser adminUserNesnesi = FormAnaEkran.AdminUserNesnesi;
            adminUserNesnesi.logAdmin(this, btnKitapEkle.Name, adminUserNesnesi.userName);
            KitapFotoAl();
            nesneDoldur();
            adminUserNesnesi.addNewItem(bookNesnesi);
            //kitap.kitaplariSQLeEkle(bookNesnesi);
            tabloGoster();
        }
        /// <summary>
        /// girilen bilgileri book nesnesine atan fonksiyon
        /// </summary>
        private void nesneDoldur()
        {
            bookNesnesi.Name = txtAdi.Text;
            bookNesnesi.Price = double.Parse(txtFiyat.Text);
            bookNesnesi.IsbnNumber = txtIsbn.Text;
            bookNesnesi.Author = txtYazar.Text;
            bookNesnesi.Publisher = txtYayin.Text;
            bookNesnesi.Page = int.Parse(txtSayfa.Text);
            bookNesnesi.Cover_page_picture = pbxKitapFotograf.ImageLocation.ToString();
            bookNesnesi.TypeOfBook = cmbxKitapTur.Text;
        }
        /// <summary>
        /// eklenecek olan kitabin fotografini alan fonksiyon
        /// </summary>
        private void KitapFotoAl()
        {
            OpenFileDialog dosyaAc = new OpenFileDialog();

            string yol;
            dosyaAc.Filter = "png Files |*.png| jpg Files|*.jpg";
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                yol = dosyaAc.FileName;
                Bitmap bitti = new Bitmap(yol);

                SaveFileDialog dosyaKaydet = new SaveFileDialog();
                SQLkitap cek = new SQLkitap();
                cek.kitaplariSQLdenCek();
                dosyaKaydet.FileName = @"KitapFotograf\kitap" + SQLkitap.veriAdetSay + ".png";
                pbxKitapFotograf.ImageLocation = dosyaKaydet.FileName;
                bitti.Save(dosyaKaydet.FileName);
            }
        }
        /// <summary>
        /// silmek istediginiz urunu tablodan sectidiginizde silen fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvKitapGoster_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DialogResult res = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Confirmation", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string silinecekVeri = dgvKitapGoster.SelectedCells[0].Value.ToString();
                bagla.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM TableBook WHERE bookID= '" + silinecekVeri + "'", bagla);

                komut.ExecuteNonQuery();
                bagla.Close();
                tabloGoster();
            }
        }
        /// <summary>
        /// dgvkitapGoster datagridview tablosunda gosteren fonksiyon
        /// </summary>
        private void tabloGoster()
        {
            //data grid view tablosunda verileri gostermek icin
            DataTable tablo = new DataTable();
            kitap.kitapGoster(tablo);
            dgvKitapGoster.DataSource = tablo;
        }
        /// <summary>
        /// txtSayfa textine sadece int veri girmesini saglayan fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSayfa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// txtFiyay textine int veri girmesini saglayan fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// FormEkleKitap Load fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEkleKitap_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            dgwDr.ColumnCount = 7;

            dgwDr.Columns[0].Name = "ADI";
            dgwDr.Columns[1].Name = "Fiyat";
            dgwDr.Columns[2].Name = "yazar";
            dgwDr.Columns[3].Name = "yayinci";
            dgwDr.Columns[4].Name = "sayfa";
            dgwDr.Columns[5].Name = "image";
            dgwDr.Columns[6].Name = "konu type";

            DataGridViewImageColumn resim11 = new DataGridViewImageColumn();
            dgwDr.Columns.Add(resim11);
            resim11.ImageLayout = DataGridViewImageCellLayout.Stretch;

        }
        /// <summary>
        /// butona tiklandiginda DR'den veri ceken fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVeriCekKitapDr_Click(object sender, EventArgs e)
        {
            AdminUser adminUserNesnesi = FormAnaEkran.AdminUserNesnesi;
            adminUserNesnesi.logAdmin(this, btnVeriCekKitapDr.Name, adminUserNesnesi.userName);
            Random rastgele = new Random();
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.GetEncoding(1254);
            Uri url = new Uri("https://www.dr.com.tr/CokSatanlar/Kitap#/page=2/sort=groups.group.displayorder,asc/categoryid=0/clog=4020/parentId=0/price=-1,-1");
            client.Encoding = Encoding.UTF8;

            

            Encoding.GetEncoding("iso-8859-9");

            var html1 = client.DownloadData(url);
            string html = Encoding.UTF8.GetString(html1);

            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(html);
            HtmlNodeCollection basliklar = dokuman.DocumentNode.SelectNodes("//a[@href]");

            HtmlNodeCollection sayfa = dokuman.DocumentNode.SelectNodes("//a[@title]");

            HtmlNodeCollection resim = dokuman.DocumentNode.SelectNodes("//img[@class='lazyload']");

            HtmlNodeCollection ad = dokuman.DocumentNode.SelectNodes("//div[@class='cell']");
            HtmlNodeCollection fiyat = dokuman.DocumentNode.SelectNodes("//span[@class='old-price']");
            HtmlNodeCollection yazar = dokuman.DocumentNode.SelectNodes("//a[@class='who']");
            HtmlNodeCollection yayinci = dokuman.DocumentNode.SelectNodes("//a[@class='who mb10']");
            HtmlNodeCollection tipi = dokuman.DocumentNode.SelectNodes("//div[@class='cell']");
            //HtmlNodeCollection sayfa=dokuman.DocumentNode.SelectNodes("//div[@style]");

            string adi, duzeltme, tpi;

          

            

            for (int i = 0; i < ad.Count; i++)
            {
                gecicifiyat = "";
                adi = ad[i].Attributes["data-name"].Value;
                adi= yerineKoy(adi);
             
                dgwDr.Rows.Add(adi.ToString());

                var fiyati = fiyat[i];
                for (int t = 0; t < fiyati.InnerLength-3; t++)
                {
                    gecicifiyat += fiyati.InnerText[t];
                }
                dgwDr.Rows[i].Cells[1].Value = gecicifiyat;

                var yazari = yazar[i];
                duzeltme = yerineKoy(yazari.InnerText);
                dgwDr.Rows[i].Cells[2].Value = duzeltme;

                var yayincisi = yayinci[i];
                duzeltme = yerineKoy(yayincisi.InnerText);
                dgwDr.Rows[i].Cells[3].Value = duzeltme;

                dgwDr.Rows[i].Cells[4].Value =rastgele.Next(31,738) ;


                var imge = resim[i].Attributes["data-src"].Value;

                tpi = tipi[i].Attributes["data-category"].Value;
                tpi = yerineKoy(tpi);
                dgwDr.Rows[i].Cells[6].Value = tpi.ToString();

                imageİndirNet dmage = new imageİndirNet(imge);
                dmage.Download();
                try
                { dmage.SaveImage("D:\\Resimadi" + i + ".jpg", ImageFormat.Jpeg); }
                catch (Exception )
                {
                    dmage.SaveImage("D:\\Resimadi" + i + ".png", ImageFormat.Png);
                }

                try
                {
                    

                    dgwDr.Rows[i].Cells[7].Value = Image.FromFile("D:\\Resimadi" + i + ".jpg");

                    dgwDr.Rows[i].Cells[5].Value = "D:\\Resimadi" + i + ".jpg";
                }
                catch (Exception )
                {
                    dgwDr.Rows[i].Cells[7].Value = Image.FromFile("D:\\Resimadi" + i + ".png");
                }

            }
            var img = resim[8].Attributes["data-src"].Value;

        }
        /// <summary>
        /// secilen nesneyi bulan fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgwDr_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgwsirasi = e.RowIndex;
        }
        /// <summary>
        /// butona tiklandiginda DR'den kitap ekleyen fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKitapEkleDR_Click(object sender, EventArgs e)
        {
            AdminUser adminUserNesnesi = FormAnaEkran.AdminUserNesnesi;
            adminUserNesnesi.logAdmin(this, btnKitapEkleDR.Name, adminUserNesnesi.userName);
            Bitmap bitti = new Bitmap("D:\\Resimadi" + dgwsirasi+ ".jpg");
            SaveFileDialog dosyaKaydet = new SaveFileDialog();
            SQLkitap cek = new SQLkitap();
            cek.kitaplariSQLdenCek();
            bookNesnesi.Name = dgwDr.Rows[dgwsirasi].Cells[0].Value.ToString();
            bookNesnesi.IsbnNumber = txtIsbnDR.Text;
            dosyaKaydet.FileName = @"KitapFotograf\kitap" + (SQLkitap.sonid+1) + ".png";
            bitti.Save(dosyaKaydet.FileName);

            bookNesnesi.Price = double.Parse(dgwDr.Rows[dgwsirasi].Cells[1].Value.ToString());
            bookNesnesi.IsbnNumber = txtIsbnDR.Text;
            bookNesnesi.Author = dgwDr.Rows[dgwsirasi].Cells[2].Value.ToString();
            bookNesnesi.Publisher = dgwDr.Rows[dgwsirasi].Cells[3].Value.ToString();
            bookNesnesi.Page = int.Parse(dgwDr.Rows[dgwsirasi].Cells[4].Value.ToString());
            bookNesnesi.Cover_page_picture = "KitapFotograf\\kitap" + (SQLkitap.sonid + 1) + ".png";
            bookNesnesi.ImageLocation= "KitapFotograf\\kitap" + (SQLkitap.sonid + 1) + ".png";
            bookNesnesi.TypeOfBook = cmbKitapDR.Text;
            SQLkitap.sonid++;
            adminUserNesnesi.addNewItem(bookNesnesi);
            //kitap.kitaplariSQLeEkle(bookNesnesi);
            tabloGoster();

        }
        /// <summary>
        /// hatali harfleri duzelten fonksiyon
        /// </summary>
        /// <param name="gelenText"></param>
        /// <returns></returns>
        public string yerineKoy(string gelenText)
        {
            gelenText = gelenText.Replace("&#214;", " Ö").Replace("&#252;", "ü").Replace("&#246;","ö").Replace("&#199;"," Ç").Replace("&#231;","ç").Replace("&#220;"," Ü").Replace("&#39;", "'");
            return gelenText;
        }

    }
}
