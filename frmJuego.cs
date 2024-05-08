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
    public partial class frmJuego : Form
    {

        public claseNave objNaveJugador = new claseNave();
        public claseNave objNaveEnemigo;
        claseDisparo objDisparo;

        int puntaje = 0;

        string nombre;


        public frmJuego(string nombreJugador)
        {
            InitializeComponent();
            nombre = nombreJugador;

        }

        private void frmJuego_Load(object sender, EventArgs e)
        {
            objNaveJugador.crearJugador(nombre);
            Controls.Add(objNaveJugador.imgNave);

        }

        int contador = 0;

        List<claseNave> DatosNavesEnemigas = new List<claseNave>();

        private bool existeIntercepcion(PictureBox pictureBoxNave)
        {
            foreach (claseNave nave in DatosNavesEnemigas)
            {
                if (pictureBoxNave.Bounds.IntersectsWith(nave.imgNave.Bounds))
                {
                    return true;
                }
            }

            return false;
        }

        private void timerEnemigo_Tick(object sender, EventArgs e)
        {
            if (contador < 5)
            {
                objNaveEnemigo = new claseNave();
                objNaveEnemigo.crearEnemigo();

                if (!existeIntercepcion(objNaveEnemigo.imgNave))
                {
                    Controls.Add(objNaveEnemigo.imgNave);

                    DatosNavesEnemigas.Add(objNaveEnemigo);

                    contador++;
                }
            }
            else
            {
                timerEnemigo.Enabled = false;
            }
        }

        private void frmJuego_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                timerDisparo.Enabled = true;
                objDisparo = new claseDisparo();

                Point location = new Point(objNaveJugador.imgNave.Location.X + 49,
                    objNaveJugador.imgNave.Location.Y - 10);

                objDisparo.Disparar(location);

                Controls.Add(objDisparo.imgDisparo);
            }

            if (e.KeyCode == Keys.Right)
            {
                objNaveJugador.imgNave.Location = new Point(objNaveJugador.imgNave.Location.X + 5,
                    objNaveJugador.imgNave.Location.Y);

                if (objNaveJugador.imgNave.Location.X >= 830)
                {
                    objNaveJugador.imgNave.Location = new Point(-20, objNaveJugador.imgNave.Location.Y);
                }
            }

            if (e.KeyCode == Keys.Left)
            {
                objNaveJugador.imgNave.Location = new Point(objNaveJugador.imgNave.Location.X - 5,
                    objNaveJugador.imgNave.Location.Y);

                if (objNaveJugador.imgNave.Location.X <= -18)
                {
                    objNaveJugador.imgNave.Location = new Point(831, objNaveJugador.imgNave.Location.Y);
                }
            }
        }

        private void timerDisparo_Tick(object sender, EventArgs e)
        {
            List<Control> controlesEliminar = new List<Control>();
            
            foreach(Control imagenDisparo in this.Controls)
            {
                if(imagenDisparo.Tag == "disparo")
                {
                    if(imagenDisparo.Location.Y > 0)
                    {
                        imagenDisparo.Location = new Point(imagenDisparo.Location.X, 
                            imagenDisparo.Location.Y - 10);

                        foreach(Control posibleNave in this.Controls)
                        {
                            if (posibleNave.Tag == "naveEnemiga" &&
                                imagenDisparo.Bounds.IntersectsWith(posibleNave.Bounds))
                            {
                                controlesEliminar.Add(imagenDisparo);
                                controlesEliminar.Add(posibleNave);

                                puntaje += 20;
                                lblScore.Text = puntaje.ToString();

                                if(puntaje == 100)
                                {
                                    frmFinJuego frm = new frmFinJuego(objNaveJugador.nombreNave);
                                    frm.ShowDialog();

                                    Close();
                                }
                            }
                             
                        }
                    }
                    else
                    {
                        if (!controlesEliminar.Contains(imagenDisparo))
                        {
                            controlesEliminar.Add(imagenDisparo);
                        }
                    }
                }
            }

            foreach(Control control in controlesEliminar)
            {
                this.Controls.Remove(control);
                control.Dispose();
            }
        }
    }
}
