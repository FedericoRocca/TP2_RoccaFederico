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
    }
}
