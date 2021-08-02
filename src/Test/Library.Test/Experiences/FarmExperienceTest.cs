using NUnit.Framework;

namespace Library.Test
{
    public class FarmExperienceTest
    {
        private IExperience _exp1;
        private IExperience _exp2;
        private IExperience _exp3;

        private AbstractTraveler _traveler1;
        private AbstractTraveler _traveler2;
        private AbstractTraveler _traveler3;
        [SetUp]
        public void Setup()
        {
            // Arrange.
            this._exp1 = new FarmExperience(1);
            this._exp2 = new FarmExperience(2);
            this._exp3 = new FarmExperience(3);

            this._traveler1 = new BlueTraveler("");
            this._traveler2 = new GreenTraveler("");
            this._traveler3 = new RedTraveler("");
        }
        // Se testea el retorno true de IsEmpty.
        [Test]
        public void EmptyExperience()
        {
            // Act.
            bool returned = this._exp1.IsEmpty();
            // Assert.
            Assert.IsTrue(returned);
        }
        // Se testea el retorno false de IsEmpty.
        [Test]
        public void NotEmptyExperience()
        {
            // Act.
            this._exp1.Add(this._traveler1);
            // Assert.
            Assert.IsFalse(this._exp1.IsEmpty());
        }
        // Se testea el retorno true de Add.
        [Test]
        public void TrueAddExperience()
        {
            // Act.
            bool returned = this._exp1.Add(this._traveler1);
            // Assert.
            Assert.IsTrue(returned);
        }
        // Se testea el retorno false de Add por agregar dos veces el mismo viajero.
        [Test]
        public void FalseAddExperience()
        {
            // Act.
            this._exp2.Add(this._traveler1);
            bool returned = this._exp2.Add(this._traveler1);
            // Assert.
            Assert.IsFalse(returned);
        }
        // Se testea el retorno false de Add por sobrepasar el tamaño.
        [Test]
        public void FalseAddExperienceForSize()
        {
            // Act.
            this._exp1.Add(this._traveler1);
            bool returned = this._exp1.Add(this._traveler2);
            // Assert.
            Assert.IsFalse(returned);
        }
        // Se testea el agregado de tres viajeros a una experiencia con tamaño uno.
        [Test]
        public void ThreeTravelersExperienceInExp1()
        {
            // Act.
            this._exp1.Add(this._traveler1);
            this._exp1.Add(this._traveler2);
            this._exp1.Add(this._traveler3);
            int expected = 1;
            // Assert.
            Assert.AreEqual(expected, this._exp1.Travelers.Count);
        }
        // Se testea el agregado de tres viajeros a una experiencia con tamaño dos.
        [Test]
        public void ThreeTravelersExperienceIneExp2()
        {
            // Act.
            this._exp2.Add(this._traveler1);
            this._exp2.Add(this._traveler2);
            this._exp2.Add(this._traveler3);
            int expected = 2;
            // Assert.
            Assert.AreEqual(expected, this._exp2.Travelers.Count);
        }
        // Se testea el retorno true de Remove.
        [Test]
        public void TrueRomoveExperience()
        {
            // Act.
            this._exp1.Add(this._traveler1);
            bool returned = this._exp1.Remove(this._traveler1);
            // Assert.
            Assert.IsTrue(returned);
        }
        // Se testea el retorno false de Remove.
        [Test]
        public void FalseRemoveExperience()
        {
            // Act.
            bool returned = this._exp1.Remove(this._traveler1);
            // Assert.
            Assert.IsFalse(returned);
        }
        // Se testea que retorne False cuando esta vacia la experiencia.
        [Test]
        public void FalseEmptyRemoveExperience()
        {
            // Act.
            bool returned = this._exp1.Remove(this._traveler1);
            // Assert.
            Assert.IsFalse(returned);
        }
        // Se testea que retorne False cuando no se encuentra el traveler.
        [Test]
        public void WrongRemoveExperience()
        {
            // Act.
            this._exp1.Add(this._traveler1);
            bool returned = this._exp1.Remove(this._traveler2);
            // Assert.
            Assert.IsFalse(returned);
        }
        // Se testea que las experiencias sean diferentes.
        [Test]
        public void DifferentExperiences()
        {
            // Act.
            this._exp1.Add(this._traveler1);
            // Assert.
            Assert.IsTrue(this._exp2.IsEmpty());
        }
    }
}