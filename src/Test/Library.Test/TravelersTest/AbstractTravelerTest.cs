using NUnit.Framework;

namespace Library.Test
{
    public class Tests
    {
        private AbstractTraveler _traveler;

        private IExperience _edo;
        private IExperience _edo2;
        private IExperience _edo3;
        private IExperience _kyoto;
        private IExperience _kyoto2;
        private IExperience _kyoto3;
        private IExperience _farm;
        private IExperience _farm2;
        private IExperience _farm3;
        private IExperience _termal;
        private IExperience _termal2;
        private IExperience _termal3;
        private IExperience _mountain;
        private IExperience _mountain2;
        private IExperience _mountain3;
        private IExperience _ocean;
        private IExperience _ocean2;
        private IExperience _ocean3;

        private AbstractIAcumulableToInt _convertor;

        [SetUp]
        public void Setup()
        {
            // Arrange.
            this._traveler = new BlueTraveler("");

            this._edo = new EdoExperience();
            this._edo2 = new EdoExperience();
            this._edo3 = new EdoExperience();

            this._kyoto = new KyotoExperience();
            this._kyoto2 = new KyotoExperience();
            this._kyoto3 = new KyotoExperience();

            this._farm = new FarmExperience(2);
            this._farm2 = new FarmExperience(2);
            this._farm3 = new FarmExperience(2);

            this._termal = new TermalWaterExperience(2);
            this._termal2 = new TermalWaterExperience(2);
            this._termal3 = new TermalWaterExperience(2);

            this._mountain = new MountainLandscape(2);
            this._mountain2 = new MountainLandscape(2);
            this._mountain3 = new MountainLandscape(2);

            this._ocean = new OceanLandscape(2);
            this._ocean2 = new OceanLandscape(2);
            this._ocean3 = new OceanLandscape(2);

            this._convertor = new HeadAcumulableToInt();
        }
        // Se testea la consulta de visitas cuando no se hace ninguna.
        [Test]
        public void NoEdoVisits()
        {
            // Assert.
            int expected = 0;
            Assert.AreEqual(expected, this._traveler.Visits(this._edo));
        }

        [Test]
        public void NoKyotoVisits()
        {
            // Assert.
            int expected = 0;
            Assert.AreEqual(expected, this._traveler.Visits(this._kyoto));
        }

        [Test]
        public void NoFarmVisits()
        {
            // Assert.
            int expected = 0;
            Assert.AreEqual(expected, this._traveler.Visits(this._farm));
        }

        [Test]
        public void NoTermalWaterVisits()
        {
            // Assert.
            int expected = 0;
            Assert.AreEqual(expected, this._traveler.Visits(this._termal));
        }

        [Test]
        public void NoMountainVisits()
        {
            // Assert.
            int expected = 0;
            Assert.AreEqual(expected, this._traveler.Visits(this._mountain));
        }

