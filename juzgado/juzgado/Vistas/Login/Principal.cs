using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juzgado.Vistas.Login
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void asdToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hola1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmTipoArreglo p = new frmTipoArreglo();
            p.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mTiposArreglo.BackgroundImage = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //juzgado.Properties.Resources.yelow
            
           

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        protected void selectMenu(int numero)
        {
            desSelectedAll();
            Image imagen = Image.FromFile(@"Iconos\ico\infobar\yelow.png");
            if (numero == 1)
            {
                mTiposArreglo.BackgroundImage = imagen;
            }
            else if (numero == 2)
            {
                mTiposProceso.BackgroundImage = imagen;
            }
            else if (numero == 3)
            {
                mUsuarios.BackgroundImage = imagen;
            }
            else if (numero == 4)
            {
                mProcesosJudiciales.BackgroundImage = imagen;
            }
        }
        protected void desSelectedAll()
        {
            mTiposArreglo.BackgroundImage = null;
            mTiposProceso.BackgroundImage = null;
            mUsuarios.BackgroundImage = null;
            mProcesosJudiciales.BackgroundImage = null;
        }

        private void mTiposProceso_Click(object sender, EventArgs e)
        {
            frmTiposDeProcesos p = new frmTiposDeProcesos();
            p.Show();
            this.Visible = false;
        }

        private void mUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios p = new frmUsuarios();
            p.Show();
            this.Visible = false;
        }

        private void mProcesosJudiciales_Click(object sender, EventArgs e)
        {
            frmProcesosJudiciales p = new frmProcesosJudiciales();
            p.Show();
            this.Visible = false;
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
