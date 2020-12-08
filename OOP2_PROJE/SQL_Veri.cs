using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OOP2_PROJE
{
    /// <summary>
    /// sqlde yapilacak ortak isleri icerir
    /// </summary>
    public abstract class SQL_Veri
    {
        public SqlConnection bagla = new SqlConnection("Data Source=.;Initial Catalog=BookStore;Integrated Security=true");
        public SqlCommand komut;
        public SqlDataReader VeriOku;
    }
}
