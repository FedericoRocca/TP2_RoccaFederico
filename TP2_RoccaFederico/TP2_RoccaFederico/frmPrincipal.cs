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
            try
            {
                frmListarArticulos listadoArticulos = new frmListarArticulos();
                if( !Util.checkIfFormIsAlreadyopen( listadoArticulos.GetType() ) )
                {
                    listadoArticulos.MdiParent = this;
                    listadoArticulos.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void agregarArtículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Si no está abierto abro el nuevo form de alta de articulos
            frmAltaArticulo altaArticulo = new frmAltaArticulo();
            if ( !Util.checkIfFormIsAlreadyopen(altaArticulo.GetType()) )
            {
                
                altaArticulo.MdiParent = this;
                altaArticulo.Show();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
