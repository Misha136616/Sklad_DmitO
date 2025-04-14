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
    public partial class ZakaziForm : Form
    {
        public ZakaziForm()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.praktik_PDataSet);

        }

        private void ZakaziForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktik_PDataSet.orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.praktik_PDataSet.orders);

        }
    }
}
