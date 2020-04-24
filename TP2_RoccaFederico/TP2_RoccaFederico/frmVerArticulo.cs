using Dominio;
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

namespace TP2_RoccaFederico
{
    public partial class frmVerArticulo : Form
    {
        private Articulo articulo { get; set; }
        public frmVerArticulo( Articulo _articulo )
        {
            articulo = _articulo;
            InitializeComponent();
        }

        private void frmVerArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                txbCodigo.Text = articulo.codigo;
                txbDescripcion.Text = articulo.descripcion;
                txbImagen.Text = articulo.imagen;
                txbNombre.Text = articulo.nombre;
                txbPrecio.Text = articulo.precio.ToString();
                cmbCategoria.ValueMember = "id";
                cmbCategoria.DisplayMember = "descripcion";
                cmbMarca.ValueMember = "id";
                cmbMarca.DisplayMember = "descripcion";
                cmbCategoria.SelectedValue = articulo.categoria.id;
                cmbMarca.SelectedValue = articulo.marca.id;

                ptbImagen.Load(articulo.imagen);
            }
            catch(FileNotFoundException)
            {
                ptbImagen.Image = ptbImagen.ErrorImage;
                MessageBox.Show("La imagen cargada en el artículo no fue encontrada por lo que no se mostrará.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
