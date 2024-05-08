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
        Bitmap bmpFirma;

        public frmFirma()
        {
            InitializeComponent();
        }

        private void pbFirma_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                using (Graphics papel = pbFirma.CreateGraphics())
                {
                    papel.FillEllipse(Brushes.Black, e.X, e.Y, 10, 10);
                }


                using (Graphics miFirma = Graphics.FromImage(bmpFirma))
                {
                    miFirma.FillEllipse(Brushes.Black, e.X, e.Y, 10, 10);
                }
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreCarpeta = "FIRMAS";
                string carpetaDestino = Path.Combine(Application.StartupPath, nombreCarpeta);

                if (!Directory.Exists(carpetaDestino))
                {
                    Directory.CreateDirectory(carpetaDestino);
                }

                string fechaHora = DateTime.Now.ToString("yyyy-MM-dd_HH.mm");
                string nombreArchivo = fechaHora + ".png";
                string rutaCompleta = Path.Combine(carpetaDestino, nombreArchivo);

                bmpFirma.Save(rutaCompleta);

                MessageBox.Show("Imagen guardada con exito");

                pbFirma.Refresh();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void frmFirma_Load(object sender, EventArgs e)
        {
            bmpFirma = new Bitmap(pbFirma.Width, pbFirma.Height);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            pbFirma.Refresh();
        }
    }
}
