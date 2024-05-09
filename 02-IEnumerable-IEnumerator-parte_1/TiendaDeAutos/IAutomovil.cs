using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChsarpIntermedio._02_IEnumerable_IEnumerator_parte_1.TiendaDeAutos
{
    internal interface IAutomovil
    {
        double Costo { get; set; }
        string Modelo { get; set; }
        double CostoFijo { get; set; }
        double Impuesto { get; set; }
        double Tenencia { get; }
    }
}
