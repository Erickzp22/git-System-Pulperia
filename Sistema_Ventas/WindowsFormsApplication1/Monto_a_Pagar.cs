using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Monto_a_Pagar : Form
    {
        public Monto_a_Pagar()
        {
            InitializeComponent();
        }

        public void AsignarMonto(string monto)
        {

            txt_total.Text = monto;

        }

        private void txt_Listo_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Convert.ToInt32(txt_Monto.Text) - Convert.ToInt32(txt_total.Text)).ToString());
        }

        private void Monto_a_Pagar_Load(object sender, EventArgs e)
        {

        }
        
    }
}
