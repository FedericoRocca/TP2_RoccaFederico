using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataGateway;
using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> getMarcas()
        {
            try
            {
                DDBBGateway data = new DDBBGateway();
                data.prepareQuery("select id, Descripcion from MARCAS");
                data.sendQuery();
                List<Marca> marcas = new List<Marca>();
                while (data.getReader().Read())
                {
                    Marca aux = new Marca();
                    aux.id = (int)data.getReader()["id"];
                    aux.descripcion = (string)data.getReader()["Descripcion"];
                    marcas.Add(aux);
                }
                return marcas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
