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
    public partial class OtchetRas : Form
    {
        public OtchetRas()
        {
            InitializeComponent();
        }

        private void OtchetRas_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Praktik_PDataSet.supplies". При необходимости она может быть перемещена или удалена.
            this.suppliesTableAdapter.Fill(this.Praktik_PDataSet.supplies);

            this.reportViewer1.RefreshReport();
        }
    }
}
