using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace TP2_RoccaFederico
{
    public partial class frmBuscarArticulo : Form
    {
        public frmBuscarArticulo()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Buscamos articulos
                doSearch();                
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvResultados.Rows.Count > 0)
                {
                    DialogResult elección = MessageBox.Show("Está seguro que desea eliminar el artículo?", "Atención", MessageBoxButtons.OKCancel);
                    if( elección == DialogResult.OK )
                    {
                        ArticuloNegocio artNegocio = new ArticuloNegocio();
                        if(artNegocio.eliminaciónFisicaArticulo((Articulo)dgvResultados.CurrentRow.DataBoundItem) == true)
                        {
                            MessageBox.Show("El artículo fue eliminado con éxito");
                            doSearch();
                        }
                        else
                        {
                            MessageBox.Show("El artículo no pudo ser eliminado");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if( dgvResultados.Rows.Count > 0 )
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void doSearch()
        {
            try
            {
                // Buscamos articulos
                string terminoDeBusqueda = txbBuscar.Text.Trim();

                ArticuloNegocio artNegocio = new ArticuloNegocio();
                List<Articulo> resultados = artNegocio.getArticulosBySearch(terminoDeBusqueda);
                if (resultados.Count <= 0)
                {
                    dgvResultados.DataSource = null;
                    MessageBox.Show("La busqueda no produjo resultados");
                }
                else
                {
                    dgvResultados.DataSource = resultados;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
