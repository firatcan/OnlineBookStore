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
using System.Data;

namespace OOP2_PROJE
{
    public partial class FormSiparisler : Form
    {
        /// <summary>
        /// FormSiparisler constructor
        /// </summary>
        public FormSiparisler()
        {
            InitializeComponent();
        }
        /// <summary>
        /// dgvSiparisler datagridview tablosunu dolduran fonksiyon
        /// </summary>
        public void dgvDoldur()
        {
            SqlConnection bagla = new SqlConnection("Data Source=.;Initial Catalog=BookStore;Integrated Security=true");
            DataTable tablo = new DataTable();
            Customer customerNesnesi = FormAnaEkran.CustomerNesnesi;
            if(customerNesnesi!=null)
            {
                bagla.Open();
                SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM TableShoppingCard WHERE CardCustomerID='" + FormAnaEkran.CustomerNesnesi.id + "'", bagla);
                adap.Fill(tablo);
                bagla.Close();
                dgvSiparisler.DataSource = tablo;
            }
        }
    }
}
