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

namespace juzgado.Vistas.Usuarios_crud
{
    public partial class frmEditarUsuario : Form
    {
        frmUsuarios objFrmUsuarios;
        int segundos = 0;
        JuzgadoEntities db;
        Usuarios objUsuario;
        public frmEditarUsuario(frmUsuarios objFrmUsuarios, JuzgadoEntities db)
        {
            InitializeComponent();
            this.objFrmUsuarios = objFrmUsuarios;
            this.db = db;
            objFrmUsuarios.Enabled = false;
            objUsuario = (Usuarios)objFrmUsuarios.dgvUsuarios.CurrentRow.Cells[0].Value;
            llenarCampos();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txNombres.Text.Equals("") || txApellidos.Text.Equals("") || txDocumento.Text.Equals("") || txDireccion.Text.Equals("") || txEmail.Text.Equals("") || txTelefono.Text.Equals(""))
            {
                txEstado.Text = "Por Favor, Diligencie Completamente El Formulario";
                segundos = 0;
                cuenta.Start();
            }
            else
            {
              
                if (Usuarios.verificarDocumento(db, objUsuario.idUsuario,txDocumento.Text) == true)
                {
                   
                    txEstado.Text = "El Documento Ya Existe";
                    segundos = 0;
                    cuenta.Start();
                }
                else
                {
                    objUsuario.nombres = txNombres.Text;
                    objUsuario.apellidos = txApellidos.Text;
                    objUsuario.documento = txDocumento.Text;
                    objUsuario.direccion = txDireccion.Text;
                    objUsuario.email = txEmail.Text;
                    objUsuario.telefono = txTelefono.Text;

                    

                    //diferentes
                    objUsuario.fecha = dpFechaNacimiento.Value;
                    objUsuario.tipoDocumento = cbTipoDocumento.SelectedItem.ToString();
                    db.SaveChanges();
                    txEstado.Text = "Usuario Editado...";
                    segundos = 0;
                    cuenta.Start();

                }

                //Usuarios objUsuario = new Usuarios();
                //objUsuario.nombres = txNombres.Text;
                //objUsuario.apellidos = txApellidos.Text;
                //objUsuario.documento = txDocumento.Text;
                //objUsuario.direccion = txDireccion.Text;
                //objUsuario.email = txEmail.Text;
                //objUsuario.telefono = txTelefono.Text;

                //objUsuario.estado = "activo";

                ////diferentes
                //objUsuario.fecha = dpFechaNacimiento.Value;
                //objUsuario.tipoDocumento = cbTipoDocumento.SelectedItem.ToString();
                //db.Usuarios.Add(objUsuario);
                //db.SaveChanges();
                //txEstado.Text = "Usuario Creado Con Exito";
                //segundos = 0;
                //cuenta.Start();

                //borrarCampos();



            }
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

        private void frmEditarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {

            objFrmUsuarios.dgvUsuarios.CurrentRow.Cells[1].Value = objUsuario.nombres;
            objFrmUsuarios.dgvUsuarios.CurrentRow.Cells[2].Value = objUsuario.apellidos;
            objFrmUsuarios.dgvUsuarios.CurrentRow.Cells[3].Value = objUsuario.tipoDocumento;
            objFrmUsuarios.dgvUsuarios.CurrentRow.Cells[4].Value = objUsuario.documento;
            objFrmUsuarios.dgvUsuarios.CurrentRow.Cells[5].Value = objUsuario.telefono;
            objFrmUsuarios.dgvUsuarios.CurrentRow.Cells[6].Value = objUsuario.email;
            objFrmUsuarios.dgvUsuarios.CurrentRow.Cells[7].Value = objUsuario.direccion;
            objFrmUsuarios.dgvUsuarios.CurrentRow.Cells[8].Value = String.Format("{0:dd-MM-yyyy}", objUsuario.fecha);

            objFrmUsuarios.Enabled = true;
            this.Dispose();
            this.Visible = false;
        }
        private void llenarCampos()
        {
            txNombres.Text = objUsuario.nombres;
            txApellidos.Text = objUsuario.apellidos;
            txDocumento.Text = objUsuario.documento;
            txTelefono.Text = objUsuario.telefono;
            txEmail.Text = objUsuario.email;
            txDireccion.Text = objUsuario.direccion;
            dpFechaNacimiento.Value = objUsuario.fecha;
            cbTipoDocumento.SelectedItem = objUsuario.tipoDocumento;
        
            

        }
    }
}
