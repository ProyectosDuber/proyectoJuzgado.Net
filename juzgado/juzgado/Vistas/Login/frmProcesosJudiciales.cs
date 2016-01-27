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
        private void agregarUsuariosSeleccionados()
        {
            var rows = dgvUsuarios.Rows;
            var rowsInvolucrados = dgvInvolucrados.Rows;
            foreach (DataGridViewRow fila in rows)
            {
                fila.Cells[4].ReadOnly = true;
                DataGridViewCheckBoxCell celda = (DataGridViewCheckBoxCell)fila.Cells[4];

               


                if (Convert.ToBoolean(celda.Value) ==true)
                {
                    bool repetido = false;
                    foreach (DataGridViewRow filaInvolucrado in rowsInvolucrados)
                    {
                        Usuarios objInvolucrado = (Usuarios)filaInvolucrado.Cells[0].Value;
                        Usuarios objUsuario = (Usuarios)fila.Cells[0].Value;
                        if (objInvolucrado.idUsuario == objUsuario.idUsuario)
                        {
                            repetido = true;
                            
                        }
                    }
                    if (repetido == false)
                    {
                      
                        
                        fila.Cells[5].Value = "Agregado";
                        dgvInvolucrados.Rows.Add((Usuarios)fila.Cells[0].Value, fila.Cells[1].Value, fila.Cells[2].Value, fila.Cells[3].Value);
                        DataGridViewComboBoxCell c = (DataGridViewComboBoxCell)dgvInvolucrados.Rows[dgvInvolucrados.Rows.Count - 1].Cells[4];
                        c.Value = "Demandante";
                    }
                     fila.Cells[4].ReadOnly = true;
                }
                else
                {
                    fila.Cells[4].ReadOnly = false;
                }
                
            }
        }
        private void todosSonDemandantes()
        {
            var rows = dgvInvolucrados.Rows;
            foreach (DataGridViewRow fila in rows)
            {

                DataGridViewButtonCell b =(DataGridViewButtonCell) fila.Cells[4];
           
            }
        }
        private void tsNuevo_Click(object sender, EventArgs e)
        {

            dgvUsuarios.BeginEdit(false);
            agregarUsuariosSeleccionados();
           
        }

        private void dgvUsuarios_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //DataGridViewCheckBoxCell celdaCheck = (DataGridViewCheckBoxCell)dgvUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex];
            //dgvUsuarios.CurrentCell = celdaCheck;
            //celdaCheck.ReadOnly = false;
            //dgvUsuarios.BeginEdit(true);
            //if (Convert.ToBoolean(celdaCheck.Value) == false)
            //{
            //    celdaCheck.Value = true;
            //}
            //else
            //{
            //    celdaCheck.Value = false;
            //}
        }

        private void dgvUsuarios_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewCheckBoxCell celdaCheck = (DataGridViewCheckBoxCell)dgvUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex];
            
            //if (Convert.ToBoolean(celdaCheck.Value) == false)
            //{
            //    MessageBox.Show("asd");
            //}
            //else
            //{
            //    MessageBox.Show("true");
            //}
        }

        private void dgvUsuarios_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCheckBoxCell celdaCheck = (DataGridViewCheckBoxCell)dgvUsuarios.CurrentCell;
            if (e.ColumnIndex == celdaCheck.RowIndex && e.RowIndex != -1)
            {
                MessageBox.Show(Convert.ToBoolean(celdaCheck.Value)+"");
            }

        }

        private void dgvUsuarios_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            //DataGridViewCheckBoxCell celdaCheck = (DataGridViewCheckBoxCell)dgvUsuarios.CurrentCell;

            //if (Convert.ToBoolean(celdaCheck.Value) == false)
            //{
            //    MessageBox.Show("false");
            //}
            //else
            //{
            //    MessageBox.Show("true");
            //}
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
