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
    public partial class OtchetZak : Form
    {
        public OtchetZak()
        {
            InitializeComponent();
        }

        private void OtchetZak_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Praktik_PDataSet.orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.Praktik_PDataSet.orders);

            this.reportViewer1.RefreshReport();
        }
    }
}
