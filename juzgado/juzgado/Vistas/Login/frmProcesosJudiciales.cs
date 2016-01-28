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

namespace juzgado.Vistas.Login
{
    public partial class frmProcesosJudiciales : Principal
    {
        public JuzgadoEntities db = new JuzgadoEntities();
        public frmProcesosJudiciales()
        {
            InitializeComponent();
            selectMenu(4);
            llenarTabla();
          
         
            dgvInvolucrados.ContextMenuStrip = null;
        }

        private void frmProcesosJudiciales_Load(object sender, EventArgs e)
        {

        }
        public void llenarTabla()
        {
            var listaUsuarios = Usuarios.selectAll(db);

            foreach (var item in listaUsuarios)
            {

                dgvUsuarios.Rows.Add(item, item.nombres, item.apellidos, item.documento,false,"Sin Agregar");
            }
        }
        
      
        private void tsNuevo_Click(object sender, EventArgs e)
        {

            
        }

        private void dgvUsuarios_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                agregarYQuitarInvolucrados(e);
           }
        }
        private void agregarYQuitarInvolucrados(DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCheckBoxCell celdaCheck = (DataGridViewCheckBoxCell)dgvUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex];
            DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];
            if (Convert.ToBoolean(celdaCheck.Value) == false)
            {
               
                fila.Cells[5].Value = "Agregado";
                dgvInvolucrados.Rows.Add((Usuarios)fila.Cells[0].Value, fila.Cells[1].Value, fila.Cells[2].Value, fila.Cells[3].Value);
                DataGridViewComboBoxCell c = (DataGridViewComboBoxCell)dgvInvolucrados.Rows[dgvInvolucrados.Rows.Count - 1].Cells[4];
                c.Value = "Demandante";
                celdaCheck.Value = true;
            }
            else
            {
               
                int id = ((Usuarios)fila.Cells[0].Value).idUsuario;
                var rows = dgvInvolucrados.Rows;
                foreach (DataGridViewRow row in rows)
                {
                    if (id == ((Usuarios)row.Cells[0].Value).idUsuario)
                    {
                        dgvInvolucrados.Rows.Remove(row);
                        fila.Cells[5].Value = "Sin Agregar";
                        break;
                    }
                }
                celdaCheck.Value = false;
            }
         
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                dgvUsuarios.Rows.Clear();
                llenarTablaPorDocumento();
            }
    
        }

        public void llenarTablaPorDocumento()
        {
            var listaUsuarios = Usuarios.buscarPorDocumento(db, txBusqueda.Text);

            foreach (var item in listaUsuarios)
            {

                int id = item.idUsuario;
                var rows = dgvInvolucrados.Rows;
                bool esInvolucrado = false;
                foreach (DataGridViewRow row in rows)
                {
                    if (id == ((Usuarios)row.Cells[0].Value).idUsuario)
                    {
                        esInvolucrado = true;
                        break;
                    }
                }
                if (esInvolucrado == true)
                {
                    dgvUsuarios.Rows.Add(item, item.nombres, item.apellidos, item.documento, true, "Agregado");
                }
                else
                {
                    dgvUsuarios.Rows.Add(item, item.nombres, item.apellidos, item.documento, false, "Sin Agregar");
                }

            }
        }

        private void dgvInvolucrados_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
              
            }
        }

        private void dgvInvolucrados_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void dgvInvolucrados_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (dgvInvolucrados.Rows.Count > 0)
                {
                    dgvInvolucrados.ContextMenuStrip = menuInvolucrados;
                }
                else
                {
                    dgvInvolucrados.ContextMenuStrip = null;
                }
            }
        }
    }
}
