﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChsarpIntermedio._01_Interfaces_Calculadora
{
    internal class Resta : IOperacion
    {
        private double r = 0;
        public void Calcular(double a, double b)
        {
            r = a - b;
        }

        public void Mostrar()
        {
            Console.WriteLine("Resultado Resta: {0}",r);
        }
    }
}
