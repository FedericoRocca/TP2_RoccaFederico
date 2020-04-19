using Dominio;
using Negocio;
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
    public partial class frmListarArticulos : Form
    {
        public frmListarArticulos()
        {
            InitializeComponent();
        }

        private void frmListarArticulos_Load(object sender, EventArgs e)
        {
            // Cargo el grid con los articulos devueltos
            try
            {
                List<Articulo> articulos = new List<Articulo>();
                ArticuloNegocio artNegocio = new ArticuloNegocio();

                articulos = artNegocio.getArticulos();
                dgvArticulos.DataSource = articulos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
