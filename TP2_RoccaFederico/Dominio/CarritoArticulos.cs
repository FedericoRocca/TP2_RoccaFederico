using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class CarritoArticulos
    {
        public List<Articulo> elementos { get; set; }
        public CarritoArticulos()
        {
            elementos = new List<Articulo>();
        }
    }
}
