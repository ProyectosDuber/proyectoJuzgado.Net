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
        public frmNuevoProceso(frmProcesosJudiciales objProcesosJudiciales, JuzgadoEntities db)
        {
            InitializeComponent();
            this.objProcesosJudiciales = objProcesosJudiciales;
            this.db = db;
            objProcesosJudiciales.Enabled = false;
            int numero = procesosJudiciales.mtdNumeroDeProcesos(db);
            txCodigo.Text=""+(numero+1);
            var listTiposProcesos = tipoProceso.selectAll(db);
            foreach(var objTipoProceso in listTiposProcesos){
                cbTipoProceso.Items.Add(objTipoProceso);
            }
            cbTipoProceso.SelectedIndex = 0;
        }

       

        private void frmNuevoProceso_FormClosed(object sender, FormClosedEventArgs e)
        {
            objProcesosJudiciales.Enabled = true;
            this.Dispose();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
