using NUnit.Framework;
using RationalMVC.Models;

namespace RationalTests
{
    public class Tests
    {
        [Test]
        public void TestRationalPlus()
        {
            Rational r1 = new Rational(-2, 4);
            Rational r2 = new Rational(-3, -20);

            Assert.AreEqual(r1.Plus(r2).ToString(), "-7 / 20");
        }

        [Test]
        public void TestRationalMinus()
        {
            Rational r1 = new Rational(-2, 4);
            Rational r2 = new Rational(-3, -20);

            Assert.AreEqual(r1.Minus(r2).ToString(), "-13 / 20");
        }

        [Test]
        public void TestRationalMultiply()
        {
            Rational r1 = new Rational(-2, 4);
            Rational r2 = new Rational(-3, -20);

            Assert.AreEqual(r1.Multiply(r2).ToString(), "-3 / 40");
        }

        [Test]
        public void TestRationalDevide()
        {
            Rational r1 = new Rational(-2, 4);
            Rational r2 = new Rational(-3, -20);

            Assert.AreEqual(r1.Devide(r2).ToString(), "-10 / 3");
        }

        [Test]
        public void TestRationalCompare()
        {
            Rational r1 = new Rational(-2, 4);
            Rational r2 = new Rational(-3, -20);

            Assert.AreEqual(Rational.Compare(r1, r2).ToString(), r2.ToString());
        }
    }
}