﻿using juzgado.Modelos;
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
    public partial class frmUsuarios : Principal
    {
        public JuzgadoEntities db = new JuzgadoEntities();
       
        private DataGridViewRow filaSeleccionada = null;
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
        private void llenarTabla()
        {
            var listaUsuarios = Usuarios.selectAll(db);

            foreach (var item in listaUsuarios)
            {

                dgvUsuarios.Rows.Add(item, item.nombres, item.apellidos, item.tipoDocumento, item.documento, item.telefono, item.email, item.direccion, item.fecha.Date,3);
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
    }
}
