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
using HtmlAgilityPack;
using System.Drawing.Imaging;
using System.Net;

namespace OOP2_PROJE
{
    public partial class FormEkleDergi : Form
    {
        string gecicifiyat;
        int dgwsirasi = 0;
        SqlConnection bagla = new SqlConnection("Data Source=.;Initial Catalog=BookStore;Integrated Security=true");
        SQLdergi dergi = new SQLdergi();
        Magazine magazineNesnesi = new Magazine();
        /// <summary>
        /// FormEkleDergi constructor
        /// </summary>
        public FormEkleDergi()
        {
            InitializeComponent();
            tabloGoster();
        }
        /// <summary>
        /// admin tarafindan butona tiklandiginda dergi ekleyen fonksiyon 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDergiEkle_Click(object sender, EventArgs e)
        {
            AdminUser adminUserNesnesi = FormAnaEkran.AdminUserNesnesi;
            adminUserNesnesi.logAdmin(this, btnDergiEkle.Name, adminUserNesnesi.userName);
            DergiFotoAl();
            nesneDoldur();
            adminUserNesnesi.addNewItem(magazineNesnesi);
            //dergi.dergileriSQLeEkle(magazineNesnesi);
            tabloGoster();
        }
        /// <summary>
        /// girilen bilgileri magazine nesnesine atan fonksiyon
        /// </summary>
        private void nesneDoldur()
        {
            magazineNesnesi.Name = txtAdi.Text;
            magazineNesnesi.Price = double.Parse(txtFiyat.Text);
            magazineNesnesi.Issue = txtSayi.Text;
            magazineNesnesi.Type = (Magazine.typeOfMagazine)cmbxTur.SelectedIndex;
            magazineNesnesi.ImageLocation = pbxDergiFotograf.ImageLocation;
        }
        /// <summary>
        /// eklenecek olan derginin fotografini alan fonksiyon
        /// </summary>
        private void DergiFotoAl()
        {
            OpenFileDialog dosyaAc = new OpenFileDialog();

            string yol;
            dosyaAc.Filter = "png Files |*.png| jpg Files|*.jpg";
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                yol = dosyaAc.FileName;
                Bitmap bitti = new Bitmap(yol);
                SaveFileDialog dosyaKaydet = new SaveFileDialog();
                SQLdergi cek = new SQLdergi();
                cek.dergileriSQLdenCek();
                dosyaKaydet.FileName = @"DergiFotograf\dergi" + SQLdergi.idSayac + ".png";
                pbxDergiFotograf.ImageLocation = dosyaKaydet.FileName;
                bitti.Save(dosyaKaydet.FileName);
            }
        }
        /// <summary>
        /// dgwDergiGoster datagridview tablosunda verileri gosteren fonksiyon
        /// </summary>
        private void tabloGoster()
        {
            //data grid view tablosunda verileri gostermek icin
            DataTable tablo = new DataTable();
            dergi.dergiGoster(tablo);
            dgvDergiGoster.DataSource = tablo;
        }
        /// <summary>
        /// silmek istediginiz urunu tablodan sectiginizde silen fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDergiGoster_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DialogResult res=MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Confirmation", MessageBoxButtons.YesNo);
            if(res==DialogResult.Yes)
            {
                string silinecekVeri = dgvDergiGoster.SelectedCells[0].Value.ToString();
                bagla.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM TableMagazine WHERE magazineID= '" + silinecekVeri + "'", bagla);

                komut.ExecuteNonQuery();
                bagla.Close();
                tabloGoster();
            }
        }
        /// <summary>
        /// txtSayi textine sadece int veri girmesini saglayan fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtKonu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// butona tiklandiginda DR'den veri ekleyen fonksiyon 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDergiEkleDR_Click(object sender, EventArgs e)
        {
            AdminUser adminUserNesnesi = FormAnaEkran.AdminUserNesnesi;
            adminUserNesnesi.logAdmin(this, btnDergiEkleDR.Name, adminUserNesnesi.userName);
            Bitmap bitti = new Bitmap("D:\\dergiadi" + dgwsirasi + ".jpg");
            SaveFileDialog dosyaKaydet = new SaveFileDialog();
            SQLdergi cek = new SQLdergi();
            cek.dergileriSQLdenCek();
            magazineNesnesi.Name = dgwDr.Rows[dgwsirasi].Cells[0].Value.ToString();
            dosyaKaydet.FileName = @"DergiFotograf\dergi" + (SQLdergi.sonid+1)+ ".png";
            bitti.Save(dosyaKaydet.FileName);
            
            magazineNesnesi.Price = double.Parse(dgwDr.Rows[dgwsirasi].Cells[1].Value.ToString());
            magazineNesnesi.Issue = txtSayi1.Text;
            magazineNesnesi.ImageLocation = "DergiFotograf\\dergi" + (SQLdergi.sonid+1) + ".png";

            magazineNesnesi.Type = (Magazine.typeOfMagazine)cmbDergiTur.SelectedIndex;
            SQLdergi.sonid++;

            adminUserNesnesi.addNewItem(magazineNesnesi);
            //dergi.dergileriSQLeEkle(magazineNesnesi);
            tabloGoster();


        }
        /// <summary>
        /// butona tiklandiginda DR'den veri ceken fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVeriCekDergiDr_Click(object sender, EventArgs e)
        {
            AdminUser adminUserNesnesi = FormAnaEkran.AdminUserNesnesi;
            adminUserNesnesi.logAdmin(this, btnVeriCekDergiDr.Name, adminUserNesnesi.userName);
            WebClient client = new WebClient();
            Uri url = new Uri("https://www.dr.com.tr/Search?q=dergi#/page=1/sort=relevance,desc/categoryid=0/parentId=0/lg=undefined/price=-1,-1/ldir=h");
            client.Encoding = Encoding.UTF8;

            var html1 = client.DownloadData(url);
            string html = Encoding.UTF8.GetString(html1);

            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(html);
            //HtmlNodeCollection basliklar = dokuman.DocumentNode.SelectNodes("//a[@href]");


            HtmlNodeCollection resim = dokuman.DocumentNode.SelectNodes("//img");

            HtmlNodeCollection ad = dokuman.DocumentNode.SelectNodes("//img[@src]");

            HtmlNodeCollection fiyat = dokuman.DocumentNode.SelectNodes("//span[@class='old-price']");

            DataGridViewImageColumn resim11 = new DataGridViewImageColumn();
            dgwDr.Columns.Add(resim11);

            resim11.ImageLayout = DataGridViewImageCellLayout.Stretch;

            
            for (int i = 0; i < fiyat.Count; i++)
            {
                gecicifiyat = "";
                var adi = ad[i + 1].Attributes["alt"].Value;
                adi = yerineKoy(adi);
                dgwDr.Rows.Add(adi.ToString());

                var fiyati = fiyat[i];
                for (int t = 0; t < fiyati.InnerLength - 3; t++)
                {
                    gecicifiyat += fiyati.InnerText[t];
                }
                dgwDr.Rows[i].Cells[1].Value = gecicifiyat;



                var imge = resim[i + 1].Attributes["src"].Value;
                
                imageİndirNet dmage = new imageİndirNet(imge);
                dmage.Download();
                try
                { dmage.SaveImage("D:\\dergiadi" + i + ".jpg", ImageFormat.Jpeg); }
                catch (Exception )
                {
                    dmage.SaveImage("D:\\dergiadi" + i + ".png", ImageFormat.Png);
                }

                try
                {
                   
                    dgwDr.Rows[i].Cells[3].Value = Image.FromFile("D:\\dergiadi" + i + ".jpg");
                    dgwDr.Rows[i].Cells[2].Value = "D:\\dergiadi" + i + ".jpg";
                }
                catch (Exception )
                {
                    dgwDr.Rows[i].Cells[3].Value = Image.FromFile("D:\\dergiadi" + i + ".png");
                }

            }
        }
        /// <summary>
        /// FormEkle Load fonksiyonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEkleDergi_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            dgwDr.ColumnCount = 3;

            dgwDr.Columns[0].Name = "ADI";
            dgwDr.Columns[1].Name = "Fiyat";
            dgwDr.Columns[2].Name = "image";
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
        /// hatali harfleri duzelten fonksiyon
        /// </summary>
        /// <param name="gelenText"></param>
        /// <returns></returns>
        public string yerineKoy(string gelenText)
        {
            gelenText = gelenText.Replace("&#214;", " Ö").Replace("&#252;", "ü").Replace("&#246;", "ö").Replace("&#199;", " Ç").Replace("&#231;", "ç").Replace("&#220;", " Ü").Replace("&#39;", "'");
            return gelenText;
        }

    }
}
