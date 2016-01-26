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
    }
}
