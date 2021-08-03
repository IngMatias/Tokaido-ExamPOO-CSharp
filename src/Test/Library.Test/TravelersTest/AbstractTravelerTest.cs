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
            int expected = 0;
            Assert.AreEqual(expected, this._traveler.Visits(this._edo));
        }

        [Test]
        public void NoKyotoVisits()
        {
            int expected = 0;
            Assert.AreEqual(expected, this._traveler.Visits(this._kyoto));
        }

        [Test]
        public void NoFarmVisits()
        {
            int expected = 0;
            Assert.AreEqual(expected, this._traveler.Visits(this._farm));
        }

        [Test]
        public void NoTermalWaterVisits()
        {
            int expected = 0;
            Assert.AreEqual(expected, this._traveler.Visits(this._termal));
        }

        [Test]
        public void NoMountainVisits()
        {
            int expected = 0;
            Assert.AreEqual(expected, this._traveler.Visits(this._mountain));
        }

        [Test]
        public void NoOceanVisits()
        {
            int expected = 0;
            Assert.AreEqual(expected, this._traveler.Visits(this._ocean));
        }
        // Se testea la consulta de visitas cuando se hace una.
        [Test]
        public void EdoVisit()
        {
            this._edo.Add(this._traveler);
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._edo));
        }

        [Test]
        public void KyotoVisit()
        {
            this._kyoto.Add(this._traveler);
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._kyoto));
        }

        [Test]
        public void FarmVisit()
        {
            this._farm.Add(this._traveler);
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._farm));
        }

        [Test]
        public void TermalWaterVisit()
        {
            this._termal.Add(this._traveler);
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._termal));
        }

        [Test]
        public void MountainVisit()
        {
            this._mountain.Add(this._traveler);
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._mountain));
        }

        [Test]
        public void OceanVisit()
        {
            this._ocean.Add(this._traveler);
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._ocean));
        }
        // Se testea la consulta de visitas cuando se hacen dos pero a diferentes experiencias.
        [Test]
        public void EdoVisits()
        {
            this._edo.Add(this._traveler);
            this._kyoto.Add(this._traveler);
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._edo));
        }

        [Test]
        public void KyotoVisits()
        {
            this._kyoto.Add(this._traveler);
            this._farm.Add(this._traveler);
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._kyoto));
        }

        [Test]
        public void FarmVisits()
        {
            this._farm.Add(this._traveler);
            this._termal.Add(this._traveler);
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._farm));
        }

        [Test]
        public void TermalWaterVisits()
        {
            this._termal.Add(this._traveler);
            this._mountain.Add(this._traveler);
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._termal));
        }

        [Test]
        public void MountainVisits()
        {
            this._mountain.Add(this._traveler);
            this._ocean.Add(this._traveler);
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._mountain));
        }

        [Test]
        public void OceanVisits()
        {
            this._ocean.Add(this._traveler);
            this._edo.Add(this._traveler);
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._ocean));
        }
        // Se testea la consulta de visitas cuando se hacen dos a la misma experiencia (diferente instancia).
        [Test]
        public void TwoEdoVisits()
        {
            this._edo.Add(this._traveler);
            this._edo2.Add(this._traveler);
            int expected = 2;
            Assert.AreEqual(expected, this._traveler.Visits(this._edo));
        }

        [Test]
        public void TwoKyotoVisits()
        {
            this._kyoto.Add(this._traveler);
            this._kyoto2.Add(this._traveler);
            int expected = 2;
            Assert.AreEqual(expected, this._traveler.Visits(this._kyoto));
        }

        [Test]
        public void TwoFarmVisits()
        {
            this._farm.Add(this._traveler);
            this._farm2.Add(this._traveler);
            int expected = 2;
            Assert.AreEqual(expected, this._traveler.Visits(this._farm));
        }

        [Test]
        public void TwoTermalWaterVisits()
        {
            this._termal.Add(this._traveler);
            this._termal2.Add(this._traveler);
            int expected = 2;
            Assert.AreEqual(expected, this._traveler.Visits(this._termal));
        }

        [Test]
        public void TwoMountainVisits()
        {
            this._mountain.Add(this._traveler);
            this._mountain2.Add(this._traveler);
            int expected = 2;
            Assert.AreEqual(expected, this._traveler.Visits(this._mountain));
        }

        [Test]
        public void TwoOceanVisits()
        {
            this._ocean.Add(this._traveler);
            this._ocean2.Add(this._traveler);
            int expected = 2;
            Assert.AreEqual(expected, this._traveler.Visits(this._ocean));
        }
        // Se testea la consulta de visitas cuando se hacen dos a la misma experiencia (misma instancia).
        [Test]
        public void TwoSameEdoVisits()
        {
            this._edo.Add(this._traveler);
            this._edo.Add(this._traveler);
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._edo));
        }

        [Test]
        public void TwoSameKyotoVisits()
        {
            this._kyoto.Add(this._traveler);
            this._kyoto.Add(this._traveler);
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._kyoto));
        }

        [Test]
        public void TwoSameFarmVisits()
        {
            this._farm.Add(this._traveler);
            this._farm.Add(this._traveler);
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._farm));
        }

        [Test]
        public void TwoSameTermalWaterVisits()
        {
            this._termal.Add(this._traveler);
            this._termal.Add(this._traveler);
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._termal));
        }

        [Test]
        public void TwoSameMountainVisits()
        {
            this._mountain.Add(this._traveler);
            this._mountain.Add(this._traveler);
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._mountain));
        }

        [Test]
        public void TwoSameOceanVisits()
        {
            this._ocean.Add(this._traveler);
            this._ocean.Add(this._traveler);
            int expected = 1;
            Assert.AreEqual(expected, this._traveler.Visits(this._ocean));
        }


        // Se testea el resultado sin visitas.
        [Test]
        public void NoResult()
        {
            (string,int) expected = ("",0);
            Assert.AreEqual(expected, this._traveler.Result());
        }

        // Se testea el resultado cuando se hace una visita.
        [Test]
        public void EdoResult()
        {
            this._edo.Add(this._traveler);
            (string,int) expected = ("",0);
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void KyotoResult()
        {
            this._kyoto.Add(this._traveler);
            (string,int) expected = ("",0);
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void FarmResult()
        {
            this._farm.Add(this._traveler);
            (string,int) expected = ("",this._convertor.Convert(new Coins(3)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void TermalWaterResult()
        {
            this._termal.Add(this._traveler);
            (string,int) expected = ("",this._convertor.Convert(new Points(2)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void MountainResult()
        {
            this._mountain.Add(this._traveler);
            (string,int) expected = ("",this._convertor.Convert(new Points(1)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void OceanResult()
        {
            this._ocean.Add(this._traveler);
            (string,int) expected = ("",this._convertor.Convert(new Points(1)));
            Assert.AreEqual(expected, this._traveler.Result());
        }
        // Se testea la consulta de resultado cuando se hacen dos visitas pero a diferentes experiencias.
        [Test]
        public void EdoResults()
        {
            this._edo.Add(this._traveler);
            this._kyoto.Add(this._traveler);
            (string,int) expected = ("",this._convertor.Convert(new Coins(0)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void KyotoResults()
        {
            this._kyoto.Add(this._traveler);
            this._farm.Add(this._traveler);
            (string,int) expected = ("",this._convertor.Convert(new Coins(3)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void FarmResults()
        {
            this._farm.Add(this._traveler);
            this._termal.Add(this._traveler);
            (string,int) expected = ("",this._convertor.Convert(new Coins(3)) + this._convertor.Convert(new Points(2)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void TermalWaterResults()
        {
            this._termal.Add(this._traveler);
            this._mountain.Add(this._traveler);
            (string,int) expected = ("",this._convertor.Convert(new Points(3)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void MountainResults()
        {
            this._mountain.Add(this._traveler);
            this._ocean.Add(this._traveler);
            (string,int) expected = ("",this._convertor.Convert(new Points(2)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void OceanResults()
        {
            this._ocean.Add(this._traveler);
            this._edo.Add(this._traveler);
            (string,int) expected = ("",this._convertor.Convert(new Points(1)));
            Assert.AreEqual(expected, this._traveler.Result());
        }
        // Se testea la consulta de resultado cuando se hacen dos visitas a la misma experiencia (diferente instancia).
        [Test]
        public void TwoEdoResults()
        {
            this._edo.Add(this._traveler);
            this._edo2.Add(this._traveler);
            (string,int) expected = ("",this._convertor.Convert(new Coins(0)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void TwoKyotoResults()
        {
            this._kyoto.Add(this._traveler);
            this._kyoto2.Add(this._traveler);
            (string,int) expected = ("",this._convertor.Convert(new Coins(0)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void TwoFarmResults()
        {
            this._farm.Add(this._traveler);
            this._farm2.Add(this._traveler);
            (string,int) expected = ("",this._convertor.Convert(new Coins(3*2)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void TwoTermalWaterResults()
        {
            this._termal.Add(this._traveler);
            this._termal2.Add(this._traveler);
            (string,int) expected = ("",this._convertor.Convert(new Points(2*2)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void TwoMountainResults()
        {
            this._mountain.Add(this._traveler);
            this._mountain2.Add(this._traveler);
            (string,int) expected = ("",this._convertor.Convert(new Points(1+2)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void TwoOceanResults()
        {
            this._ocean.Add(this._traveler);
            this._ocean2.Add(this._traveler);
            (string,int) expected = ("",this._convertor.Convert(new Points(1+3)));
            Assert.AreEqual(expected, this._traveler.Result());
        }
        // Se testea la consulta de resultado cuando se hacen dos visitas a la misma experiencia (misma instancia).
        [Test]
        public void TwoSameEdoResults()
        {
            this._edo.Add(this._traveler);
            this._edo.Add(this._traveler);
            (string,int) expected = ("",this._convertor.Convert(new Coins(0)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void TwoSameKyotoResults()
        {
            this._kyoto.Add(this._traveler);
            this._kyoto.Add(this._traveler);
            (string,int) expected = ("",this._convertor.Convert(new Coins(0)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void TwoSameFarmResults()
        {
            this._farm.Add(this._traveler);
            this._farm.Add(this._traveler);
            (string,int) expected = ("",this._convertor.Convert(new Coins(3)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void TwoSameTermalWaterResults()
        {
            this._termal.Add(this._traveler);
            this._termal.Add(this._traveler);
            (string,int) expected = ("",this._convertor.Convert(new Points(2)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void TwoSameMountainResults()
        {
            this._mountain.Add(this._traveler);
            this._mountain.Add(this._traveler);
            (string,int) expected = ("",this._convertor.Convert(new Points(1)));
            Assert.AreEqual(expected, this._traveler.Result());
        }

        [Test]
        public void TwoSameOceanResults()
        {
            this._ocean.Add(this._traveler);
            this._ocean.Add(this._traveler);
            (string,int) expected = ("",this._convertor.Convert(new Points(1)));
            Assert.AreEqual(expected, this._traveler.Result());
        }
        // Se testea un camino largo.
        [Test]
        public void ALotOfVisits()
        {
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

            Assert.AreEqual(("",expectedInt), this._traveler.Result());
        }
    }
}