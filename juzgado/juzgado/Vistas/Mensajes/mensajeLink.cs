using juzgado.Vistas.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juzgado.Vistas.Mensajes
{
    public partial class mensajeLink : Form
    {
        frmTiposDeProcesos objTiposDeProcesos=null;
        frmTipoArreglo objTipoArreglo=null;
        public mensajeLink(frmTiposDeProcesos objTiposDeProcesos)
        {
            InitializeComponent();
            int ancho = Screen.PrimaryScreen.Bounds.Width;
            int alto = Screen.PrimaryScreen.Bounds.Height;
            //aparece en ezquina superior derecha
            //  this.Location = new Point(ancho - 380, 10);
            //aparece en ezquina inferior derecha
            this.Location = new Point(ancho - 380, alto - 225);
           //como tiene que ser 
            this.objTiposDeProcesos = objTiposDeProcesos;
            

        }
        public mensajeLink(frmTipoArreglo objTipoArreglo)
        {
            InitializeComponent();
            int ancho = Screen.PrimaryScreen.Bounds.Width;
            int alto = Screen.PrimaryScreen.Bounds.Height;
            //aparece en ezquina superior derecha
            //  this.Location = new Point(ancho - 380, 10);
            //aparece en ezquina inferior derecha
            this.Location = new Point(ancho - 380, alto - 225);
            //como tiene que ser 
            this.objTipoArreglo = objTipoArreglo;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void mensajeLink_MouseMove(object sender, MouseEventArgs e)
        {
            this.Opacity = 100;
        }

        private void mensajeLink_MouseLeave(object sender, EventArgs e)
        {
          
            this.Opacity = 70;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Opacity = 100;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            this.Opacity = 70;
        }

        private void mensajeLink_Leave(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (objTiposDeProcesos != null)
            {
                objTiposDeProcesos = new frmTiposDeProcesos();
                objTiposDeProcesos.menu.Enabled = false;
                objTiposDeProcesos.salir = false;
                objTiposDeProcesos.Visible = true;
                objTiposDeProcesos.mtdAgregar();
                
            }
            else
            {
                objTipoArreglo = new frmTipoArreglo();
                objTipoArreglo.menu.Enabled = false;
                objTipoArreglo.salir = false;
                objTipoArreglo.Visible = true;
                objTipoArreglo.mtdAgregar();
            }
            this.Visible = false;
            
        }
    }
}
