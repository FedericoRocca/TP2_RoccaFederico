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
using Dominio;

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
                List<string> descripciones = new List<string>();
                foreach (Categoria cat in categorias.getCategorias())
                {
                    descripciones.Add(cat.descripcion);
                }
                cmbCategoria.DataSource = descripciones;

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtengo todos los datos que cargó el usuario y los guardo en un objeto
                Articulo articulo = new Articulo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
