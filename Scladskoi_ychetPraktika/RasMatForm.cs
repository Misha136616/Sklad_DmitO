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
    public partial class RasMatForm : Form
    {
        public RasMatForm()
        {
            InitializeComponent();
        }

        private void suppliesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.praktik_PDataSet);

        }

        private void RasMatForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktik_PDataSet.supplies". При необходимости она может быть перемещена или удалена.
            this.suppliesTableAdapter.Fill(this.praktik_PDataSet.supplies);

        }
    }
}
