using juzgado.Modelos;
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

namespace juzgado
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (txUsuario.Text.Equals("") || txClave.Text.Equals(""))
            {   
                txValidacion.Text = "Por Favor, Diligencie Todos Los Campos..."; 
                //Usuario O Contraceña Incorrectos...
            }
            else
            {
                if (Log.inicioSecion(txUsuario.Text, txClave.Text) == true)
                {
                    txValidacion.Text = "Bienvenido...";
                    Principal p = new Principal();
                    p.Show();
                    this.Visible=false;
                }
                else
                {
                    txValidacion.Text = "Usuario O Contraceña Incorrectos...";
                }
            }
            
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

       
    }
}
