using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataGateway;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> getCategorias()
        {
            try
            {
                DDBBGateway data = new DDBBGateway();
                data.prepareQuery("select id, Descripcion from CATEGORIAS");
                data.sendQuery();
                List<Categoria> categorias = new List<Categoria>();
                while(data.getReader().Read())
                {
                    Categoria aux = new Categoria();
                    aux.id = (int)data.getReader()["id"];
                    aux.descripcion = (string)data.getReader()["Descripcion"];
                    categorias.Add( aux );
                }
                return categorias;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
