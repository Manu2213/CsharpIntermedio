using ChsarpIntermedio._02_IEnumerable_IEnumerator_parte_1.Servicios.Auto;
using ChsarpIntermedio._02_IEnumerable_IEnumerator_parte_1.TiendaDeAutos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChsarpIntermedio._02_IEnumerable_IEnumerator_parte_1.Servicios.Tienda
{
    internal class ServiciosTiendaDeAutos : IServicioTiendaDeAutos
    {
        private TiendaDeAutos _tiendaDeAutos;
        IServicioDeAutomovil _serviciosDeAuto = null;

        public ServiciosTiendaDeAutos(List<IAutomovil> autosDisponibles)
        {
            _tiendaDeAutos = new TiendaDeAutos(autosDisponibles);
        }

        public void ModificarCostoDeAuto(IAutomovil auto, double costo)
        {
            auto.Costo = costo;
        }

        public void ModificarCostoFijoDeAuto(IAutomovil auto, double costoFijo)
        {
            auto.CostoFijo = costoFijo;
        }

        public void ModificarImpuestoDeAuto(IAutomovil auto, double impuesto)
        {
            auto.Impuesto = impuesto;
        }

        public void ModificarModeloDeAuto(IAutomovil auto, string modeloNuevo)
        {
            auto.Modelo = modeloNuevo;
        }

        public void MuestraInformacionDeAutosDisponibles<T>(Type tipoDeServicioDeAutomovil) where T: IServicioDeAutomovil
        {

            foreach (IAutomovil auto in _tiendaDeAutos)
            {
                // Crear una instancia del tipo de servicio proporcionado por el usuario
                if (tipoDeServicioDeAutomovil.GetInterface(nameof(IServicioDeAutomovil)) != null)
                {
                    T servicioDeAutomovil = (T)Activator.CreateInstance(tipoDeServicioDeAutomovil,auto)!;

                    // Ahora puedes usar servicioDeAutomovil como necesites
                    Console.WriteLine("Costo fijo: {0}, Impuestos{1}",auto.CostoFijo,auto.Impuesto);
                    servicioDeAutomovil!.MuestraInformacion();
                }
                else
                {
                    // Manejo de error si el tipo proporcionado no implementa IServicioDeAutomovil
                    Console.WriteLine("El tipo de servicio proporcionado no es válido.");
                }
            }
        }

        public IAutomovil VerAuto(string modelo)
        {
            foreach (IAutomovil auto in _tiendaDeAutos)
            {
                if (auto.Modelo == modelo) return auto;
            }
            return null;
        }

    }
}
