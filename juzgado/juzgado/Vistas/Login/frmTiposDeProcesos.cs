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
    public partial class frmTiposDeProcesos : Principal
    {
        public JuzgadoEntities db = new JuzgadoEntities();
        String modo = "crud";
        private DataGridViewRow filaSeleccionada = null;
        public bool salir = true;
        public frmTiposDeProcesos()
        {
            InitializeComponent();
            selectMenu(2);
            llenarTabla();
            desavilitarFilas();
        }

        private void frmTiposDeProcesos_Load(object sender, EventArgs e)
        {
            
        }
        //para el constructor
        private void llenarTabla()
        {

            var tiposDeProcesos = tipoProceso.selectAll(db);

            foreach (var item in tiposDeProcesos)
            {

                dgvTipoProcesos.Rows.Add(item, item.tipoProceso1);
            }

        }
        private void desavilitarFilas()
        {
            foreach (DataGridViewRow item in dgvTipoProcesos.Rows)
            {
                item.ReadOnly = true;
            }
        }
        //hasta aqui
        //metodos de cambio de modo o de menu contextual
        private void changeModeToCrud()
        {
            modo = "crud";
            dgvTipoProcesos.ContextMenuStrip = null;
            dgvTipoProcesos.ContextMenuStrip = menuCrud;
        }
        private void changeModeToAgregar()
        {
            modo = "agregar";
            dgvTipoProcesos.ContextMenuStrip = null;
            dgvTipoProcesos.ContextMenuStrip = menuGuardar;
        }
        private void changeModeToEdicion()
        {
            modo = "editar";
            dgvTipoProcesos.ContextMenuStrip = null;
            dgvTipoProcesos.ContextMenuStrip = menuGuardar;
        }
        //fin

        //evento para que el clic izquierdo seleccione las filas
        private void dgvTipoProcesos_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (modo.Equals("crud"))
            {
                dgvTipoProcesos.ContextMenuStrip = menuCrud;
                try
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        // Add this
                        dgvTipoProcesos.CurrentCell = dgvTipoProcesos.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        // Can leave these here - doesn't hurt
                        dgvTipoProcesos.Rows[e.RowIndex].Selected = true;
                        dgvTipoProcesos.Focus();
                    }
                }
                catch (Exception Ex)
                {

                    dgvTipoProcesos.ContextMenuStrip = null;
                }
            }
            else
            {

            }
        }

        private void tsNuevo_Click(object sender, EventArgs e)
        {//btn agregar
            mtdAgregar();
        }
        public void mtdAgregar()
        {
            changeModeToAgregar();
            dgvTipoProcesos.Rows.Add("", "");
            dgvTipoProcesos.Rows[dgvTipoProcesos.Rows.Count - 1].ReadOnly = false;
            DataGridViewCell celda = dgvTipoProcesos.Rows[dgvTipoProcesos.Rows.Count - 1].Cells[1];
            celda.Style.BackColor = Color.CadetBlue;
            dgvTipoProcesos.CurrentCell = celda;
            dgvTipoProcesos.BeginEdit(true);

        }
        private void tsEditar_Click(object sender, EventArgs e)
        {
            //btn edicion
            changeModeToEdicion();
            DataGridViewRow fila = dgvTipoProcesos.CurrentRow;
            filaSeleccionada = fila;
            fila.Cells[1].Style.BackColor = Color.CadetBlue;
            fila.ReadOnly = false;
            dgvTipoProcesos.CurrentCell = fila.Cells[1];
            dgvTipoProcesos.BeginEdit(true);
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            //btn eliminar
            DialogResult result2 = MessageBox.Show("Desea Eliminar El Tipo De Proceso?", "Eliminar",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);
            if (result2 == DialogResult.Yes)
            {
                DataGridViewRow fila = dgvTipoProcesos.CurrentRow;
                tipoProceso objTipoProceso = (tipoProceso)fila.Cells[0].Value;
                objTipoProceso.estado = "eliminado";
                db.SaveChanges();

                dgvTipoProcesos.Rows.Remove(fila);

            }
        }

        private void tsGuardar_Click(object sender, EventArgs e)
        {
            //btn guardar;

            if (modo.Equals("agregar"))
            {


                dgvTipoProcesos.BeginEdit(false);
                dgvTipoProcesos.CurrentCell = null;
                DataGridViewCell celda = dgvTipoProcesos.Rows[dgvTipoProcesos.Rows.Count - 1].Cells[1];
                try
                {

                    if (celda.Value.ToString().Equals(""))
                    {
                       
                        celda.Style.BackColor = Color.Red;
                        dgvTipoProcesos.CurrentCell = celda;
                        dgvTipoProcesos.BeginEdit(true);
                    }
                    else
                    {
                        tipoProceso objTipoProceso = new tipoProceso();
                        objTipoProceso.estado = "activo";
                        objTipoProceso.tipoProceso1 = celda.Value.ToString();
                        db.tipoProceso.Add(objTipoProceso);
                        db.SaveChanges();
                        DataGridViewCell celdaObjeto = dgvTipoProcesos.Rows[dgvTipoProcesos.Rows.Count - 1].Cells[0];
                        celdaObjeto.Value = objTipoProceso;

                        dgvTipoProcesos.Rows[dgvTipoProcesos.Rows.Count - 1].ReadOnly = true;
                        celda.Style.BackColor = Color.White;
                        changeModeToCrud();
                    }
                }
                catch (System.NullReferenceException ex)
                {
                    celda.Style.BackColor = Color.Red;
                    dgvTipoProcesos.CurrentCell = celda;
                    dgvTipoProcesos.BeginEdit(true);

                }



                //dgvTipoArreglos.Rows.RemoveAt(dgvTipoArreglos.Rows.Count - 1);


            }//cuando mod =="editar"
            else
            {
                dgvTipoProcesos.BeginEdit(false);
                dgvTipoProcesos.CurrentCell = null;
                DataGridViewCell celda = filaSeleccionada.Cells[1];
                try
                {

                    if (celda.Value.ToString().Equals(""))
                    {
                        //DialogResult result2 = MessageBox.Show("Desea Salir De El Modo Agregacion?","Vacio",
                        //                                     MessageBoxButtons.YesNoCancel,
                        //                                   MessageBoxIcon.Question);

                        celda.Style.BackColor = Color.Red;
                        dgvTipoProcesos.CurrentCell = celda;
                        dgvTipoProcesos.BeginEdit(true);
                    }
                    else
                    {
                        tipoProceso objTipoProceso = (tipoProceso)filaSeleccionada.Cells[0].Value;
                        objTipoProceso.tipoProceso1 = filaSeleccionada.Cells[1].Value.ToString();
                        db.SaveChanges();


                        filaSeleccionada.ReadOnly = true;
                        filaSeleccionada.Cells[1].Style.BackColor = Color.White;
                        changeModeToCrud();
                    }
                }
                catch (System.NullReferenceException ex)
                {
                    celda.Style.BackColor = Color.Red;
                    dgvTipoProcesos.CurrentCell = celda;
                    dgvTipoProcesos.BeginEdit(true);

                }
            }
        }

        private void tsCancelar_Click(object sender, EventArgs e)
        {
            //btn cancelar
            if (modo.Equals("agregar"))
            {
                DialogResult result2 = MessageBox.Show("Desea Salir De El Modo Agregacion?", "Salir",
                                                           MessageBoxButtons.YesNo,
                                                           MessageBoxIcon.Question);
                if (result2 == DialogResult.Yes)
                {
                    dgvTipoProcesos.Rows.RemoveAt(dgvTipoProcesos.Rows.Count - 1);
                    modo = "crud";
                    dgvTipoProcesos.ContextMenuStrip = null;
                    dgvTipoProcesos.ContextMenuStrip = menuCrud;
                }
                else
                {

                }
            }//modo =="editar"
            else
            {
                DialogResult result2 = MessageBox.Show("Desea Salir De El Modo Edicion?", "Salir",
                                                                           MessageBoxButtons.YesNo,
                                                                           MessageBoxIcon.Question);
                if (result2 == DialogResult.Yes)
                {

                    tipoProceso objTipoProceso = (tipoProceso)filaSeleccionada.Cells[0].Value;

                    filaSeleccionada.Cells[1].Style.BackColor = Color.White;

                    filaSeleccionada.ReadOnly = true;
                    filaSeleccionada.Cells[1].Value = objTipoProceso.tipoProceso1;
                    modo = "crud";
                    dgvTipoProcesos.ContextMenuStrip = null;
                    dgvTipoProcesos.ContextMenuStrip = menuCrud;

                }
            }
        }

        private void frmTiposDeProcesos_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            if (salir == true)
            {
                Application.Exit();
            }
            else
            {
                this.Visible = false;
            }
        }

        private void dgvTipoProcesos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }
}
