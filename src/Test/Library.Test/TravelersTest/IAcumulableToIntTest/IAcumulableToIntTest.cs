using NUnit.Framework;

namespace Library.Test
{
    public class IAcumulableToIntTest
    {
        private AbstractIAcumulableToInt _convertor;
        private IAcumulable _acumulable;
        [SetUp]
        public void Setup()
        {
            this._convertor = new HeadAcumulableToInt();
        }
        // Se testea la conversion de un numero de coins positivo.
        [Test]
        public void SomeCoinsConvertion()
        {
            // Act.
            this._acumulable = new Coins(10);
            int expected = 10 * this._convertor.Convert(new Coins(1));
            // Assert.
            Assert.AreEqual(expected, this._convertor.Convert(this._acumulable));

        }
        // Se testea la conversion de cero coins.
        [Test]
        public void CeroCoinsConvertion()
        {
            // Act.
            this._acumulable = new Coins(0);
            int expected = 0;
            // Assert.
            Assert.AreEqual(expected, this._convertor.Convert(this._acumulable));

        }
        // Se testea la conversion de un numero de coins negativos.
        [Test]
        public void NegativeCoinsConvertion()
        {
            // Act.
            this._acumulable = new Coins(-10);
            int expected = -10 * this._convertor.Convert(new Coins(1));
            // Assert.
            Assert.AreEqual(expected, this._convertor.Convert(this._acumulable));
        }
        // Se testea la conversion de un numero de coins positivo.
        [Test]
        public void SomePointsConvertion()
        {
            // Act.
            this._acumulable = new Points(10);
            int expected = 10 * this._convertor.Convert(new Points(1));
            // Assert.
            Assert.AreEqual(expected, this._convertor.Convert(this._acumulable));

        }
        // Se testea la conversion de cero coins.
        [Test]
        public void CeroPointsConvertion()
        {
            // Act.
            this._acumulable = new Points(0);
            int expected = 0;
            // Assert.
            Assert.AreEqual(expected, this._convertor.Convert(this._acumulable));

        }
        // Se testea la conversion de un numero de points negativos.
        [Test]
        public void NegativePointsConvertion()
        {
            // Act.
            this._acumulable = new Points(-10);
            int expected = -10 * this._convertor.Convert(new Points(1));
            // Assert.
            Assert.AreEqual(expected, this._convertor.Convert(this._acumulable));
        }
    }
}