using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using juzgado.Vistas.Login;
namespace juzgado.Vistas.Usuarios_crud
{
    public partial class frmNuevoUsuario : Form
    {
        frmUsuarios objUsuarios;
        public frmNuevoUsuario(frmUsuarios objUsuarios)
        {
            InitializeComponent();
            this.objUsuarios = objUsuarios;
            objUsuarios.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmNuevoUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            objUsuarios.Enabled = true;
            this.Dispose();
            this.Visible = false;
        }

       
    }
}
