using Calculadora.Modelos;
using Calculadora.Services;
using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n1;
            string symbol = null;
            decimal n2;

            Console.WriteLine("  * * Calculadora * * ");
            Console.WriteLine("-------------------------");
            Console.WriteLine("  Inserta el primer número");
            n1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("  ¿Qué operación quieres hacer?   +  -  *  / ");
            symbol = Console.ReadLine();
            Console.WriteLine("  Inserta el segundo número");
            n2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("-------------------------");
            Console.WriteLine("  El resultado es: ");

            Calculator calc = new Calculator(n1, n2);

            OperationService opop = new OperationService();

            // switch de control para comprobar el símbolo que hemos introducizo por teclado
            switch (symbol)
            {
                case "+":
                    Console.WriteLine(opop.Suma(calc));
                    break;

                case "-":
                    Console.WriteLine(opop.Resta(calc));
                    break;

                case "*":
                    Console.WriteLine(opop.Multiplicacion(calc));
                    break;

                case "/":
                    Console.WriteLine(opop.Division(calc));
                    break;

                default:
                    Console.WriteLine("Has puesto mal el símbolo tío :v");
                    break;
            }
        }
    }
}
