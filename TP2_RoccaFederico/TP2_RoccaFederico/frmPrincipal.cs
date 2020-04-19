using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_RoccaFederico
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void todosLosArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Creo nuevo form de alta de artículos
            frmAltaArticulo altaArticulo = new frmAltaArticulo();
            altaArticulo.MdiParent = this;
            altaArticulo.Show();
        }
    }
}
