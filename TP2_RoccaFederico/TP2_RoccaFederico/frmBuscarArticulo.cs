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
                string terminoDeBusqueda = txbBuscar.Text.Trim();
                if (terminoDeBusqueda.Length <= 0)
                {
                    throw new InvalidDataException("El texto ingresado para la busqueda no es válido");
                }
                else
                {
                    ArticuloNegocio artNegocio = new ArticuloNegocio();
                    List<Articulo> resultados = artNegocio.getArticulosBySearch(terminoDeBusqueda);
                    if( resultados.Count <= 0 )
                    {
                        dgvResultados.DataSource = null; 
                        MessageBox.Show("La busqueda no produjo resultados");
                    }
                    else
                    {
                        dgvResultados.DataSource = resultados;
                    }
                }
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
    }
}
