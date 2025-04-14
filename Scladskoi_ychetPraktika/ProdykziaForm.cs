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
    public partial class ProdykziaForm : Form
    {
        public ProdykziaForm()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.praktik_PDataSet);

        }

        private void ProdykziaForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktik_PDataSet.product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.praktik_PDataSet.product);

        }
    }
}
