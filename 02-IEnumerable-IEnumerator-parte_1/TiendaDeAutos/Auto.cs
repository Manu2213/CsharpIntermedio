using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ChsarpIntermedio._02_IEnumerable_IEnumerator_parte_1.TiendaDeAutos
{
    internal class Auto:IAutomovil
    {
        double _costo;
        string _modelo;
        private double _tenencia = 0;
        private double _costoFijo;
        private double _impuesto;

        public Auto(string modelo, double costo, double costoFijo = 5000, double impuesto = 0.05)
        {
            _costo = costo;
            _modelo = modelo;
            _costoFijo = costoFijo;
            _impuesto = impuesto;
            CalcularTenencia();
        }

        public double Costo { get => _costo; set => _costo = value; }
        public string Modelo { get => _modelo; set => _modelo = value; }
        public double Tenencia => _tenencia;

        public double CostoFijo
        {
            get => _costoFijo;
            set
            {
                _costoFijo = value;
                CalcularTenencia();
            }
        }
        public double Impuesto
        {
            get => _impuesto;
            set
            {
                _impuesto = value;
                CalcularTenencia();
            }
        }

        private void CalcularTenencia() => _tenencia = _costoFijo + _costo * _impuesto;



    }
}
