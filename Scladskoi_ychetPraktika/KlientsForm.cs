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
    public partial class KlientsForm : Form
    {
        public KlientsForm()
        {
            InitializeComponent();
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.praktik_PDataSet);

        }

        private void KlientsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktik_PDataSet.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.praktik_PDataSet.clients);

        }
    }
}
