using ChsarpIntermedio._02_IEnumerable_IEnumerator_parte_1.TiendaDeAutos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChsarpIntermedio._02_IEnumerable_IEnumerator_parte_1.Servicios
{
    internal class TiendaDeAutos
    {
        private List<IAutomovil> _autosDisponibles;

        public TiendaDeAutos(List<IAutomovil> autosDisponibles)
        {
            _autosDisponibles = autosDisponibles;
            
        }
        public IEnumerator GetEnumerator()
        {
            return _autosDisponibles.GetEnumerator();
        }
    }
}
