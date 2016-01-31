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
    public partial class mensaje : Form
    {
        public mensaje()
        {
            InitializeComponent();
           int ancho=  Screen.PrimaryScreen.Bounds.Width;
           int alto = Screen.PrimaryScreen.Bounds.Height ;
         //aparece en ezquina superior derecha
         //  this.Location = new Point(ancho - 380, 10);
         //aparece en ezquina inferior derecha
           this.Location = new Point(ancho - 380, alto-225);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void mensaje_MouseDown(object sender, MouseEventArgs e)
        {
           
            
        }

        private void mensaje_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
        bool pres = false;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            pres = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            pres = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pres == true)
            {
               
                this.Location = new Point( Cursor.Position.X-10, Cursor.Position.Y-10); 
            }
        }
    }
}
