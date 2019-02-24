using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreExamenProgaII.AltoVAlyrio
{
    public class Bodega 
    {
        public string NumerodeBodega { get; set; }

        public string UbicacionBodega { get; set; }

        public string  Departamento { get; set; }

        public static implicit operator List<object>(Bodega v)
        {
            throw new NotImplementedException();
        }
    }
}
