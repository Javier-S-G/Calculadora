using Calculadora.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Interfaces
{
    interface IOperationable
    {
        /// <summary>
        /// Operaciones que se utilizarán en OperationService
        /// </summary>
        
        public decimal Suma(Calculator calc);

        public decimal Resta(Calculator calc);

        public decimal Multiplicacion(Calculator calc);

        public Tuple<decimal, decimal> Division(Calculator calc);
    }
}
