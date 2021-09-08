using Calculadora.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Modelos
{
    public class Calculator
    {
        public decimal n1;
        public decimal n2;
        /// <summary>
        /// Constructor simple de Calculator pasando 2 parámetros para las operaciones
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        public Calculator(decimal n1, decimal n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
    }
}
