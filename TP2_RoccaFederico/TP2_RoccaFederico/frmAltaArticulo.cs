using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace TP2_RoccaFederico
{
    public partial class frmAltaArticulo : Form
    {
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                //Primero, tengo que cargar los datos de los combo de Marca y Articulo para popularlos de información
                MarcaNegocio marcas = new MarcaNegocio();
                cmbMarca.DataSource = marcas.getDescripcionMarcas();

                CategoriaNegocio categorias = new CategoriaNegocio();
                cmbCategoria.DataSource = categorias.getDescripcionCategorias();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
