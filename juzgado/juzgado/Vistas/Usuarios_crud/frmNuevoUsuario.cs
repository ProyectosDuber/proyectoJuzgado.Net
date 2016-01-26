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
using juzgado.Modelos;
using System.Globalization;
namespace juzgado.Vistas.Usuarios_crud
{
    public partial class frmNuevoUsuario : Form
    {
        frmUsuarios objFrmUsuarios;
        int segundos=0;
        JuzgadoEntities db;
        public frmNuevoUsuario(frmUsuarios objFrmUsuarios,JuzgadoEntities db)
        {
            InitializeComponent();
            this.objFrmUsuarios = objFrmUsuarios;
            this.db=db;
            objFrmUsuarios.Enabled = false;
            cbTipoDocumento.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            if(txNombres.Text.Equals("")||txApellidos.Text.Equals("")||txDocumento.Text.Equals("")||txDireccion.Text.Equals("")||txEmail.Text.Equals("")||txTelefono.Text.Equals("")){
                txEstado.Text="Por Favor, Diligencie Completamente El Formulario";
                segundos = 0;
                cuenta.Start();
            }
            else
            {
             Usuarios objUsuario = new Usuarios();
             objUsuario.nombres = txNombres.Text;
             objUsuario.apellidos = txApellidos.Text;
             objUsuario.documento = txDocumento.Text;
             objUsuario.direccion = txDireccion.Text;
             objUsuario.email = txEmail.Text;
             objUsuario.telefono = txTelefono.Text;
           
             objUsuario.estado = "activo";

            //diferentes
             objUsuario.fecha = dpFechaNacimiento.Value;
             objUsuario.tipoDocumento = cbTipoDocumento.SelectedItem.ToString();
             db.Usuarios.Add(objUsuario);
             db.SaveChanges();
             txEstado.Text = "Usuario Creado Con Exito";
             segundos = 0;
             cuenta.Start();
             
             borrarCampos();
             
               

            }
        }

        private void frmNuevoUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            objFrmUsuarios.dgvUsuarios.Rows.Clear();
            objFrmUsuarios.llenarTabla();
            
            objFrmUsuarios.Enabled = true;
            this.Dispose();
            this.Visible = false;
        }

        private void cuenta_Tick(object sender, EventArgs e)
        {
            
            if (segundos < 1)
            {

            }
            else
            {
                txEstado.Text = "Estado";
                cuenta.Stop();
            }
                segundos++;
           
            
            
        }
        private void borrarCampos()
        {
            txNombres.Text ="";
            txApellidos.Text = "";
            txDocumento.Text = "";
            txDireccion.Text = "";
            txEmail.Text = "";
            txApellidos.Text = "";
            txTelefono.Text = "";
            cbTipoDocumento.SelectedIndex = 0;
            dpFechaNacimiento.Value = DateTime.Now.Date;

        }

       
    }
}
