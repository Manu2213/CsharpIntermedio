using ChsarpIntermedio._02_IEnumerable_IEnumerator_parte_1.TiendaDeAutos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChsarpIntermedio._02_IEnumerable_IEnumerator_parte_1.Servicios.Auto
{
    internal class ServiciosDeAutomovil : IServicioDeAutomovil
    {
        IAutomovil _automovil;

        public ServiciosDeAutomovil(IAutomovil automovil)
        {
            _automovil = automovil;
        }

        
        public void MuestraInformacion()
        {
            string modelo = _automovil.Modelo;
            double costo = _automovil.Costo;
            double tenencia = _automovil.Tenencia;

            Console.WriteLine("Modelo: {0}", modelo);
            Console.WriteLine("Costo: {0}, Tenencia: {1}", costo, tenencia);
            Console.WriteLine("Total: {0}", costo + tenencia);
            Console.WriteLine("-------------------");
        }

    }
}
