using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryIrustaSantiago
{
    internal class claseDisparo
    {
        public PictureBox imgDisparo;

        public claseDisparo()
        {
            imgDisparo = new PictureBox();
            imgDisparo.Size = new System.Drawing.Size(5, 5);
            imgDisparo.BackColor = Color.Red;
            imgDisparo.SizeMode = PictureBoxSizeMode.StretchImage;
            imgDisparo.Tag = "disparo";
        }

        public void CrearDisparo(Point location)
        {
            imgDisparo.Location = location;
        }
    }
}
