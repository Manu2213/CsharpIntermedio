using ChsarpIntermedio._02_IEnumerable_IEnumerator_parte_1.Servicios.Auto;
using ChsarpIntermedio._02_IEnumerable_IEnumerator_parte_1.TiendaDeAutos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChsarpIntermedio._02_IEnumerable_IEnumerator_parte_1.Servicios.Tienda
{
    internal interface IServicioTiendaDeAutos 
    {
        void MuestraInformacionDeAutosDisponibles<T>(Type tipoDeServicioDeAutomovil) where T : IServicioDeAutomovil;
        void ModificarCostoDeAuto(IAutomovil auto, double costo);
        void ModificarModeloDeAuto(IAutomovil auto, string modeloNuevo);
        void ModificarCostoFijoDeAuto(IAutomovil auto, double costoFijo);
        void ModificarImpuestoDeAuto(IAutomovil auto, double impuesto);
        IAutomovil VerAuto(string modelo);

    }
}
