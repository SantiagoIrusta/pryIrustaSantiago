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

        public claseNave objNaveJugador = new claseNave(); //Declaro e inicializo un objeto de claseNave
        public claseNave objNaveEnemigo; //Declaro pero no inicializo
        claseDisparo objDisparo;

        int puntaje = 0;

        string nombre;


        public frmJuego(string nombreJugador)
        {
            InitializeComponent();
            nombre = nombreJugador;

        }

        //Se inicia el formulario creando la nave jugador, pasando el nombre por parametro
        //Agrego la nave al formulario
        private void frmJuego_Load(object sender, EventArgs e)
        {
            objNaveJugador.crearJugador(nombre);
            Controls.Add(objNaveJugador.imgNave);

        }

        int contador = 0;

        List<claseNave> DatosNavesEnemigas = new List<claseNave>(); //Creo una lista del tipo claseNave

        private bool existeIntercepcion(PictureBox pictureBoxNave) //Funcion que devuelve si hay intercepcion o no
        {
            foreach (claseNave nave in DatosNavesEnemigas)
            {
                if (pictureBoxNave.Bounds.IntersectsWith(nave.imgNave.Bounds)) //Comprueba si el limite del PictureBox intercepta
                                                                               //con el limite de cada nave enemiga de la lista
                {
                    return true;
                }
            }

            return false;
        }

        private void timerEnemigo_Tick(object sender, EventArgs e)
        {
            if (contador < 10)
            {
                objNaveEnemigo = new claseNave(); //Inicializo un objeto de claseNave
                objNaveEnemigo.crearEnemigo();

                if (!existeIntercepcion(objNaveEnemigo.imgNave)) //Si no hay intercepcion
                {
                    Controls.Add(objNaveEnemigo.imgNave); //Agrego la nave enemiga al formulario

                    DatosNavesEnemigas.Add(objNaveEnemigo);//Agrego la nave enemiga a la lista

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
                objDisparo = new claseDisparo(); //Inicializo un objeto de claseDisparo

                Point location = new Point(objNaveJugador.imgNave.Location.X + 49,
                    objNaveJugador.imgNave.Location.Y - 10); //Creo una variable del tipo Point guardando la ubicacion del disparo

                objDisparo.CrearDisparo(location); //Paso por parametro la ubicacion

                Controls.Add(objDisparo.imgDisparo);//Agrego el disparo al formulario

                timerDisparo.Enabled = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                objNaveJugador.imgNave.Location = new Point(objNaveJugador.imgNave.Location.X + 5,
                    objNaveJugador.imgNave.Location.Y); //Muevo la nave Jugador hacia la derecha

                if (objNaveJugador.imgNave.Location.X >= 830)
                {
                    objNaveJugador.imgNave.Location = new Point(-20, objNaveJugador.imgNave.Location.Y);
                }
            }

            if (e.KeyCode == Keys.Left)
            {
                objNaveJugador.imgNave.Location = new Point(objNaveJugador.imgNave.Location.X - 5,
                    objNaveJugador.imgNave.Location.Y); //Muevo nave jugador hacia la izquierda

                if (objNaveJugador.imgNave.Location.X <= -18)
                {
                    objNaveJugador.imgNave.Location = new Point(831, objNaveJugador.imgNave.Location.Y);
                }
            }
        }

        private void timerDisparo_Tick(object sender, EventArgs e)
        {
            List<Control> controlesEliminar = new List<Control>(); 
            
            foreach(Control imagenDisparo in this.Controls) //Recorro todos los controles del formulario
            {
                if(imagenDisparo.Tag == "disparo") //Si la etiqueta del control es "disparo"
                {
                    if(imagenDisparo.Location.Y > 0)
                    {
                        imagenDisparo.Location = new Point(imagenDisparo.Location.X, 
                            imagenDisparo.Location.Y - 10);

                        //Comprobar colision de disparo con nave enemiga
                        foreach(Control posibleNave in this.Controls)
                        {
                            if (posibleNave.Tag == "naveEnemiga" &&
                                imagenDisparo.Bounds.IntersectsWith(posibleNave.Bounds))
                            {
                                controlesEliminar.Add(imagenDisparo); //Agrego el disparo y la nave enemiga a la
                                                                      //lista de controles a eliminar  
                                controlesEliminar.Add(posibleNave);

                                puntaje = puntaje + 10;
                                lblScore.Text = puntaje.ToString();

                                if (puntaje == 100)
                                {
                                    frmFinJuego frm = new frmFinJuego(objNaveJugador.nombreNave); //Creo una instancia del formulario
                                                                                                  //frmFinJuego y paso por parametro el nombre del jugador
                                    frm.ShowDialog();//Muestro el formulario

                                    Close();
                                }
                            }
                             
                        }
                    }
                    else
                    {
                        if (!controlesEliminar.Contains(imagenDisparo))
                        {
                            controlesEliminar.Add(imagenDisparo); //Si esta fuera de los limites
                                                                  //del formulario lo agrego a la lista a eliminar
                        }
                    }
                }

                
            }
            
            foreach(Control control in controlesEliminar)
            {
                this.Controls.Remove(control);//Elimino del formulario;
                control.Dispose();//Libero recursos para evitar ecumulacion de
                                  //objetos no utilizados en memoria
            }
        }
    }
}
