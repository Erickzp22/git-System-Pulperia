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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        #region Load
        private void Ventas_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;  // para que no salga una fila en blanco en el principio del data gridview
            dataGridView1.Font = new Font("Showcard Gothic",20); // cambiamos el tamaño el font de la letra
            txt_cod_barra.Focus();
           
        }
#endregion Load

        #region InsertarProductoGridView
        private void txt_cod_barra_KeyPress(object sender, KeyPressEventArgs e)
        {
             // el codigo de barra lee y preciona el enter en la siguiente linea de codigo capturamos ese enter
            if (e.KeyChar == (char)13)
            {
                
                // validamos que la caja de texto esta vacia para proceder a ingresar el monto con el que el cliente va a pagar la compra

                if (txt_cod_barra.Text == "")
                {

                    Monto_a_Pagar mp = new Monto_a_Pagar(); 
                    mp.AsignarMonto(txt_total.Text);
                    mp.Show();
                }
                else
                {
                    // variable de control para el codigo de barra
                    string code = txt_cod_barra.Text;

                    // agregamos el producto al GridView
                    #region AgregarProductoAlGridView
                    string[] producto;

                    // cargamos el producto desde la base de datos en un arreglo
                    producto = new Business_Logic.BL.BL_CRUD().BuscarProducto(code);

                    //validamos que el arreglo tenga un producto
                    if (producto.Length > 0)
                    {
                        #region Aumentar cantidad de items
                        //validamos que el textbox cantidad de item este en 0, para saber que es el primer producto a comprar
                        if (txt_cantidad_items.Text == "0")
                        {
                            txt_cantidad_items.Text = "1";
                        }
                        else {

                            txt_cantidad_items.Text = (Convert.ToInt32(txt_cantidad_items.Text) + 1).ToString();
                        }
                        #endregion Aumentar cantidad de items

                        DataGridView dt = new DataGridView();
                        // el 0 indica que agrega en el primer campo del gridview y entonces los demas se van bajando
                        if(Find_Product_in_Grid(code)){

                            //MessageBox.Show("Si esta el producto en el GridView");

                            //Buscamos el codigo nuevamente
                            foreach(DataGridViewRow fila in dataGridView1.Rows){

                                if (fila.Cells[0].Value.Equals(code)) {

                                    //Modificamos en el GridView 
                                    fila.Cells[3].Value = ((Convert.ToInt32(fila.Cells[3].Value) + 1).ToString());                                
                                }
                            
                            }



                        }else{
                        dataGridView1.Rows.Insert(0, producto[0], producto[1], producto[2],"1");
                        }
                        
                        Sumar(); // sumamos todas las casillas del GridView
                        txt_cod_barra.Clear();
                        txt_cod_barra.Focus();




                    }
                    else
                    {

                        MessageBox.Show("El producto no esta disponible para la venta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    #endregion AgregarProductoAlGridView
                }
            }
           
        }

        #region Find_Product_in_DataGridView

        public bool Find_Product_in_Grid(string Bar_code) {

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.Cells[0].Value.Equals(Bar_code))
                {
                    return true;
                    break;
                }

            }
            return false;
        }
        
        #endregion Find_Product_in_DataGridView

        #endregion InsertarProductoGridView

        #region Sumar

        public void Sumar()
        {

            int sumatoria = 0;
            int cantidad = 0;

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                cantidad = Convert.ToInt32(fila.Cells[3].Value); 
                sumatoria += Convert.ToInt32(fila.Cells[2].Value) * cantidad;
                cantidad = 0;

            }

            txt_total.Text = sumatoria.ToString();

        }
        #endregion Sumar

        #region CancelarCompra
        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion CancelarCompra

       

       

        

    
        
    }
}
