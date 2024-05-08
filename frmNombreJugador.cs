using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryIrustaSantiago
{
    public partial class frmNombreJugador : Form
    {
        public frmNombreJugador()
        {
            InitializeComponent();
            Bitmap fondo = new Bitmap(Properties.Resources.estrellas);
            this.BackgroundImage = fondo;
            this.BackgroundImageLayout = ImageLayout.Stretch;



        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            if(txtNombreJugador.Text != "")
            {
                frmJuego frm = new frmJuego(txtNombreJugador.Text);
                frm.ShowDialog();

                txtNombreJugador.Clear();
            }
            else
            {
                MessageBox.Show("Debe colocar el nombre del jugador");
            }
            
        }
    }
}
