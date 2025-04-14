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
    public partial class SotrydnikiForm : Form
    {
        public SotrydnikiForm()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.praktik_PDataSet);

        }

        private void SotrydnikiForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktik_PDataSet.employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.praktik_PDataSet.employees);

        }
    }
}
