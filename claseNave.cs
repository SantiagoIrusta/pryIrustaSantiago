using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryIrustaSantiago
{
    public class claseNave //Defino las propiedades de mi clase
    {
        public string nombreNave;
        public int vida;
        public PictureBox imgNave;
        

        public claseNave() //Inicializo las propiedades
        {
            vida = 0;
            nombreNave = "";
        }

        public void crearJugador(string nombre) //metodo para crear nave jugador 
        {
            vida = 100;
            nombreNave = nombre;

            imgNave = new PictureBox(); //Creo un objeto de la clase PictureBox y lo asigno a la variable imgNave
            imgNave.Size = new System.Drawing.Size(100, 100); //Establezco el tamaño del pictureBox creado en la linea anterior
            imgNave.Location = new Point(370, 700); //Establezco la ubicacion del pictureBox
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage; //La imagen que coloque se va a adaptar al tamaño de mi pictureBox
            imgNave.Image = Properties.Resources.nave;//Establezco la imagen en el pictureBox
            
        }

        Random aleatorioEnemigo = new Random(); //Creo objetos de la clase Random
        Random aleatorioPosX = new Random();
        Random aleatorioPosY = new Random();
        int codigoEnemigo;

        int posX, posY; 

        public void crearEnemigo()
        {
            codigoEnemigo = aleatorioEnemigo.Next(0, 3);

            imgNave = new PictureBox();
            imgNave.Size = new System.Drawing.Size(70, 70);
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNave.Tag = "naveEnemiga";
            

            posX = aleatorioPosX.Next(0, 850);
            posY = aleatorioPosY.Next(0, 400);
            imgNave.Location = new Point(posX, posY);



            switch (codigoEnemigo)
            {
                case 0:
                    vida = 100;
                    nombreNave = "Enemigo1";
                    
                    imgNave.Image = Properties.Resources.enemigo1;
                    break;
                case 1:
                    vida = 150;
                    nombreNave = "Enemigo2";
                    
                    imgNave.Image = Properties.Resources.enemigo2;
                    break;

                case 2:
                    vida = 200;
                    nombreNave = "Enemigo3";
                    
                    imgNave.Image = Properties.Resources.enemigo3;
                    break;
            }
        }
        
    }
}
