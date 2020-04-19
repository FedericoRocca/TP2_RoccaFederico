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
                dgvArticulos.Columns[0].Visible = false;
                dgvArticulos.Columns[1].HeaderCell.Value = "Código";
                dgvArticulos.Columns[2].HeaderCell.Value = "Nombre";
                dgvArticulos.Columns[3].HeaderCell.Value = "Descripción";
                dgvArticulos.Columns[4].HeaderCell.Value = "Marca";
                dgvArticulos.Columns[5].HeaderCell.Value = "Categoría";
                dgvArticulos.Columns[6].HeaderCell.Value = "Imagen";
                dgvArticulos.Columns[7].HeaderCell.Value = "Precio";
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

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
