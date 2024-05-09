using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChsarpIntermedio._01_Interfaces_Calculadora
{
    internal abstract class OperacionesBasicas
    {
        private IOperacion operacion=null;
        public OperacionesBasicas() { }

        public void Resultado(double a, double b)
        {
            operacion.Calcular(a, b);
            operacion.Mostrar();
        }
        public void Sumar()
        {
            operacion = (IOperacion)new Suma();
        }

        public void Restar()
        {
            operacion = (IOperacion)new Resta();
        }

        public void Multiplicar()
        {
            operacion = (IOperacion)new Multiplicacion();
        }

        public void Dividir()
        {
            operacion = (IOperacion)new Division();

        }
    }
}
