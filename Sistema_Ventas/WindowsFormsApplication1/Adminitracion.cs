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
    public partial class Adminitracion : Form
    {
        public Adminitracion()
        {
            InitializeComponent();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {

            if (new Business_Logic.BL.BL_CRUD().Insertar(txt_Cod.Text, txt_Descripcion.Text, txt_P_V.Text, txt_P_C.Text, txt_Stock.Text, txt_Min_S.Text))
            {


                // Se inserto correctamente
                MessageBox.Show("Se inserto correctamente");
            }
            else { 
            
            // Error al insertar
            }

        }

        private void btncrearPerfil_Click(object sender, EventArgs e)
        {

        }

        private void Adminitracion_Load(object sender, EventArgs e)
        {

        }
    }
}
