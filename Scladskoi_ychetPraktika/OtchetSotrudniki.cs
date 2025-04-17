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
    public partial class OtchetSotrudniki : Form
    {
        public OtchetSotrudniki()
        {
            InitializeComponent();
        }

        private void OtchetSotrudniki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Praktik_PDataSet.employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.Praktik_PDataSet.employees);

            this.reportViewer1.RefreshReport();
        }
    }
}
