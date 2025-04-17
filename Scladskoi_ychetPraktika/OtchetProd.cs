using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scladskoi_ychetPraktika
{
    public partial class OtchetProd : Form
    {
        public OtchetProd()
        {
            InitializeComponent();
        }

        private void OtchetProd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Praktik_PDataSet.product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.Praktik_PDataSet.product);

            this.reportViewer1.RefreshReport();
        }
    }
}
