using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ChsarpIntermedio._01_Interfaces_Calculadora
{
    internal class Suma : IOperacion
    {
        private double r = 0;
        private ArrayList resultados = new ArrayList();
        public void Calcular(double a, double b)
        {
            r = a + b;
        }

        public void Mostrar()
        {
            Console.WriteLine("Resultado Sumar: {0}",r);
            resultados.Add(r);  
        }

        public void MostrarResultado()
        {
            foreach (double r in resultados)
            {    
                    Console.WriteLine();
               
            }
        }
    }
}
