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
        Calculator calc = new Calculator();

        /// <summary>
        /// Happy path
        /// </summary>
        //before all before each
        [TestMethod]
        public void TestSuma_Ok()
        {
            var s = op.Suma(10, 5);
            Assert.AreEqual(15, s);
        }

        [TestMethod]
        public void TestResta_Ok()
        {
            var s = op.Resta(10, 5);
            Assert.AreEqual(5, s);
        }

        [TestMethod]
        public void TestMultiplication_Ok()
        {
            var s = op.Multiplicacion(10, 5);
            Assert.AreEqual(50, s);
        }

        [TestMethod]
        public void TestDivision_Cociente_Ok()
        {
            var s = op.Division(10, 5);
            Assert.AreEqual(2, s.Item1);
        }

        [TestMethod]
        public void TestDivision_Resto_Ok()
        {
            var s = op.Division(10, 5);
            Assert.AreEqual(0, s.Item2);
        }

        [TestMethod]
        public void TestDivision_Null()
        {
            Assert.IsNull(op.Division(2, 0));
        }

        /// <summary>
        /// Not that happy path
        /// </summary>
        [TestMethod]
        public void TestSuma_Fail()
        {
            var s = op.Suma(50, 40);
            Assert.AreNotEqual(120, s);
        }

        [TestMethod]
        public void TestResta_Fail()
        {
            var s = op.Resta(10, 5);
            Assert.AreNotEqual(8, s);
        }

        [TestMethod]
        public void TestMultiplication_Fail()
        {
            var s = op.Multiplicacion(10, 5);
            Assert.AreNotEqual(24, s);
        }

        [TestMethod]
        public void TestDivision_Fail()
        {
            var s = op.Division(10, 5);
            Assert.AreNotEqual(14, s);
        }




    }
}
