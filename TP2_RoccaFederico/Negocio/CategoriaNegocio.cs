using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataGateway;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<string> getDescripcionCategorias()
        {
            try
            {
                DDBBGateway data = new DDBBGateway();
                data.prepareQuery("select Descripcion from CATEGORIAS");
                data.sendQuery();
                List<string> categorias = new List<string>();
                while(data.getReader().Read())
                {
                    categorias.Add( (string)data.getReader()["Descripcion"] );
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
