using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeropuertos_Argentina_20._000
{
    class Vuelo
    {

        public string Nombre { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime Fecha { get; set; }
        public string Aerolínea { get; set; }
        public int NúmPuerta { get; set; }
        public decimal Precio { get; set; }
        public decimal CantPasajeros { get; set; }
        public decimal Recaudación { get; set; }
    }
}
