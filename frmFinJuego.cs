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

            Bitmap fondo = new Bitmap(Properties.Resources.estrellas); //Creo una variable del tipo bitmap que contendra la imagen del fondo
            this.BackgroundImage = fondo; //Establezco la imagen de fondo del formulario actual
            this.BackgroundImageLayout = ImageLayout.Stretch;//La imagen se adapta a las dimensiones del formulario

        }
    }
}
