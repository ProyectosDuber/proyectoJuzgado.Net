﻿using juzgado.Modelos;
using juzgado.Vistas.Mensajes;
using juzgado.Vistas.Procesos_crud;
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
        int segundos=0;
        mensaje objMensaje = new mensaje();
        mensajeLink objMensajeLink= new mensajeLink(new frmTiposDeProcesos());
        
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
            int numero = 0;
            foreach (var item in listaUsuarios)
            {
                numero++;
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
            if (numero == 0)
            {
                objMensaje.Visible = false;
                timer1.Stop();
                segundos = 0;
                objMensaje = new mensaje();
                objMensaje.lbTexto.Text = "No hay datos\r\nque coincidan con su busqueda\r\nlo sentimos...";
                this.objMensaje.Visible = true;
                timer1.Start();
            }
        }
        private void mostrarMensaje(String mensaje,int segundos){
            objMensaje.Visible = false;
            timer1.Stop();
            this.segundos = segundos;
            objMensaje = new mensaje();
            objMensaje.lbTexto.Text = mensaje;
            this.objMensaje.Visible = true;
            timer1.Start();
        }
        private void dgvInvolucrados_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left && e.Clicks ==2)
            {
                DataGridViewComboBoxCell celda = (DataGridViewComboBoxCell)dgvInvolucrados.Rows[e.RowIndex].Cells[4];
                DataGridViewImageCell celdaImagen = (DataGridViewImageCell)dgvInvolucrados.Rows[e.RowIndex].Cells[5];
                DataGridViewRow fila = dgvInvolucrados.Rows[e.RowIndex];
                string dato = celda.Value.ToString();
                if (dato.Equals("Demandante"))
                {
                    celda.Value = "Demandado";
                    Image img = Image.FromFile(@"Iconos/demandado.png");
                    celdaImagen.Value=img;
                }
                else
                {
                    celda.Value = "Demandante";
                    Image img = Image.FromFile(@"Iconos/demandante.png");
                    celdaImagen.Value = img;
                }
                validarEquilibrio();
                dgvInvolucrados.CurrentRow.Selected = false;
            }
        }

        private void dgvInvolucrados_MouseUp(object sender, MouseEventArgs e)
        {
           
        }
        private void validarEquilibrio()
        {
            
            int demantantes = 0;
            int demandados = 0;
            foreach (DataGridViewRow fila in dgvInvolucrados.Rows)
            {
                DataGridViewComboBoxCell celCombo = (DataGridViewComboBoxCell)fila.Cells[4];
                if (celCombo.Value.Equals("Demandante"))
                {
                    demantantes++;
                }
                else
                {
                    demandados++;
                }


            }

            if (demandados <= 0 || demantantes <= 0)
            {

               
                crear_proceso.Enabled = false;
                objMensaje.Visible = false;
                timer1.Stop();
                segundos = 0;
                objMensaje = new mensaje();
                this.objMensaje.Visible = true;
                timer1.Start();
            }
            else
            {
                crear_proceso.Enabled = true;
            
            }
        }
   
        private void dgvInvolucrados_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (dgvInvolucrados.Rows.Count > 0)
                {
                    dgvInvolucrados.ContextMenuStrip = menuInvolucrados;
                    validarEquilibrio();       
                }
                else
                {
                    dgvInvolucrados.ContextMenuStrip = null;
                }
            }
        }

        private void crear_proceso_Click(object sender, EventArgs e)
        {

            if (tipoProceso.verificarActivos(db) == true)
            {
                
                frmNuevoProceso objnuevo = new frmNuevoProceso(this,db,dgvInvolucrados.Rows);
                
                
                objnuevo.Visible = true;
            }
            else
            {
                objMensajeLink.Visible = true;
                objMensajeLink.Focus();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (segundos > 1)
            {
                objMensaje.Visible = false;
                timer1.Stop();
                segundos = 0;
            }
            else
            {
                segundos++;
            }
        }

        private void crear_proceso_MouseEnter(object sender, EventArgs e)
        {
        }

        private void crear_proceso_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void txBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            panelBusqueda.Visible = false;
        }

        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelBusqueda.Visible = true;
        }

        private void ckCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckCodigo.Checked == true)
            {
                mostrarMensaje("Introduce el codigo\r\nde el proceso judicial\r\nen la caja numerica...",-2);
                desavilitarDiferentesACodigo();
                nbCodigo.Visible = true;
            }
            else
            {
                abilitarDiferentesACodigo();
                nbCodigo.Visible = false;
            }
        }
        private void desavilitarDiferentesACodigo()
        {
            ckFechaFinalizacion.Enabled = false;
            ckFechaFinalizacion.Checked = false;

            ckFechaInicio.Enabled = false;
            ckFechaInicio.Checked = false;

            ckInvolucrado.Enabled = false;
            ckInvolucrado.Checked = false;

            ckTipoProceso.Enabled = false;
            ckTipoProceso.Checked = false;
        }
        private void abilitarDiferentesACodigo()
        {
            ckFechaFinalizacion.Enabled = true;
            ckFechaInicio.Enabled = true;

            ckInvolucrado.Enabled = true;
            
            
                ckTipoProceso.Enabled = true;
            
            
        }

        private void ckFechaInicio_CheckedChanged(object sender, EventArgs e)
        {
            if (ckFechaInicio.Checked == true)
            {
                mostrarMensaje("Introduce la fecha de inicio\r\nminima y maxima\r\nde el proceso judicial\r\nen los calendarios...", -2);
                
                dpFechaInicioMin.Visible = true;
                dpFechaInicioMax.Visible = true;
            }
            else
            {

                dpFechaInicioMin.Visible = false;
                dpFechaInicioMax.Visible = false;
            }
        }

        private void ckFechaFinalizacion_CheckedChanged(object sender, EventArgs e)
        {
            if (ckFechaFinalizacion.Checked == true)
            {
                mostrarMensaje("Introduce la fecha de finalizacion\r\nminima y maxima\r\nde el proceso judicial\r\nen los calendarios...", -2);

                dpFechaFinalizacionMin.Visible = true;
                dpFechaFinalizacionMax.Visible = true;
            }
            else
            {

                dpFechaFinalizacionMin.Visible = false;
                dpFechaFinalizacionMax.Visible = false;
            }
        }

        private void ckInvolucrado_CheckedChanged(object sender, EventArgs e)
        {
            if (ckInvolucrado.Checked == true)
            {
                mostrarMensaje("Introduce el documento\r\nde el involucrado\r\nen la caja numerica...", -2);

                nbInvolucrado.Visible = true;
              
            }
            else
            {

                nbInvolucrado.Visible = false;
            }
        }

        private void ckTipoProceso_CheckedChanged(object sender, EventArgs e)
        {
            if (ckTipoProceso.Checked == true)
            {
                mostrarMensaje("Digita el tipo de proceso\r\ndel cual quieres filtrar\r\nen la caja de texto...", -2);

                txTipoProceso.Visible = true;

            }
            else
            {

                txTipoProceso.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ckCodigo.Checked == true)
            {

            }
        }
        private void llenarTablaProcesosJudiciales(IQueryable<procesosJudiciales> listaProcesos)
        {
            foreach (procesosJudiciales prosesoJ in listaProcesos)
            {
                if(prosesoJ.estado=="finalizado"){
                    dgvProcesosJudiciales.Rows.Add(prosesoJ, prosesoJ.idProcesosJudiciales, prosesoJ.tipoProceso1.tipoProceso1, String.Format("{0:dd-MM-yyyy}", prosesoJ.fechaInicio), String.Format("{0:dd-MM-yyyy}", prosesoJ.fechaFinal),prosesoJ.Involucrados.Count,prosesoJ.Seguimientos.Count);
            
                }else{
                    dgvProcesosJudiciales.Rows.Add(prosesoJ, prosesoJ.idProcesosJudiciales, prosesoJ.tipoProceso1.tipoProceso1, String.Format("{0:dd-MM-yyyy}", prosesoJ.fechaInicio), "Sin Finalizar", prosesoJ.Involucrados.Count, prosesoJ.Seguimientos.Count);
            
                }
            
            }
        }

        
    }
}
