﻿using System;
using System.Web.UI;
using Negocio;
using Dominio;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Linq;

namespace TP3_RoccaFederico
{
    public partial class _Default : Page
    {
        public List<Articulo> articulos = new List<Articulo>();
        public List<Categoria> categorias = new List<Categoria>();
        public CarritoArticulos miCarrito = new CarritoArticulos();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                CategoriaNegocio catNegocio = new CategoriaNegocio();
                categorias = catNegocio.getCategorias();

                ArticuloNegocio artNegocio = new ArticuloNegocio();
                articulos = artNegocio.getArticulos();

                if (Session[Session.SessionID + "carrito"] != null)
                {
                    miCarrito = (CarritoArticulos)Session[Session.SessionID + "carrito"];
                }

                if (!IsPostBack)
                {

                    articulosRepeater.DataSource = articulos;
                    articulosRepeater.DataBind();

                    repeaterCategorias.DataSource = categorias;
                    repeaterCategorias.DataBind();
                }
            }
            catch (Exception ex)
            {
                Session.Add(Session.SessionID + "exception", ex);
                Response.Redirect("error.aspx");
            }
        }

        protected void btnAgregarAlCarrito_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session[Session.SessionID + "carrito"] != null)
                {
                    miCarrito = (CarritoArticulos)Session[Session.SessionID + "carrito"];
                }
                ArticuloNegocio artNegocio = new ArticuloNegocio();
                int idArticulo = int.Parse(((Button)sender).CommandArgument);
                miCarrito.elementos.Add(artNegocio.getArticuloByID(idArticulo));
                Session.Add(Session.SessionID + "carrito", miCarrito);
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#modalArticuloAgregadoAlCarrito').modal();", true);
            }
            catch (Exception ex)
            {
                Session.Add(Session.SessionID + "exception", ex);
                Response.Redirect("error.aspx");
            }
        }

        protected void btnFiltrarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                int idCategoria = int.Parse(((Button)sender).CommandArgument);
                articulos = articulos.Where(x => x.categoria.id == idCategoria).ToList();
                articulosRepeater.DataSource = articulos;
                articulosRepeater.DataBind();
            }
            catch (Exception ex)
            {
                Session.Add(Session.SessionID + "exception", ex);
                Response.Redirect("error.aspx");
            }
        }

        protected void btnTodasCategorias_Click(object sender, EventArgs e)
        {
            try
            {
                articulosRepeater.DataSource = articulos;
                articulosRepeater.DataBind();
            }
            catch (Exception ex)
            {
                Session.Add(Session.SessionID + "exception", ex);
                Response.Redirect("error.aspx");
            }
        }

    }
}