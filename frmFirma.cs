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
    public partial class frmFirma : Form
    {
        Bitmap bmpFirma; //Declaro una variable para almacenar la firma como un objeto Bitmap

        public frmFirma()
        {
            InitializeComponent(); //Se inicializan los componentes del formulario
        }

        private void pbFirma_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            {
                using (Graphics papel = pbFirma.CreateGraphics()) //Creo un objeto del tipo Graphics para dibujar en el pictureBox
                {
                    papel.FillEllipse(Brushes.Black, e.X, e.Y, 10, 10);
                }


                using (Graphics miFirma = Graphics.FromImage(bmpFirma)) //Creo un objeto Graphics para dibujar en el objeto Bitmap
                {
                    miFirma.FillEllipse(Brushes.Black, e.X, e.Y, 10, 10);
                }
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreCarpeta = "FIRMAS"; //Nombre de la carpeta donde se guardaran las firmas
                string carpetaDestino = Path.Combine(Application.StartupPath, nombreCarpeta); //Ruta completa de la carpeta destino
                                                                                              

                if (!Directory.Exists(carpetaDestino))
                {
                    Directory.CreateDirectory(carpetaDestino); //Creo la carpeta si no existe
                }

                string fechaHora = DateTime.Now.ToString("yyyy-MM-dd_HH.mm"); //Obtengo fecha y hora actual
                string nombreArchivo = fechaHora + ".png"; //Creo un nombre de archivo utilizando la fecha y hora
                string rutaCompleta = Path.Combine(carpetaDestino, nombreArchivo); //Obtengo la ruta completa del archivo de imagen

                bmpFirma.Save(rutaCompleta); //Guado la firma en la ruta especificada

                MessageBox.Show("Imagen guardada con exito");

                pbFirma.Refresh(); //Actualizo el PictureBox
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString()); 
            }
        }

        private void frmFirma_Load(object sender, EventArgs e)
        {
            bmpFirma = new Bitmap(pbFirma.Width, pbFirma.Height); //Inicializo el objeto Bitmap para almacenar la firma
                                                                  //con el tamaño del PictureBox
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            pbFirma.Refresh();
        }
    }
}
