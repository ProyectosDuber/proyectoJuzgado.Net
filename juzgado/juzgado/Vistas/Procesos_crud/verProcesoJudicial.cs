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
    public partial class verProcesoJudicial : Form
    {
        public verProcesoJudicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pPropiedades.Width != 120)
            {
                pPropiedades.Width = 120;
            }
            else
            {
                int ancho = (this.Width * 35) / 100;
                pPropiedades.Width = ancho;
            }
            
            

        }

        private void verProcesoJudicial_SizeChanged(object sender, EventArgs e)
        {
            int ancho = (this.Width * 35) / 100;
            pPropiedades.Width = ancho;
            int alto = (this.Height * 45) / 100;
            pSeguimientos.Height = alto;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pSeguimientos.Height != 34)
            {
                pSeguimientos.Height = 34;
            }
            else
            {
                int alto = (this.Height * 45) / 100;
                pSeguimientos.Height = alto;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pInvolucrados.Height != 34)
            {
                pInvolucrados.Height = 34;
            }
            else
            {
                int alto = (this.Height * 45) / 100;
                pInvolucrados.Height = alto;
            }
        }
    }
}
