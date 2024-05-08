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
    public partial class frmFinJuego : Form
    {
        public frmFinJuego(string nombre)
        {
            InitializeComponent();
            lblNombreJugador.Text = nombre;

        }
    }
}
