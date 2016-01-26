using juzgado.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using juzgado.Vistas.Usuarios_crud;
namespace juzgado.Vistas.Login
{
    public partial class frmUsuarios : Principal
    {
        public JuzgadoEntities db = new JuzgadoEntities();
       
        public DataGridViewRow filaSeleccionada = null;
        public frmUsuarios()
        {
            InitializeComponent();
            selectMenu(3);
            llenarTabla();

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }
        //para el constructor
        public void llenarTabla()
        {
            var listaUsuarios = Usuarios.selectAll(db);

            foreach (var item in listaUsuarios)
            {

                dgvUsuarios.Rows.Add(item, item.nombres, item.apellidos, item.tipoDocumento, item.documento, item.telefono, item.email, item.direccion,String.Format("{0:dd-MM-yyyy}", item.fecha) ,3);
            }
        }


        private void dgvUsuarios_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvUsuarios.ContextMenuStrip = menuCrud;
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    // Add this
                    dgvUsuarios.CurrentCell = dgvUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    // Can leave these here - doesn't hurt
                    dgvUsuarios.Rows[e.RowIndex].Selected = true;
                    dgvUsuarios.Focus();
                }
            }
            catch (Exception Ex)
            {

                dgvUsuarios.ContextMenuStrip = null;
            }
        }

        private void tsNuevo_Click(object sender, EventArgs e)
        {

            frmNuevoUsuario obj = new frmNuevoUsuario(this,  db);
            obj.Visible = true;
        }
    }
}
