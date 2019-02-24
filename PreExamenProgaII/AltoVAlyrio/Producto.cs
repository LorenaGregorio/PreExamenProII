using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreExamenProgaII.AltoVAlyrio
{
    public class Producto :Categoria
    {
       public string DescripciondelProducto { get; set; }

        public string Marca { get; set; }

        public double Precio { get; set; }

        public bool Refrigerado { get; set; }

        public DateTime Fecha { get; set; }

        public string Peso { get; set; }


       
        public List<Bodega> Bodegas { get; set; }

    }
}
