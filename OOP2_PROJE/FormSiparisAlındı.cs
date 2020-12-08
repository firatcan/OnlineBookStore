using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_PROJE
{
    public partial class FormSiparisAlındı : Form
    {
        private static FormSiparisAlındı singletonNesnesi = null;

        private FormSiparisAlındı()
        {
            InitializeComponent();
        }
        public static FormSiparisAlındı formSiparisAlındı
        {
            get
            {
                if (singletonNesnesi == null)
                {
                    singletonNesnesi = new FormSiparisAlındı();

                }
                return singletonNesnesi;
            }

        }
        private void FormSiparisAlındı_Load(object sender, EventArgs e)
        {

        }
    }
}
