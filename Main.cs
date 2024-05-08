using System;
using System.Windows.Forms;

namespace pryIrustaSantiago
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFirma frm = new frmFirma();
            frm.ShowDialog();
        }

        private void galagaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNombreJugador frm = new frmNombreJugador();
            frm.ShowDialog();

            
        }
    }
}
