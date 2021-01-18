using Número_a_literal.Controllers;
using NUnit.Framework;

namespace UnitTestNúmero_a_Literal
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGet()
        {
            string num = "587";
            string esperado = "QUINIENTOS OCHENTA Y SIETE";
            NumeroLiteralController calt = new NumeroLiteralController();
            string resultado = calt.enletras(num);
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestGet2()
        {
            string num = "14538";
            string esperado = "CATORCE MIL QUINIENTOS TREINTA Y OCHO";
            NumeroLiteralController calt = new NumeroLiteralController();
            string resultado = calt.enletras(num);
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestPost()
        {
            string num = "493";
            string esperado = "CUATROCIENTOS NOVENTA Y TRES";
            NumeroLiteralController calt = new NumeroLiteralController();
            string resultado = calt.enletrasPost(num);
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestPost2()
        {
            string num = "1063859";
            string esperado = "UN MILLON SESENTA Y TRES MIL OCHOCIENTOS CINCUENTA Y NUEVE";
            NumeroLiteralController calt = new NumeroLiteralController();
            string resultado = calt.enletrasPost(num);
            Assert.AreEqual(esperado, resultado);
        }
    }
}