        [Test]
        public void NoOceanVisits()
        {
            // Assert.
            int expected = 0;
            Assert.AreEqual(expected, this._traveler.Visits(this._ocean));
        }
        // Se testea la consulta de visitas cuando se hace una.
        [Test]
        public void EdoVisit()
        {
            // Act.
            this._edo.Add(this._traveler);
            // Assert.
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._edo));
        }

        [Test]
        public void KyotoVisit()
        {
            // Act.
            this._kyoto.Add(this._traveler);
            // Assert.
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._kyoto));
        }

        [Test]
        public void FarmVisit()
        {
            // Act.
            this._farm.Add(this._traveler);
            // Assert.
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._farm));
        }

        [Test]
        public void TermalWaterVisit()
        {
            // Act.
            this._termal.Add(this._traveler);
            // Assert.
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._termal));
        }

        [Test]
        public void MountainVisit()
        {
            // Act.
            this._mountain.Add(this._traveler);
            // Assert.
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._mountain));
        }

        [Test]
        public void OceanVisit()
        {
            // Act.
            this._ocean.Add(this._traveler);
            // Assert.
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._ocean));
        }
        // Se testea la consulta de visitas cuando se hacen dos pero a diferentes experiencias.
        [Test]
        public void EdoVisits()
        {
            // Act.
            this._edo.Add(this._traveler);
            this._kyoto.Add(this._traveler);
            // Assert.
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._edo));
        }

        [Test]
        public void KyotoVisits()
        {
            // Act.
            this._kyoto.Add(this._traveler);
            this._farm.Add(this._traveler);
            // Assert.
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._kyoto));
        }

        [Test]
        public void FarmVisits()
        {
            // Act.
            this._farm.Add(this._traveler);
            this._termal.Add(this._traveler);
            // Assert.
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._farm));
        }

        [Test]
        public void TermalWaterVisits()
        {
            // Act.
            this._termal.Add(this._traveler);
            this._mountain.Add(this._traveler);
            // Assert.
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._termal));
        }

        [Test]
        public void MountainVisits()
        {
            // Act.
            this._mountain.Add(this._traveler);
            this._ocean.Add(this._traveler);
            // Assert.
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._mountain));
        }

        [Test]
        public void OceanVisits()
        {
            // Act.
            this._ocean.Add(this._traveler);
            this._edo.Add(this._traveler);
            // Assert.
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._ocean));
        }
        // Se testea la consulta de visitas cuando se hacen dos a la misma experiencia (diferente instancia).
        [Test]
        public void TwoEdoVisits()
        {
            // Act.
            this._edo.Add(this._traveler);
            this._edo2.Add(this._traveler);
            // Assert.
            int expected = 2;
            Assert.AreEqual(expected, this._traveler.Visits(this._edo));
        }

        [Test]
        public void TwoKyotoVisits()
        {
            // Act.
            this._kyoto.Add(this._traveler);
            this._kyoto2.Add(this._traveler);
            // Assert.
            int expected = 2;
            Assert.AreEqual(expected, this._traveler.Visits(this._kyoto));
        }

        [Test]
        public void TwoFarmVisits()
        {
            // Act.
            this._farm.Add(this._traveler);
            this._farm2.Add(this._traveler);
            // Assert.
            int expected = 2;
            Assert.AreEqual(expected, this._traveler.Visits(this._farm));
        }

        [Test]
        public void TwoTermalWaterVisits()
        {
            // Act.
            this._termal.Add(this._traveler);
            this._termal2.Add(this._traveler);
            // Assert.
            int expected = 2;
            Assert.AreEqual(expected, this._traveler.Visits(this._termal));
        }

        [Test]
        public void TwoMountainVisits()
        {
            // Act.
            this._mountain.Add(this._traveler);
            this._mountain2.Add(this._traveler);
            // Assert.
            int expected = 2;
            Assert.AreEqual(expected, this._traveler.Visits(this._mountain));
        }

        [Test]
        public void TwoOceanVisits()
        {
            // Act.
            this._ocean.Add(this._traveler);
            this._ocean2.Add(this._traveler);
            // Assert.
            int expected = 2;
            Assert.AreEqual(expected, this._traveler.Visits(this._ocean));
        }
        // Se testea la consulta de visitas cuando se hacen dos a la misma experiencia (misma instancia).
        [Test]
        public void TwoSameEdoVisits()
        {
            // Act.
            this._edo.Add(this._traveler);
            this._edo.Add(this._traveler);
            // Assert.
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._edo));
        }

        [Test]
        public void TwoSameKyotoVisits()
        {
            // Act.
            this._kyoto.Add(this._traveler);
            this._kyoto.Add(this._traveler);
            // Assert.
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._kyoto));
        }

        [Test]
        public void TwoSameFarmVisits()
        {
            // Act.
            this._farm.Add(this._traveler);
            this._farm.Add(this._traveler);
            // Assert.
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._farm));
        }

        [Test]
        public void TwoSameTermalWaterVisits()
        {
            // Act.
            this._termal.Add(this._traveler);
            this._termal.Add(this._traveler);
            // Assert.
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._termal));
        }

        [Test]
        public void TwoSameMountainVisits()
        {
            // Act.
            this._mountain.Add(this._traveler);
            this._mountain.Add(this._traveler);
            // Assert.
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._mountain));
        }

        [Test]
        public void TwoSameOceanVisits()
        {
            // Act.
            this._ocean.Add(this._traveler);
            this._ocean.Add(this._traveler);
            // Assert.
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._ocean));
        }


        // Se testea el resultado sin visitas.
        [Test]
        public void NoResult()
        {
            // Assert.
            (string,int) expected = ("",0);
            Assert.AreEqual(expected, this._traveler.Result());
        }

        // Se testea el resultado cuando se hace una visita.
        [Test]
        public void EdoResult()
        {
            // Act.
            this._edo.Add(this._traveler);
            // Assert.
            (string,int) expected = ("",0);
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void KyotoResult()
        {
            // Act.
            this._kyoto.Add(this._traveler);
            // Assert.
            (string,int) expected = ("",0);
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void FarmResult()
        {
            // Act.
            this._farm.Add(this._traveler);
            // Assert.
            (string,int) expected = ("",this._convertor.Convert(new Coins(3)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void TermalWaterResult()
        {
            // Act.
            this._termal.Add(this._traveler);
            // Assert.
            (string,int) expected = ("",this._convertor.Convert(new Points(2)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void MountainResult()
        {
            // Act.
            this._mountain.Add(this._traveler);
            // Assert.
            (string,int) expected = ("",this._convertor.Convert(new Points(1)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void OceanResult()
        {
            // Act.
            this._ocean.Add(this._traveler);
            // Assert.
            (string,int) expected = ("",this._convertor.Convert(new Points(1)));
            Assert.AreEqual(expected, this._traveler.Result());
        }
        // Se testea la consulta de resultado cuando se hacen dos visitas pero a diferentes experiencias.
        [Test]
        public void EdoResults()
        {
            // Act.
            this._edo.Add(this._traveler);
            this._kyoto.Add(this._traveler);
            // Assert.
            (string,int) expected = ("",this._convertor.Convert(new Coins(0)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void KyotoResults()
        {
            // Act.
            this._kyoto.Add(this._traveler);
            this._farm.Add(this._traveler);
            // Assert.
            (string,int) expected = ("",this._convertor.Convert(new Coins(3)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void FarmResults()
        {
            // Act.
            this._farm.Add(this._traveler);
            this._termal.Add(this._traveler);
            // Assert.
            (string,int) expected = ("",this._convertor.Convert(new Coins(3)) + this._convertor.Convert(new Points(2)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void TermalWaterResults()
        {
            // Act.
            this._termal.Add(this._traveler);
            this._mountain.Add(this._traveler);
            // Assert.
            (string,int) expected = ("",this._convertor.Convert(new Points(3)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void MountainResults()
        {
            // Act.
            this._mountain.Add(this._traveler);
            this._ocean.Add(this._traveler);
            // Assert.
            (string,int) expected = ("",this._convertor.Convert(new Points(2)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void OceanResults()
        {
            // Act.
            this._ocean.Add(this._traveler);
            this._edo.Add(this._traveler);
            // Assert.
            (string,int) expected = ("",this._convertor.Convert(new Points(1)));
            Assert.AreEqual(expected, this._traveler.Result());
        }
        // Se testea la consulta de resultado cuando se hacen dos visitas a la misma experiencia (diferente instancia).
        [Test]
        public void TwoEdoResults()
        {
            // Act.
            this._edo.Add(this._traveler);
            this._edo2.Add(this._traveler);
            // Assert.
            (string,int) expected = ("",this._convertor.Convert(new Coins(0)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void TwoKyotoResults()
        {
            // Act.
            this._kyoto.Add(this._traveler);
            this._kyoto2.Add(this._traveler);
            // Assert.
            (string,int) expected = ("",this._convertor.Convert(new Coins(0)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void TwoFarmResults()
        {
            // Act.
            this._farm.Add(this._traveler);
            this._farm2.Add(this._traveler);
            // Assert.
            (string,int) expected = ("",this._convertor.Convert(new Coins(3*2)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void TwoTermalWaterResults()
        {
            // Act.
            this._termal.Add(this._traveler);
            this._termal2.Add(this._traveler);
            // Assert.
            (string,int) expected = ("",this._convertor.Convert(new Points(2*2)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void TwoMountainResults()
        {
            // Act.
            this._mountain.Add(this._traveler);
            this._mountain2.Add(this._traveler);
            // Assert.
            (string,int) expected = ("",this._convertor.Convert(new Points(1+2)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void TwoOceanResults()
        {
            // Act.
            this._ocean.Add(this._traveler);
            this._ocean2.Add(this._traveler);
            // Assert.
            (string,int) expected = ("",this._convertor.Convert(new Points(1+3)));
            Assert.AreEqual(expected, this._traveler.Result());
        }
        // Se testea la consulta de resultado cuando se hacen dos visitas a la misma experiencia (misma instancia).
        [Test]
        public void TwoSameEdoResults()
        {
            // Act.
            this._edo.Add(this._traveler);
            this._edo.Add(this._traveler);
            // Assert.
            (string,int) expected = ("",this._convertor.Convert(new Coins(0)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void TwoSameKyotoResults()
        {
            // Act.
            this._kyoto.Add(this._traveler);
            this._kyoto.Add(this._traveler);
            // Assert.
            (string,int) expected = ("",this._convertor.Convert(new Coins(0)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void TwoSameFarmResults()
        {
            // Act.
            this._farm.Add(this._traveler);
            this._farm.Add(this._traveler);
            // Assert.
            (string,int) expected = ("",this._convertor.Convert(new Coins(3)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void TwoSameTermalWaterResults()
        {
            // Act.
            this._termal.Add(this._traveler);
            this._termal.Add(this._traveler);
            // Assert.
            (string,int) expected = ("",this._convertor.Convert(new Points(2)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void TwoSameMountainResults()
        {
            // Act.
            this._mountain.Add(this._traveler);
            this._mountain.Add(this._traveler);
            // Assert.
            (string,int) expected = ("",this._convertor.Convert(new Points(1)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void TwoSameOceanResults()
        {
            // Act.
            this._ocean.Add(this._traveler);
            this._ocean.Add(this._traveler);
            // Assert.
            (string,int) expected = ("",this._convertor.Convert(new Points(1)));
            Assert.AreEqual(expected, this._traveler.Result());
        }
        // Se testea un camino largo.
        [Test]
        public void ALotOfVisits()
        {
            // Act.
            this._edo.Add(this._traveler);
            this._edo2.Add(this._traveler);
            this._edo3.Add(this._traveler);
            int expectedInt = this._convertor.Convert(new Coins(0 * 3));

            this._farm.Add(this._traveler);
            this._farm2.Add(this._traveler);
            this._farm3.Add(this._traveler);
            expectedInt += this._convertor.Convert(new Coins(3 * 3));

            this._termal.Add(this._traveler);
            this._termal2.Add(this._traveler);
            this._termal3.Add(this._traveler);
            expectedInt += this._convertor.Convert(new Points(2 * 3));

            this._ocean.Add(this._traveler);
            this._ocean2.Add(this._traveler);
            this._ocean3.Add(this._traveler);
            expectedInt += this._convertor.Convert(new Points(1 + 3 +5));

            this._mountain.Add(this._traveler);
            this._mountain2.Add(this._traveler);
            this._mountain3.Add(this._traveler);
            expectedInt += this._convertor.Convert(new Points(1 + 2 +3));

            this._kyoto.Add(this._traveler);
            this._kyoto2.Add(this._traveler);
            this._kyoto3.Add(this._traveler);
            // Assert.
            Assert.AreEqual(("",expectedInt), this._traveler.Result());
        }
    }
}