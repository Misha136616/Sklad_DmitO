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
    public partial class Form1 : Form
    {
        public Form1()
        {
           InitializeComponent();
        }

        private void ProdykziaForm_Click(object sender, EventArgs e)
        {

        }

        private void Zakazi_but_Click(object sender, EventArgs e)
        {
            ZakaziForm zakaziForm = new ZakaziForm();
            zakaziForm.Show();
        }

        private void Klients_but_Click(object sender, EventArgs e)
        {

        }

        private void Sotrydniki_but_Click(object sender, EventArgs e)
        {

        }

        private void RasMat_but_Click(object sender, EventArgs e)
        {

        }

        private void Otch_Click(object sender, EventArgs e)
        {

        }
    }
}
