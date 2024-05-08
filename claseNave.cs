using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryIrustaSantiago
{
    public class claseNave
    {
        public string nombreNave;
        public int vida;
        public PictureBox imgNave;

        public claseNave()
        {
            vida = 0;
            nombreNave = "";
        }

        public void crearJugador(string nombre)
        {
            vida = 100;
            nombreNave = nombre;

            imgNave = new PictureBox();
            imgNave.Size = new System.Drawing.Size(100, 100);
            imgNave.Location = new Point(370, 700);
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNave.Image = Properties.Resources.nave;
        }

        Random aleatorioEnemigo = new Random();
        Random aleatorioPosX = new Random();
        Random aleatorioPosY = new Random();
        int codigoEnemigo;

        int posX, posY;

        public void crearEnemigo()
        {
            codigoEnemigo = aleatorioEnemigo.Next(0, 2);

            imgNave = new PictureBox();
            imgNave.Size = new System.Drawing.Size(80, 80);
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNave.Tag = "naveEnemiga";

            posX = aleatorioPosX.Next(0, 400);
            posY = aleatorioPosY.Next(0, 200);
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
            }
        }
        
    }
}
