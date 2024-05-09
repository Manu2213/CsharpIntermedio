using ChsarpIntermedio._02_IEnumerable_IEnumerator_parte_1.Servicios.Auto;
using ChsarpIntermedio._02_IEnumerable_IEnumerator_parte_1.Servicios.Tienda;
using ChsarpIntermedio._02_IEnumerable_IEnumerator_parte_1.TiendaDeAutos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChsarpIntermedio._02_IEnumerable_IEnumerator_parte_1
{
     internal  class GestionarTienda
    {
        private static List<IAutomovil> _autosDisponibles = new List<IAutomovil>
        {
            new Auto ("Fiat",10500),
            new Auto ("Toyota",20500),
            new Auto ("Peugeot",18500),
            new Auto ("WV",15500)
        };
        
        private static IServicioTiendaDeAutos servicioTiendaDeAutos = new ServiciosTiendaDeAutos (_autosDisponibles);

        public static void Gestionar()
        {
            Type tipoServicioAutomovil = typeof(ServiciosDeAutomovil);
            servicioTiendaDeAutos.MuestraInformacionDeAutosDisponibles<IServicioDeAutomovil>(tipoServicioAutomovil);
            Console.WriteLine("<...................................>");


            foreach (IAutomovil auto in _autosDisponibles)
            {
                servicioTiendaDeAutos.ModificarImpuestoDeAuto(auto, 0.10);
            }

            servicioTiendaDeAutos.MuestraInformacionDeAutosDisponibles<IServicioDeAutomovil>(tipoServicioAutomovil);
            Console.WriteLine("<...................................>");

            _autosDisponibles.Add(new Auto("Prueba", 15500));
            servicioTiendaDeAutos.MuestraInformacionDeAutosDisponibles<IServicioDeAutomovil>(tipoServicioAutomovil);
            Console.WriteLine("<...................................>");

            servicioTiendaDeAutos.VerAuto("Prueba").Impuesto = 0.10;
            servicioTiendaDeAutos.ModificarCostoFijoDeAuto(servicioTiendaDeAutos.VerAuto("Prueba"), 0);
            servicioTiendaDeAutos.MuestraInformacionDeAutosDisponibles<IServicioDeAutomovil>(tipoServicioAutomovil);
            Console.WriteLine("<...................................>");

        }
    }
}
