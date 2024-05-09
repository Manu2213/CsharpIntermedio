using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChsarpIntermedio._01_Interfaces_Calculadora
{
    internal class CaculadoraBasica : OperacionesBasicas
    {
        public static void Ejecutar()
        {
            int opcion = 0;
            double valA = 0.0;
            double valB = 0.0;

            string valor = "";

            CaculadoraBasica calculadora = new CaculadoraBasica();

            while (opcion < 5)
            {
                Console.WriteLine("\n1-sumar,2-restar,3-multiplicar,4-Dividir");
                Console.WriteLine("\nOpcion (cualquier otro numero para salir): ");
                try
                {
                    valor = Console.ReadLine();
                    opcion = Convert.ToInt32(valor);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nINGRESE UN NUMERO\n");
                    continue;
                }


                if (opcion <= 4)
                {
                    Console.WriteLine("Dame el valor de a"); ;
                    valor = Console.ReadLine();
                    valA = Convert.ToDouble(valor);

                    Console.WriteLine("Dame el valor de b"); ;
                    valor = Console.ReadLine();
                    valB = Convert.ToDouble(valor);

                    switch (opcion)
                    {
                        case 1: calculadora.Sumar(); break;
                        case 2: calculadora.Restar(); break;
                        case 3: calculadora.Multiplicar(); break;
                        case 4: calculadora.Dividir(); break;
                    }

                    calculadora.Resultado(valA, valB);
                }


            }
        }
    }
}
