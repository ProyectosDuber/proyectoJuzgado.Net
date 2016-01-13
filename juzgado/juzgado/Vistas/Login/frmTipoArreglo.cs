using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using juzgado.Modelos;
namespace juzgado.Vistas.Login
{
    public partial class frmTipoArreglo : Principal
    {
        public JuzgadoEntities db = new JuzgadoEntities();
        String modo = "crud";
        private DataGridViewRow filaSeleccionada = null;
        public frmTipoArreglo()
        {
            InitializeComponent();
            selectMenu(1);
            llenarTabla();
            desavilitarFilas();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            
           
        }

        private void frmTipoArreglo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void llenarTabla()
        {

            var tiposDeArreglos = tipoArreglo.selectAll(db);
      
            foreach (var item in tiposDeArreglos)
            {
               
                dgvTipoArreglos.Rows.Add(item, item.tipoArreglo1);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTipoArreglos_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (modo.Equals("crud"))
            {
                dgvTipoArreglos.ContextMenuStrip = menuCrud;
                try
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        // Add this
                        dgvTipoArreglos.CurrentCell = dgvTipoArreglos.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        // Can leave these here - doesn't hurt
                        dgvTipoArreglos.Rows[e.RowIndex].Selected = true;
                        dgvTipoArreglos.Focus();
                    }
                }
                catch (Exception Ex)
                {

                    dgvTipoArreglos.ContextMenuStrip = null;
                }
            }
            else
            {

            }
           
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {//btn agregar


            changeModeToAgregar();
            dgvTipoArreglos.Rows.Add("","");
            dgvTipoArreglos.Rows[dgvTipoArreglos.Rows.Count-1].ReadOnly = false;
            DataGridViewCell celda = dgvTipoArreglos.Rows[dgvTipoArreglos.Rows.Count - 1].Cells[1];
            celda.Style.BackColor = Color.CadetBlue;
            dgvTipoArreglos.CurrentCell = celda;
            dgvTipoArreglos.BeginEdit(true);
            
        }
        private void desavilitarFilas()
        {
            foreach (DataGridViewRow item in dgvTipoArreglos.Rows)
            {
                item.ReadOnly = true;
            }
        }
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //btn edicion
            changeModeToEdicion();
            DataGridViewRow fila = dgvTipoArreglos.CurrentRow;
            filaSeleccionada = fila;
            fila.Cells[1].Style.BackColor = Color.CadetBlue;
            fila.ReadOnly = false;
            dgvTipoArreglos.CurrentCell = fila.Cells[1];
            dgvTipoArreglos.BeginEdit(true);


        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {//btn eliminar
            DialogResult result2 = MessageBox.Show("Desea Eliminar El Tipo De Arreglo?", "Eliminar",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);
            if (result2 == DialogResult.Yes)
            {
                DataGridViewRow fila = dgvTipoArreglos.CurrentRow;
                tipoArreglo objTipoArreglo = (tipoArreglo)fila.Cells[0].Value;
                objTipoArreglo.estado = "eliminado";
                db.SaveChanges();

                dgvTipoArreglos.Rows.Remove(fila);
               
            }
            

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {//btn guardar;

            if (modo.Equals("agregar"))
            {
               
               
                dgvTipoArreglos.BeginEdit(false);
                dgvTipoArreglos.CurrentCell = null;
                DataGridViewCell celda = dgvTipoArreglos.Rows[dgvTipoArreglos.Rows.Count - 1].Cells[1];
                try
                {
                    
                    if (celda.Value.ToString().Equals(""))
                    {
                        //DialogResult result2 = MessageBox.Show("Desea Salir De El Modo Agregacion?","Vacio",
                        //                                     MessageBoxButtons.YesNoCancel,
                        //                                   MessageBoxIcon.Question);

                        celda.Style.BackColor = Color.Red;
                        dgvTipoArreglos.CurrentCell = celda;
                        dgvTipoArreglos.BeginEdit(true);
                    }
                    else
                    {
                        tipoArreglo objTipoArreglo = new tipoArreglo();
                        objTipoArreglo.estado = "activo";
                        objTipoArreglo.tipoArreglo1 = celda.Value.ToString();
                        db.tipoArreglo.Add(objTipoArreglo);
                        db.SaveChanges();
                        DataGridViewCell celdaObjeto = dgvTipoArreglos.Rows[dgvTipoArreglos.Rows.Count - 1].Cells[0];
                        celdaObjeto.Value = objTipoArreglo;
                        
                        dgvTipoArreglos.Rows[dgvTipoArreglos.Rows.Count - 1].ReadOnly = true;
                        celda.Style.BackColor = Color.White;
                        changeModeToCrud();
                    }
                }
                catch (System.NullReferenceException ex)
                {
                    celda.Style.BackColor = Color.Red;
                    dgvTipoArreglos.CurrentCell = celda;
                    dgvTipoArreglos.BeginEdit(true);
                    
                }
             

               
                //dgvTipoArreglos.Rows.RemoveAt(dgvTipoArreglos.Rows.Count - 1);

                
            }
            else
            {
                dgvTipoArreglos.BeginEdit(false);
                dgvTipoArreglos.CurrentCell = null;
                DataGridViewCell celda = filaSeleccionada.Cells[1];
                try
                {

                    if (celda.Value.ToString().Equals(""))
                    {
                        //DialogResult result2 = MessageBox.Show("Desea Salir De El Modo Agregacion?","Vacio",
                        //                                     MessageBoxButtons.YesNoCancel,
                        //                                   MessageBoxIcon.Question);

                        celda.Style.BackColor = Color.Red;
                        dgvTipoArreglos.CurrentCell = celda;
                        dgvTipoArreglos.BeginEdit(true);
                    }
                    else
                    {
                        tipoArreglo objTipoArreglo = (tipoArreglo)filaSeleccionada.Cells[0].Value;
                        objTipoArreglo.tipoArreglo1 = filaSeleccionada.Cells[1].Value.ToString();
                        db.SaveChanges();

                      
                        filaSeleccionada.ReadOnly = true;
                        filaSeleccionada.Cells[1].Style.BackColor = Color.White;
                        changeModeToCrud();
                    }
                }
                catch (System.NullReferenceException ex)
                {
                    celda.Style.BackColor = Color.Red;
                    dgvTipoArreglos.CurrentCell = celda;
                    dgvTipoArreglos.BeginEdit(true);

                }
            }
            

        }
        private void changeModeToCrud()
        {
            modo = "crud";
            dgvTipoArreglos.ContextMenuStrip = null;
            dgvTipoArreglos.ContextMenuStrip = menuCrud;
        }
        private void changeModeToAgregar()
        {
            modo = "agregar";
            dgvTipoArreglos.ContextMenuStrip = null;
            dgvTipoArreglos.ContextMenuStrip = menuGuardar;
        }
        private void changeModeToEdicion()
        {
            modo = "editar";
            dgvTipoArreglos.ContextMenuStrip = null;
            dgvTipoArreglos.ContextMenuStrip = menuGuardar;
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //btn cancelar
            if (modo.Equals("agregar"))
            {
                DialogResult result2 = MessageBox.Show("Desea Salir De El Modo Agregacion?", "Salir",
                                                           MessageBoxButtons.YesNo,
                                                           MessageBoxIcon.Question);
                if (result2 == DialogResult.Yes)
                {
                    dgvTipoArreglos.Rows.RemoveAt(dgvTipoArreglos.Rows.Count - 1);
                    modo = "crud";
                    dgvTipoArreglos.ContextMenuStrip = null;
                    dgvTipoArreglos.ContextMenuStrip = menuCrud;
                }
                else
                {

                }   
            }
            else
            {
                DialogResult result2 = MessageBox.Show("Desea Salir De El Modo Edicion?", "Salir",
                                                                           MessageBoxButtons.YesNo,
                                                                           MessageBoxIcon.Question);
                if (result2 == DialogResult.Yes)
                {

                    tipoArreglo objTipoArreglo = (tipoArreglo)filaSeleccionada.Cells[0].Value;
                    
                    filaSeleccionada.Cells[1].Style.BackColor = Color.White;
                    
                    filaSeleccionada.ReadOnly = true;
                    filaSeleccionada.Cells[1].Value = objTipoArreglo.tipoArreglo1;
                    modo = "crud";
                    dgvTipoArreglos.ContextMenuStrip = null;
                    dgvTipoArreglos.ContextMenuStrip = menuCrud;

                }
            }
        }

        private void dgvTipoArreglos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
