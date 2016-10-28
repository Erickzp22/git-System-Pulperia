using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        #region animacion botones
        private void btn_Retiro_MouseHover(object sender, EventArgs e)
        {
            btn_Retiro.Image = Resources.Retirar2;
        }

        private void btn_Retiro_MouseLeave(object sender, EventArgs e)
        {
            btn_Retiro.Image = Resources.Retirar1;
        }

        private void btn_Vendedor_MouseHover(object sender, EventArgs e)
        {
            btn_Vendedor.Image = Resources.vendedor2;
        }

        private void btn_Vendedor_MouseLeave(object sender, EventArgs e)
        {
            btn_Vendedor.Image = Resources.vendedor1;
        }

        private void btn_Administrador_MouseHover(object sender, EventArgs e)
        {
            btn_Administrador.Image = Resources.Administrador2;
        }

        private void btn_Administrador_MouseLeave(object sender, EventArgs e)
        {
            btn_Administrador.Image = Resources.Administrador1;
        }

        private void btn_Cierre_MouseHover(object sender, EventArgs e)
        {
            btn_Cierre.Image = Resources.cierre2;
        }

        private void btn_Cierre_MouseLeave(object sender, EventArgs e)
        {
            btn_Cierre.Image = Resources.Inicio1;
        }

        private void btn_Abrir_MouseHover(object sender, EventArgs e)
        {
            btn_Abrir.Image = Resources.Inicio2;
        }

        private void btn_Abrir_MouseLeave(object sender, EventArgs e)
        {
            btn_Abrir.Image = Resources.cierre2;
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion animacion botones

        private void Form1_Load(object sender, EventArgs e)
        {

            lbl_Fecha.Text = DateTime.Now.Date.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year;
            
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (DateTime.Now.Hour > 12)
            {
                int hora = DateTime.Now.Hour - 12;


                if (DateTime.Now.Minute < 10)
                {

                    lbl_Hora.Text = Convert.ToString(hora + ":0" + DateTime.Now.Minute + ":" + DateTime.Now.Second);
                }
                else {

                    lbl_Hora.Text = Convert.ToString(hora + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second);
                }

            }
            else {

                if (DateTime.Now.Minute < 10)
                {

                    lbl_Hora.Text = Convert.ToString(DateTime.Now.Hour + ":0" + DateTime.Now.Minute + ":" + DateTime.Now.Second);
                }
                else
                {

                    lbl_Hora.Text = Convert.ToString(DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second);
                }
                
            }
            

        }

        
        #region Vendedor
        private void btn_Vendedor_Click(object sender, EventArgs e)
        {
            Ventas v = new Ventas();
            v.Show();
        }
        #endregion Vendedor

        private void btn_Administrador_Click(object sender, EventArgs e)
        {
            Adminitracion Ad = new Adminitracion();
            Ad.Show();
            

        }



    }
}
