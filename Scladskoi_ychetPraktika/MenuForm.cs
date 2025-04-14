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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void Zak_Click(object sender, EventArgs e)
        {
            
        }

        private void Zakazi_but_Click(object sender, EventArgs e)
        {
            ZakaziForm zakaziForm = new ZakaziForm();
            zakaziForm.Show();
        }

        private void Klients_but_Click(object sender, EventArgs e)
        {
            KlientsForm klientsForm = new KlientsForm();
            klientsForm.Show();
        }

        private void Sotrydniki_but_Click(object sender, EventArgs e)
        {
            SotrydnikiForm sotrydnikiForm = new SotrydnikiForm();
            sotrydnikiForm.Show();
        }

        private void RasMat_but_Click(object sender, EventArgs e)
        {
            RasMatForm rasmatForm = new RasMatForm();
            rasmatForm.Show();
        }

        private void ProdykziaForm_Click(object sender, EventArgs e)
        {
            ProdykziaForm prodykziaForm = new ProdykziaForm();
            prodykziaForm.Show();
        }
    }
}
