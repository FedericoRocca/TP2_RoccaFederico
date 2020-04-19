using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataGateway;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<string> getDescripcionMarcas()
        {
            try
            {
                DDBBGateway data = new DDBBGateway();
                data.prepareQuery("select Descripcion from MARCAS");
                data.sendQuery();
                List<string> descripciones = new List<string>();

                while(data.getReader().Read())
                {
                    descripciones.Add( (string)data.getReader()["Descripcion"] );
                }

                return descripciones;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
