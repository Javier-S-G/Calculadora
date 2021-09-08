using Calculadora.Modelos;
using Calculadora.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculadora.Test
{
    [TestClass]
    public class UnitTest1
    {
        OperationService op = new OperationService();
        
            

        Calculator calc = new Calculator(0,0);

        /// <summary>
        /// Happy path
        /// </summary>
        //before all before each
        [TestMethod]
        public void TestSuma_Ok()
        {
            calc.n1 = 10;
            calc.n2 = 5;
            var s = op.Suma(calc);
            Assert.AreEqual(15, s);
        }

        [TestMethod]
        public void TestResta_Ok()
        {
            calc.n1 = 10;
            calc.n2 = 5;
            var s = op.Resta(calc);
            Assert.AreEqual(5, s);
        }

        [TestMethod]
        public void TestMultiplication_Ok()
        {
            calc.n1 = 10;
            calc.n2 = 5;
            var s = op.Multiplicacion(calc);
            Assert.AreEqual(50, s);
        }

        [TestMethod]
        public void TestDivision_Cociente_Ok()
        {
            calc.n1 = 10;
            calc.n2 = 5;
            var s = op.Division(calc);
            Assert.AreEqual(2, s.Item1);
        }

        [TestMethod]
        public void TestDivision_Resto_Ok()
        {
            calc.n1 = 10;
            calc.n2 = 5;
            var s = op.Division(calc);
            Assert.AreEqual(0, s.Item2);
        }

        [TestMethod]
        public void TestDivision_Null()
        {
            calc.n1 = 10;
            calc.n2 = 0;
            Assert.IsNull(op.Division(calc));
        }

        /// <summary>
        /// Not that happy path
        /// </summary>
        [TestMethod]
        public void TestSuma_Fail()
        {
            calc.n1 = 10;
            calc.n2 = 5;
            var s = op.Suma(calc);
            Assert.AreNotEqual(120, s);
        }

        [TestMethod]
        public void TestResta_Fail()
        {
            calc.n1 = 10;
            calc.n2 = 5;
            var s = op.Resta(calc);
            Assert.AreNotEqual(8, s);
        }

        [TestMethod]
        public void TestMultiplication_Fail()
        {
            calc.n1 = 10;
            calc.n2 = 5;
            var s = op.Multiplicacion(calc);
            Assert.AreNotEqual(24, s);
        }

        [TestMethod]
        public void TestDivision_Fail()
        {
            calc.n1 = 10;
            calc.n2 = 5;
            var s = op.Division(calc);
            Assert.AreNotEqual(14, s);
        }




    }
}
