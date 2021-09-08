using Calculadora.Interfaces;
using Calculadora.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Services
{
    public class OperationService : IOperationable
    {

        public decimal Suma(Calculator calc)
        {
            return calc.n1 + calc.n2;
        }

        public decimal Resta(Calculator calc)
        {
            return calc.n1 - calc.n2;
        }

        public decimal Multiplicacion(Calculator calc)
        {
            decimal result = 0;
            for (decimal i = 0; i < calc.n2; i++)
            {
                result = result + calc.n1;
            }
            
            return result;
        }

        public Tuple<decimal, decimal> Division(Calculator calc)
        {
            try
            {
                decimal remainder;
                decimal quotient;
                quotient = (calc.n1 / calc.n2);
                remainder = (calc.n1 % calc.n2);
                var tupla = new Tuple<decimal, decimal>(quotient, remainder);

                return tupla;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error dividido entre 0");
                return null;
            }
                
        }
    }
}
