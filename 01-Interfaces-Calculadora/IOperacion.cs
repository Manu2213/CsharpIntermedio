using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChsarpIntermedio._01_Interfaces_Calculadora
{
    internal interface IOperacion
    {
        void Calcular(double a, double b);
        void Mostrar();

    }
}
