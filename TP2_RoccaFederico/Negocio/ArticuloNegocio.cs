using DataGateway;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public bool altaNuevoArticulo(Articulo articulo)
        {
			try
			{

				DDBBGateway data = new DDBBGateway();
				data.prepareStatement("insert into ARTICULOS values (@codigo, @nombre, @descripcion, @idMarca, @idCategoria, @imagen, @precio);");
				data.addParameter("@codigo", articulo.codigo);
				data.addParameter("@nombre", articulo.nombre);
				data.addParameter("@descripcion", articulo.descripcion);
				data.addParameter("@idMarca", articulo.marca.id);
				data.addParameter("@idCategoria", articulo.categoria.id);
				data.addParameter("@imagen", articulo.imagen);
				data.addParameter("@precio", articulo.precio);
				data.sendStatement();
				if (data.getAffectedRows() <= 0)
				{
					return false;
				}
				else
				{
					return true;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
        }

        public List<Articulo> getArticulos()
        {
			try
			{
				List<Articulo> articulos = new List<Articulo>();

				DDBBGateway data = new DDBBGateway();
				data.prepareQuery("select ARTICULOS.Id, ARTICULOS.Codigo, ARTICULOS.Nombre, ARTICULOS.Descripcion, MARCAS.Id as 'IdMarca', " +
					              "MARCAS.Descripcion as 'DescripcionMarca', CATEGORIAS.Id as 'IdCategoria', CATEGORIAS.Descripcion as " +
								  "'DescripcionCategoria', ARTICULOS.ImagenUrl, ARTICULOS.Precio from ARTICULOS inner join MARCAS on ( " +
								  "ARTICULOS.IdMarca = MARCAS.Id ) inner join CATEGORIAS on ( ARTICULOS.IdCategoria = CATEGORIAS.Id )");
				data.sendQuery();
				while( data.getReader().Read() )
				{
					Articulo aux = new Articulo();
					aux.id = (int)data.getReader()["Id"];
					aux.codigo = (string)data.getReader()["Codigo"];
					aux.nombre = (string)data.getReader()["Nombre"];
					aux.descripcion = (string)data.getReader()["Descripcion"];
					aux.marca.id = (int)data.getReader()["IdMarca"];
					aux.marca.descripcion = (string)data.getReader()["DescripcionMarca"];
					aux.categoria.id = (int)data.getReader()["IdCategoria"];
					aux.categoria.descripcion = (string)data.getReader()["DescripcionCategoria"];
					aux.imagen = (string)data.getReader()["ImagenUrl"];
					aux.precio = double.Parse(data.getReader()["Precio"].ToString());

					articulos.Add(aux);
				}

				return articulos;
			}
			catch (Exception ex)
			{
				throw ex;
			}
        }

		public bool eliminaciónFisicaArticulo(Articulo aBorrar)
		{
			try
			{
				DDBBGateway data = new DDBBGateway();
				data.prepareQuery("delete from ARTICULOS where Codigo = @codigo");
				data.addParameter("@codigo", aBorrar.codigo);
				data.sendStatement();
				if( data.getAffectedRows() <= 0 )
				{
					return false;
				}	
				else
				{
					return true;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Articulo> getArticulosBySearch(string term)
		{
			try
			{
				List<Articulo> resultados = new List<Articulo>();
				DDBBGateway data = new DDBBGateway();
				data.prepareQuery("select ARTICULOS.Id, ARTICULOS.Codigo, ARTICULOS.Nombre, ARTICULOS.Descripcion, " +
					"MARCAS.Id as 'IdMarca', MARCAS.Descripcion as 'DescripcionMarca', CATEGORIAS.Id as 'IdCategoria'," +
					" CATEGORIAS.Descripcion as 'DescripcionCategoria', ARTICULOS.ImagenUrl, ARTICULOS.Precio from ARTICULOS " +
					"inner join MARCAS on ( ARTICULOS.IdMarca = MARCAS.Id ) inner join CATEGORIAS on ( ARTICULOS.IdCategoria " +
					"= CATEGORIAS.Id ) where ARTICULOS.Codigo like '%' + @termino+ '%' or ARTICULOS.Nombre like '%' + @termino+ '%' or " +
					"MARCAS.Descripcion like '%' + @termino+ '%' or CATEGORIAS.Descripcion like '%' + @termino+ '%' or ARTICULOS.Precio " +
					"like '%' + @termino+ '%'");
				data.addParameter("@termino", term);
				data.sendQuery();
				while(data.getReader().Read())
				{
					Articulo aux = new Articulo();
					aux.id = (int)data.getReader()["Id"];
					aux.codigo = (string)data.getReader()["Codigo"];
					aux.nombre = (string)data.getReader()["Nombre"];
					aux.descripcion = (string)data.getReader()["Descripcion"];
					aux.marca.id = (int)data.getReader()["IdMarca"];
					aux.marca.descripcion = (string)data.getReader()["DescripcionMarca"];
					aux.categoria.id = (int)data.getReader()["IdCategoria"];
					aux.categoria.descripcion = (string)data.getReader()["DescripcionCategoria"];
					aux.imagen = (string)data.getReader()["ImagenUrl"];
					aux.precio = double.Parse(data.getReader()["Precio"].ToString());

					resultados.Add(aux);
				}

				return resultados;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public bool modificarArticulo(Articulo articulo)
		{
			try
			{
				DDBBGateway data = new DDBBGateway();
				data.prepareStatement("update ARTICULOS set ARTICULOS.Nombre = @nombre, " +
					"ARTICULOS.Descripcion = @descripcion, ARTICULOS.IdMarca = @idMarca, ARTICULOS.IdCategoria = @idCategoria, " +
					"ARTICULOS.ImagenUrl = @imagenUrl, ARTICULOS.Precio = @precio where ARTICULOS.Codigo = @codigo");
				data.addParameter("@nombre", articulo.nombre);
				data.addParameter("@descripcion", articulo.descripcion);
				data.addParameter("@idMarca", articulo.marca.id);
				data.addParameter("@idCategoria", articulo.categoria.id);
				data.addParameter("@imagenUrl", articulo.imagen);
				data.addParameter("@precio", articulo.precio);
				data.addParameter("@codigo", articulo.codigo);
				data.sendStatement();
				if( data.getAffectedRows() <= 0 )
				{
					return false;
				}
				else
				{
					return true;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
