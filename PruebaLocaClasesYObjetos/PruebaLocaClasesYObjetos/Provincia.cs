using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLocaClasesYObjetos
{
    class Provincia
    {
        public string Nombre { get; set; }
        public decimal CantHabitantes { get; set; }
        public decimal MetrosCuadrados { get; set; }
        public List<Ciudad> ListaCiudadesDeProvincias;
    }
}
