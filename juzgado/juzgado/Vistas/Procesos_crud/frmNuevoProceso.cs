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

namespace juzgado.Vistas.Procesos_crud
{
    public partial class frmNuevoProceso : Form
    {
        frmProcesosJudiciales objProcesosJudiciales;
        JuzgadoEntities db;
       DataGridViewRowCollection filasInvolucrados;
       procesosJudiciales proceso;
       int segundos = 0;
       mensaje objMensaje = new mensaje();
       public frmNuevoProceso(frmProcesosJudiciales objProcesosJudiciales, JuzgadoEntities db, DataGridViewRowCollection filasInvolucrados)
        {
            InitializeComponent();
            this.objProcesosJudiciales = objProcesosJudiciales;
            this.db = db;
            this.filasInvolucrados = filasInvolucrados;

            objProcesosJudiciales.Enabled = false;
            
            var listTiposProcesos = tipoProceso.selectAll(db);
            foreach(var objTipoProceso in listTiposProcesos){
                cbTipoProceso.Items.Add(objTipoProceso);
            }
            cbTipoProceso.SelectedIndex = 0;
            crearProcesoVacio();
            txCodigo.Text = "" + proceso.idProcesosJudiciales;
        }

       

        private void frmNuevoProceso_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.procesosJudiciales.Remove( proceso);
            db.SaveChanges();
            objProcesosJudiciales.Enabled = true;
            this.Dispose();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txAsunto.Text.Equals(""))
            {
        
                objMensaje.lbTexto.Text = "Por favor, establece minimo\r\nun asunto";
                objMensaje.Visible = true;
                objMensaje.Focus();
                segundos = 0;
                timer1.Start();
            }
            else
            {
                
                proceso.asunto = txAsunto.Text;
                
                proceso.fechaInicio = dpFechaInicio.Value;
                proceso.observaciones = txObservaciones.Text;
                proceso.tipoProceso1=(tipoProceso)cbTipoProceso.SelectedItem;

                
                foreach (DataGridViewRow row in filasInvolucrados)
                {
                    Involucrados involucrado = new Involucrados();
                    involucrado.tipo = row.Cells[4].Value.ToString();
                    involucrado.Usuarios = (Usuarios)row.Cells[0].Value;
                    involucrado.procesoJudicial = proceso.idProcesosJudiciales;
                    involucrado.estado = "activo";
                    db.Involucrados.Add(involucrado);
                    db.SaveChanges();
                }
                objMensaje.lbTexto.Text = "Proceso judicial creado,\r\nse prepara al instante\r\nel entorno para\r\nun nuevo proceso";
                objMensaje.Visible = true;
                objMensaje.Focus();
                segundos = 0;
                timer1.Start();
                crearProcesoVacio();
                txCodigo.Text = ""+proceso.idProcesosJudiciales;
                txObservaciones.Text = "";
                cbTipoProceso.SelectedIndex = 0;
                txAsunto.Text = "";
                dpFechaInicio.Value = DateTime.Now.Date;

            }
        }
        private void crearProcesoVacio(){
             proceso = new procesosJudiciales();
            proceso.asunto = txAsunto.Text;
            proceso.estado = "activo";
            proceso.fechaInicio = dpFechaInicio.Value;
            proceso.observaciones = txObservaciones.Text;
            proceso.tipoProceso1 = (tipoProceso)cbTipoProceso.SelectedItem;

            db.procesosJudiciales.Add(proceso);
            db.SaveChanges();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (segundos > 1)
            {
                objMensaje.Visible = false;
                segundos = 0;
                timer1.Stop();
            }
            else
            {
                segundos++;
            }

        }
    }
}
