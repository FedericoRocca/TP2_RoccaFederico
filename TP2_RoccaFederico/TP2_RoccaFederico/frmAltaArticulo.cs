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
using System.IO;

namespace TP2_RoccaFederico
{
    public partial class frmAltaArticulo : Form
    {
        private bool isModification;
        private Articulo registro = new Articulo();
        public frmAltaArticulo()
        {
            isModification = false;
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo articuloAModificar)
        {
            isModification = true;
            registro = articuloAModificar;
            InitializeComponent();

        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                //Primero, tengo que cargar los datos de los combo de Marca y Articulo para popularlos de información
                MarcaNegocio marcas = new MarcaNegocio();
                cmbMarca.DataSource = marcas.getMarcas();

                CategoriaNegocio categorias = new CategoriaNegocio();
                cmbCategoria.DataSource = categorias.getCategorias();

                if( isModification )
                {
                    txbCodigo.Text = registro.codigo;
                    txbDescripcion.Text = registro.descripcion;
                    txbImagen.Text = registro.imagen;
                    txbNombre.Text = registro.nombre;
                    cmbCategoria.SelectedIndex = registro.categoria.id -1;
                    cmbMarca.SelectedIndex = registro.marca.id -1;
                    txbCodigo.ReadOnly = true;
                }

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
                // Obtengo todos los datos que cargó el usuario y los guardo en un objeto, si están vacios arrojo una excepción del tipo InvalidDataException con una descripción del error
                Articulo articulo = new Articulo();

                if (txbCodigo.Text.Trim() == "")
                {
                    throw new InvalidDataException("El código ingresado es incorrecto");
                }
                else
                {
                    articulo.codigo = txbCodigo.Text;
                }

                if (txbNombre.Text.Trim() == "")
                {
                    throw new InvalidDataException("El nombre ingresado es incorrecto");
                }
                else
                {
                    articulo.nombre = txbNombre.Text;
                }

                if (txbDescripcion.Text.Trim() == "")
                {
                    throw new InvalidDataException("La descripción ingresada es incorrecta");
                }
                else
                {
                    articulo.descripcion = txbDescripcion.Text;
                }

                articulo.marca = (Marca)cmbMarca.SelectedItem;
                articulo.categoria = (Categoria)cmbCategoria.SelectedItem;

                if( txbImagen.Text.Trim() == "" )
                {
                    throw new InvalidDataException("La URL de la imagen ingresada es incorrecta");
                }
                else
                {
                    articulo.imagen = txbImagen.Text;
                }

                if (nudPrecio.Text.Trim() == "")
                {
                    throw new InvalidDataException("El precio ingresado es incorrecto");
                }
                else
                {
                    articulo.precio = double.Parse(nudPrecio.Text);
                }

                ArticuloNegocio artNegocio = new ArticuloNegocio();
                if( isModification )
                {
                    if (artNegocio.modificarArticulo(articulo) == false)
                    {
                        throw new ApplicationException("Error al modificar el artículo.");
                    }
                    else
                    {
                        MessageBox.Show("El artículo fue modificado correctamente");
                        this.Dispose();
                    }
                }
                else
                {
                    if (artNegocio.altaNuevoArticulo(articulo) == false)
                    {
                        throw new ApplicationException("Error al dar de alta el artículo.");
                    }
                    else
                    {
                        MessageBox.Show("El artículo fue dado de alta correctamente");
                        this.Dispose();
                    }
                }

            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
