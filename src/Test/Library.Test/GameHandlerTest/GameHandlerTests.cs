using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Library.Test
{
    public class GameHandlerTests
    {
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

        private IGameHandler _game;

        private AbstractTraveler _traveler;
        private AbstractTraveler _traveler2;
        private AbstractTraveler _traveler3;

        private AbstractIAcumulableToInt _convertor;
        [SetUp]
        public void Setup()
        {
            // Arrange.
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

            this._traveler = new BlueTraveler("");
            this._traveler2 = new GreenTraveler("");
            this._traveler3 = new RedTraveler("");

            this._game = new GameHandler(this._edo, this._kyoto);

            this._convertor = new HeadAcumulableToInt();
        }
        // Se testea que el juego no haya comenzado.
        [Test]
        public void NotStartedGame()
        {
            // Assert.
            Assert.IsFalse(this._game.IsStarted());
        }
        // Se testea el lanzamiento de la excepcion del agregado de las experiencias edo y kyoto.
        [Test]
        public void NoAddEdo()
        {
            // Assert.
            Assert.Throws<CanNotAddFirstExperienceExcpetion>(() => this._game.Add(this._edo));
        }
        [Test]
        public void NoAddkyoto()
        {
            // Assert.
            Assert.Throws<CanNotAddLastExperienceExcpetion>(() => this._game.Add(this._kyoto));
        }
        // Se testea que el juego no haya comenzado con el agregado de una experienca.
        [Test]
        public void NotStartedWithFarm()
        {
            // Act.
            this._game.Add(this._farm);
            // Assert.
            Assert.IsFalse(this._game.IsStarted());
        }
        [Test]
        public void NotStartedWithTermal()
        {
            // Act.
            this._game.Add(this._termal);
            // Assert.
            Assert.IsFalse(this._game.IsStarted());
        }
        [Test]
        public void NotStartedWithMountain()
        {
            // Act.
            this._game.Add(this._mountain);
            // Assert.
            Assert.IsFalse(this._game.IsStarted());
        }
        [Test]
        public void NotStartedWithOcean()
        {
            // Act.
            this._game.Add(this._ocean);
            // Assert.
            Assert.IsFalse(this._game.IsStarted());
        }
        // Se testea el comienzo del juego.
        [Test]
        public void StartedGame()
        {
            // Act.
            this._game.StartGame();
            // Assert.
            Assert.IsTrue(this._game.IsStarted());
        }
        // Se testean dos comienzos de juego.
        [Test]
        public void StartGameTwice()
        {
            // Act.
            this._game.StartGame();
            // Assert.
            Assert.Throws<AlreadyStartedGameExcpetion>(() => this._game.StartGame());
        }
        // Se testea el comienzo del juego con una experiencia.
        [Test]
        public void StartedFarmGame()
        {
            // Act.
            this._game.Add(this._farm);
            this._game.StartGame();
            // Assert.
            Assert.IsTrue(this._game.IsStarted());
        }
        [Test]
        public void StartedTermalGame()
        {
            // Act.
            this._game.Add(this._termal);
            this._game.StartGame();
            // Assert.
            Assert.IsTrue(this._game.IsStarted());
        }
        [Test]
        public void StartedOceanGame()
        {
            // Act.
            this._game.Add(this._ocean);
            this._game.StartGame();
            // Assert.
            Assert.IsTrue(this._game.IsStarted());
        }
        [Test]
        public void StartedMountainGame()
        {
            // Act.
            this._game.Add(this._mountain);
            this._game.StartGame();
            // Assert.
            Assert.IsTrue(this._game.IsStarted());
        }
        // Se testea el doble agregado de la misma experiencia (igual instancia).
        [Test]
        public void TwoFarms()
        {
            // Act.
            this._game.Add(this._farm);
            // Assert.
            Assert.Throws<AlreadyAddedExperience>(() => this._game.Add(this._farm));
        }
        [Test]
        public void TwoTermals()
        {
            // Act.
            this._game.Add(this._termal);
            // Assert.
            Assert.Throws<AlreadyAddedExperience>(() => this._game.Add(this._termal));
        }
        [Test]
        public void TwoMountains()
        {
            // Act.
            this._game.Add(this._mountain);
            // Assert.
            Assert.Throws<AlreadyAddedExperience>(() => this._game.Add(this._mountain));
        }
        [Test]
        public void TwoOceans()
        {
            // Act.
            this._game.Add(this._ocean);
            // Assert.
            Assert.Throws<AlreadyAddedExperience>(() => this._game.Add(this._ocean));
        }
        // Se testea el remover sin experiencias agregadas.
        [Test]
        public void NoRemoveEdo()
        {
            // Assert.
            Assert.Throws<CanNotAddFirstExperienceExcpetion>(() => this._game.Remove(this._edo));
        }
        [Test]
        public void NoRemoveKyoto()
        {
            // Assert.
            Assert.Throws<CanNotAddLastExperienceExcpetion>(() => this._game.Remove(this._kyoto));
        }
        [Test]
        public void NoRemoveFarm()
        {
            // Assert.
            Assert.Throws<NotFoundExperienceException>(() => this._game.Remove(this._farm));
        }
        [Test]
        public void NoRemoveTermal()
        {
            // Assert.
            Assert.Throws<NotFoundExperienceException>(() => this._game.Remove(this._termal));
        }
        [Test]
        public void NoRemoveMountain()
        {
            // Assert.
            Assert.Throws<NotFoundExperienceException>(() => this._game.Remove(this._mountain));
        }
        [Test]
        public void NoRemoveOcean()
        {
            // Assert.
            Assert.Throws<NotFoundExperienceException>(() => this._game.Remove(this._ocean));
        }
        // Se testea el remover con la experiencia agregada.
        [Test]
        public void RemoveFarm()
        {
            // Act.
            this._game.Add(this._farm);
            // Assert.
            Assert.DoesNotThrow(() => this._game.Remove(this._farm));
        }
        [Test]
        public void RemoveTermal()
        {
            // Act.
            this._game.Add(this._termal);
            // Assert.
            Assert.DoesNotThrow(() => this._game.Remove(this._termal));
        }
        [Test]
        public void RemoveMountain()
        {
            // Act.
            this._game.Add(this._mountain);
            // Assert.
            Assert.DoesNotThrow(() => this._game.Remove(this._mountain));    
        }
        [Test]
        public void RemoveOcean()
        {
            // Act.
            this._game.Add(this._ocean);
            // Assert.
            Assert.DoesNotThrow(() => this._game.Remove(this._ocean));    
        }
        // Se testea que se remueva solo cuando se trata de la misma instancia de la experiencia.
        [Test]
        public void RemoveDifferentFarm()
        {
            // Act.
            this._game.Add(this._farm);
            // Assert.
            Assert.Throws<NotFoundExperienceException>(() => this._game.Remove(this._farm2));
        }
        [Test]
        public void RemoveDifferentTermal()
        {
            // Act.
            this._game.Add(this._termal);
            // Assert.
            Assert.Throws<NotFoundExperienceException>(() => this._game.Remove(this._termal2));
        }
        [Test]
        public void RemoveDifferentMountain()
        {
            // Act.
            this._game.Add(this._mountain);
            // Assert.
            Assert.Throws<NotFoundExperienceException>(() => this._game.Remove(this._mountain2));
        }
        [Test]
        public void RemoveDifferentOcean()
        {
            // Act.
            this._game.Add(this._ocean);
            // Assert.
            Assert.Throws<NotFoundExperienceException>(() => this._game.Remove(this._ocean2));  
        }
        // Se testea que no se pueda remover experiencas una vez comenzado el juego.
        [Test]
        public void AlreadyStartedRemoveEdo()
        {
            // Act.
            this._game.StartGame();
            // Assert.
            Assert.Throws<AlreadyStartedGameExcpetion>(() => this._game.Remove(this._edo));
        }
        [Test]
        public void AlreadyStartedRemoveKyoto()
        {
            // Act.
            this._game.StartGame();
            // Assert.
            Assert.Throws<AlreadyStartedGameExcpetion>(() => this._game.Remove(this._kyoto));
        }
        [Test]
        public void AlreadyStartedRemoveFarm()
        {
            // Act.
            this._game.Add(this._farm);
            this._game.StartGame();
            // Assert.
            Assert.Throws<AlreadyStartedGameExcpetion>(() => this._game.Remove(this._farm));
        }
        [Test]
        public void AlreadyStartedRemoveTermal()
        {
            // Act.
            this._game.Add(this._termal);
            this._game.StartGame();
            // Assert.
            Assert.Throws<AlreadyStartedGameExcpetion>(() => this._game.Remove(this._termal));
        }
        [Test]
        public void AlreadyStartedRemoveMountain()
        {
            // Act.
            this._game.Add(this._mountain);
            this._game.StartGame();
            // Assert.
            Assert.Throws<AlreadyStartedGameExcpetion>(() => this._game.Remove(this._mountain));  
        }
        [Test]
        public void AlreadyStartedRemoveOcean()
        {
            // Act.
            this._game.Add(this._ocean);
            this._game.StartGame();
            // Assert.
            Assert.Throws<AlreadyStartedGameExcpetion>(() => this._game.Remove(this._edo));  
        }
        // Se testea el agregado de viajeros.
        [Test]
        public void AddOneTraveler()
        {
            // Assert.
            Assert.DoesNotThrow(() => this._game.Add(this._traveler));
        }
        [Test]
        public void AddTwoTravelers()
        {
            // Act.
            this._game.Add(this._traveler);
            // Assert.
            Assert.DoesNotThrow(() => this._game.Add(this._traveler2));
        }
        [Test]
        public void AddThreeTravelers()
        {
            // Act.
            this._game.Add(this._traveler);
            this._game.Add(this._traveler2);
            // Assert.
            Assert.DoesNotThrow(() => this._game.Add(this._traveler3));
        }
        // Se testea el Add de viajeros con partida comenzada.
        [Test]
        public void AlreadyStartedGameRemove()
        {
            // Act.
            this._game.Add(this._traveler);
            this._game.StartGame();
            // Assert.
            Assert.Throws<AlreadyStartedGameExcpetion>(() => this._game.Add(this._traveler));
        }
        // Se testea el agregado del mismo jugador.
        [Test]
        public void AlreadyAddedPlayer()
        {
            // Act.
            this._game.Add(this._traveler);
            // Assert.
            Assert.Throws<AlreadyInGameExcpetion>(() => this._game.Add(this._traveler));
        }
        // Se testea remover viajeros sin agregarlos.
        [Test]
        public void NoRemoveTraveler()
        {
            // Assert.
            Assert.Throws<NotFoundTravelerException>(() => this._game.Remove(this._traveler));
        }
        // Se testea remover pero sin la experiencia vacia.
        [Test]
        public void NoRemoveTravelerNoEmpty()
        {
            // Act.
            this._game.Add(this._traveler);
            // Assert.
            Assert.Throws<NotFoundTravelerException>(() => this._game.Remove(this._traveler2));
        }
        // Se testea remover viajeros con partida comenzada.
        [Test]
        public void AlreadyStartedGameRemoveTraveler()
        {
            // Act.
            this._game.Add(this._traveler);
            this._game.StartGame();
            // Assert.
            Assert.Throws<AlreadyStartedGameExcpetion>(() => this._game.Remove(this._traveler));
        }
        // Se testea que se adjudiquen los puntos al viajero.
        [Test]
        public void OneVisitFarm()
        {
            // Act.
            this._game.Add(this._farm);
            this._game.Add(this._traveler);
            this._game.StartGame();
            this._game.Move(this._traveler, this._farm);
            this._game.Move(this._traveler, this._kyoto);
            (string, int) expected = ("", this._convertor.Convert(new Coins(3)));
            // Assert.
            Assert.AreEqual(expected, this._game.Result()[0]); 
        }
        [Test]
        public void OneVisitTermal()
        {
            // Act.
            this._game.Add(this._termal);
            this._game.Add(this._traveler);
            this._game.StartGame();
            this._game.Move(this._traveler, this._termal);
            this._game.Move(this._traveler, this._kyoto);
            (string, int) expected = ("", this._convertor.Convert(new Points(2)));
            // Assert.
            Assert.AreEqual(expected, this._game.Result()[0]); 
        }
        [Test]
        public void OneVisitMountain()
        {
            // Act.
            this._game.Add(this._mountain);
            this._game.Add(this._traveler);
            this._game.StartGame();
            this._game.Move(this._traveler, this._mountain);
            this._game.Move(this._traveler, this._kyoto);
            (string, int) expected = ("", this._convertor.Convert(new Points(1)));
            // Assert.
            Assert.AreEqual(expected, this._game.Result()[0]); 
        }
        [Test]
        public void OneVisitOcean()
        {
            // Act.
            this._game.Add(this._ocean);
            this._game.Add(this._traveler);
            this._game.StartGame();
            this._game.Move(this._traveler, this._ocean);
            this._game.Move(this._traveler, this._kyoto);
            (string, int) expected = ("", this._convertor.Convert(new Points(1)));
            // Assert.
            Assert.AreEqual(expected, this._game.Result()[0]); 
        }
        // Varias visitas a las experiencias que se acumulan.
        [Test]
        public void ThreeVisitMountains()
        {
            // Act.
            this._game.Add(this._mountain);
            this._game.Add(this._mountain2);
            this._game.Add(this._mountain3);

            this._game.Add(this._traveler);

            this._game.StartGame();

            this._game.Move(this._traveler, this._mountain);
            this._game.Move(this._traveler, this._mountain2);
            this._game.Move(this._traveler, this._mountain3);
            this._game.Move(this._traveler, this._kyoto);

            (string, int) expected = ("", this._convertor.Convert(new Points(1 + 2 + 3)));
            // Assert.
            Assert.AreEqual(expected, this._game.Result()[0]); 
        }
        [Test]
        public void ThreeVisitOceans()
        {
            // Act.
            this._game.Add(this._ocean);
            this._game.Add(this._ocean2);
            this._game.Add(this._ocean3);

            this._game.Add(this._traveler);

            this._game.StartGame();

            this._game.Move(this._traveler, this._ocean);
            this._game.Move(this._traveler, this._ocean2);
            this._game.Move(this._traveler, this._ocean3);
            this._game.Move(this._traveler, this._kyoto);

            (string, int) expected = ("", this._convertor.Convert(new Points(1 + 3 + 5)));
            // Assert.
            Assert.AreEqual(expected, this._game.Result()[0]); 
        }
        // Mover sin iniciar el juego.
        [Test]
        public void NotStartedMovement()
        {
            // Act.
            this._game.Add(this._traveler);
            // Assert.
            Assert.Throws<NotStartedGameException>(() => this._game.Move(this._traveler, this._kyoto));
        }
        // Mover a una experiencia que no esta dentro del juego.
        [Test]
        public void NotInGameFarmException()
        {
            // Act.
            this._game.Add(this._traveler);
            this._game.StartGame();
            // Assert.
            Assert.Throws<NotFoundExperienceException> (() => this._game.Move(this._traveler, this._farm));
        }
        [Test]
        public void NotInGameTermalException()
        {
            // Act.
            this._game.Add(this._traveler);
            this._game.StartGame();
            // Assert.
            Assert.Throws<NotFoundExperienceException> (() => this._game.Move(this._traveler, this._termal));
        }
        [Test]
        public void NotInGameMountainException()
        {
            // Act.
            this._game.Add(this._traveler);
            this._game.StartGame();
            // Assert.
            Assert.Throws<NotFoundExperienceException> (() => this._game.Move(this._traveler, this._mountain));
        }
        [Test]
        public void NotInGameOceanException()
        {
            // Act.
            this._game.Add(this._traveler);
            this._game.StartGame();
            // Assert.
            Assert.Throws<NotFoundExperienceException> (() => this._game.Move(this._traveler, this._ocean));
        }
        // Mover a una experiencia que no esta dentro del juego pero si una del mismo tipo.
        [Test]
        public void NotInGameFarmInstanceException()
        {
            // Act.
            this._game.Add(this._farm);
            this._game.Add(this._traveler);
            this._game.StartGame();
            // Assert.
            Assert.Throws<NotFoundExperienceException> (() => this._game.Move(this._traveler, this._farm2));
        }
        [Test]
        public void NotInGameTermalInstanceException()
        {
            // Act.
            this._game.Add(this._termal);
            this._game.Add(this._traveler);
            this._game.StartGame();
            // Assert.
            Assert.Throws<NotFoundExperienceException> (() => this._game.Move(this._traveler, this._termal2));
        }
        [Test]
        public void NotInGameMountainInstanceException()
        {
            // Act.
            this._game.Add(this._mountain);
            this._game.Add(this._traveler);
            this._game.StartGame();
            // Assert.
            Assert.Throws<NotFoundExperienceException> (() => this._game.Move(this._traveler, this._mountain2));
        }
        [Test]
        public void NotInGameOceanInstanceException()
        {
            // Act.
            this._game.Add(this._ocean);
            this._game.Add(this._traveler);
            this._game.StartGame();
            // Assert.
            Assert.Throws<NotFoundExperienceException> (() => this._game.Move(this._traveler, this._ocean2));
        }
        [Test]
        public void NotInGameKyotoInstanceException()
        {
            // Act.
            this._game.Add(this._traveler);
            this._game.StartGame();
            // Assert.
            Assert.Throws<NotFoundExperienceException> (() => this._game.Move(this._traveler, this._kyoto2));
        }
        // Se testea moverse al mismo lugar.
        [Test]
        public void NotToSamePlace()
        {
            // Act.
            this._game.Add(this._traveler);
            this._game.Add(this._farm);
            this._game.StartGame();
            this._game.Move(this._traveler, this._farm);
            // Assert.
            Assert.Throws<NoGoBackExcpetion>(() => this._game.Move(this._traveler, this._farm));
        }
        // Se testea moverse fuera de turno.
        [Test]
        public void NotYourTurn()
        {
            // Act.
            this._game.Add(this._traveler);
            this._game.Add(this._traveler2);
            
            this._game.Add(this._farm);

            this._game.StartGame();
            // Assert.
            Assert.Throws<NoYourMovementExcpetion>(() => this._game.Move(this._traveler2, this._farm));
        }
        // Se testea la intercalacion en el movimiento entre viajeros.
        [Test]
        public void InterMovementCorrectly()
        {
            // Act.
            this._game.Add(this._traveler);
            this._game.Add(this._traveler2);

            this._game.Add(this._farm);

            this._game.StartGame();

            this._game.Move(this._traveler, this._farm);
            this._game.Move(this._traveler2, this._farm);
            this._game.Move(this._traveler, this._kyoto);
            this._game.Move(this._traveler2, this._kyoto);
            // Assert.
            Assert.Pass();
        }
        [Test]
        public void InterMovementIncorrectly()
        {
            // Act.
            this._game.Add(this._traveler);
            this._game.Add(this._traveler2);

            this._game.Add(this._farm);

            this._game.StartGame();

            this._game.Move(this._traveler, this._farm);
            this._game.Move(this._traveler2, this._farm);
            // Assert.
            Assert.Throws<NoYourMovementExcpetion>(() => this._game.Move(this._traveler2, this._kyoto));
        }
        // Se testea el final de la partida sin comenzar.
        [Test]
        public void NotStartedIsNotEnded()
        {
            // Assert.
            Assert.IsFalse(this._game.IsEnded());
        }
        // Se testea el final true.
        [Test]
        public void EndedEmptyGame()
        {
            // Act.
            this._game.StartGame();
            // Assert.
            Assert.IsTrue(this._game.IsEnded());
        }
        [Test]
        public void EndedNotEmptyGame()
        {
            // Act.
            this._game.Add(this._farm);
            this._game.Add(this._traveler);
            this._game.StartGame();
            // Assert.
            Assert.IsFalse(this._game.IsEnded());
        }
        [Test]
        public void EndedNotEmptyExperienceFarmGame()
        {
            // Act.
            this._game.Add(this._farm);
            this._game.Add(this._traveler);
            this._game.StartGame();
            this._game.Move(this._traveler,this._farm);
            // Assert.
            Assert.IsFalse(this._game.IsEnded());
        }
        [Test]
        public void EndedNotEmptyExperienceTermalGame()
        {
            // Act.
            this._game.Add(this._termal);
            this._game.Add(this._traveler);
            this._game.StartGame();
            this._game.Move(this._traveler,this._termal);
            // Assert.
            Assert.IsFalse(this._game.IsEnded());
        }
        [Test]
        public void EndedNotEmptyExperienceMountainGame()
        {
            // Act.
            this._game.Add(this._mountain);
            this._game.Add(this._traveler);
            this._game.StartGame();
            this._game.Move(this._traveler,this._mountain);
            // Assert.
            Assert.IsFalse(this._game.IsEnded());
        }
        [Test]
        public void EndedNotEmptyExperienceOceanGame()
        {
            // Act.
            this._game.Add(this._ocean);
            this._game.Add(this._traveler);
            this._game.StartGame();
            this._game.Move(this._traveler,this._ocean);
            // Assert.
            Assert.IsFalse(this._game.IsEnded());
        }
        [Test]
        public void EndedOnePlayerGame()
        {
            // Act.
            this._game.Add(this._traveler);
            this._game.StartGame();
            this._game.Move(this._traveler, this._kyoto);
            // Assert.
            Assert.IsTrue(this._game.IsEnded());
        }
        [Test]
        public void EndedOnePlayerOneFarmGame()
        {
            // Act.
            this._game.Add(this._farm);
            this._game.Add(this._traveler);
            this._game.StartGame();
            this._game.Move(this._traveler, this._farm);
            this._game.Move(this._traveler, this._kyoto);
            // Assert.
            Assert.IsTrue(this._game.IsEnded());
        }
        [Test]
        public void EndedOnePlayerOneTermalGame()
        {
            // Act.
            this._game.Add(this._termal);
            this._game.Add(this._traveler);
            this._game.StartGame();
            this._game.Move(this._traveler, this._termal);
            this._game.Move(this._traveler, this._kyoto);
            // Assert.
            Assert.IsTrue(this._game.IsEnded());
        }
        [Test]
        public void EndedOnePlayerOneMountainGame()
        {
            // Act.
            this._game.Add(this._mountain);
            this._game.Add(this._traveler);
            this._game.StartGame();
            this._game.Move(this._traveler, this._mountain);
            this._game.Move(this._traveler, this._kyoto);
            // Assert.
            Assert.IsTrue(this._game.IsEnded());
        }
        [Test]
        public void EndedOnePlayerOneOceanGame()
        {
            // Act.
            this._game.Add(this._ocean);
            this._game.Add(this._traveler);
            this._game.StartGame();
            this._game.Move(this._traveler, this._ocean);
            this._game.Move(this._traveler, this._kyoto);
            // Assert.
            Assert.IsTrue(this._game.IsEnded());
        }
        // Se testea con una simulacion de una partida.
        [Test]
        public void OneGameWithIntercalations()
        {
            // Act.
            // Se agregan todas las experiencias.
            this._game.Add(this._farm);
            this._game.Add(this._farm2);
            this._game.Add(this._farm3);

            this._game.Add(this._termal);
            this._game.Add(this._termal2);
            this._game.Add(this._termal3);

            this._game.Add(this._mountain);
            this._game.Add(this._mountain2);
            this._game.Add(this._mountain3);

            this._game.Add(this._ocean);
            this._game.Add(this._ocean2);
            this._game.Add(this._ocean3);

            // Se agregan todos los jugadores.
            this._game.Add(this._traveler);
            this._game.Add(this._traveler2);
            this._game.Add(this._traveler3);

            // Comienza el juego.
            this._game.StartGame();

            int expectedInt = 0;
            int expectedInt2 = 0;
            int expectedInt3 = 0;

            this._game.Move(this._traveler, this._farm2);
            expectedInt += this._convertor.Convert(new Coins(3));
            
            this._game.Move(this._traveler2, this._ocean);
            expectedInt2 += this._convertor.Convert(new Points(1));

            this._game.Move(this._traveler3, this._farm);
            expectedInt3 += this._convertor.Convert(new Coins(3));
            this._game.Move(this._traveler3, this._farm2);
            expectedInt3 += this._convertor.Convert(new Coins(3));

            this._game.Move(this._traveler, this._termal);
            expectedInt += this._convertor.Convert(new Points(2));

            this._game.Move(this._traveler3, this._farm3);
            expectedInt3 += this._convertor.Convert(new Coins(3));
            this._game.Move(this._traveler3, this._termal);
            expectedInt3 += this._convertor.Convert(new Points(2));

            this._game.Move(this._traveler, _mountain2);
            expectedInt += this._convertor.Convert(new Points(1));

            this._game.Move(this._traveler3, this._termal2);
            expectedInt3 += this._convertor.Convert(new Points(2));
            this._game.Move(this._traveler3, this._termal3);
            expectedInt3 += this._convertor.Convert(new Points(2));
            this._game.Move(this._traveler3, this._mountain);
            expectedInt3 += this._convertor.Convert(new Points(1));
            this._game.Move(this._traveler3, this._mountain2);
            expectedInt3 += this._convertor.Convert(new Points(2));

            this._game.Move(this._traveler, this._ocean);
            expectedInt += this._convertor.Convert(new Points(1));

            this._game.Move(this._traveler3, this._ocean);
            expectedInt3 += this._convertor.Convert(new Points(1));

            this._game.Move(this._traveler2, this._kyoto);
            this._game.Move(this._traveler, this._kyoto); 
            this._game.Move(this._traveler3, this._kyoto);
            
            List<(string, int)> expected = new List<(string,int)> {};
            expected.Add(("",expectedInt2));
            expected.Add(("",expectedInt));
            expected.Add(("",expectedInt3));
            // Assert.
            Assert.AreEqual(expected,this._game.Result());  
        }
        // Se testea el movimiento cuando la experiencia esta llena.            
        [Test]
        public void AFullExperienceMovement()
        {
            // Act.
            // Se agregan todas las experiencias.
            this._game.Add(this._farm3);

            this._game.Add(this._termal);

            // Se agregan todos los jugadores.
            this._game.Add(this._traveler);
            this._game.Add(this._traveler2);
            this._game.Add(this._traveler3);

            // Comienza el juego.
            this._game.StartGame();

            int expectedInt = 0;
            int expectedInt2 = 0;
            int expectedInt3 = 0;

            this._game.Move(this._traveler, this._farm3);
            expectedInt += this._convertor.Convert(new Coins(3));
            this._game.Move(this._traveler2, this._farm3);
            expectedInt2 += this._convertor.Convert(new Coins(3));
            this._game.Move(this._traveler3, this._farm3);
            expectedInt3 += this._convertor.Convert(new Points(2));

            this._game.Move(this._traveler, this._kyoto);
            this._game.Move(this._traveler2, this._kyoto);
            this._game.Move(this._traveler3, this._kyoto);

            List<(string, int)> expected = new List<(string,int)> {};
            expected.Add(("",expectedInt));
            expected.Add(("",expectedInt2));
            expected.Add(("",expectedInt3));
            // Assert.
            Assert.AreEqual(expected,this._game.Result());  
        }
        [Test]
        public void AFullExperienceMovement2()
        {
            // Act.
            // Se agregan todas las experiencias.
            this._game.Add(this._termal3);

            this._game.Add(this._farm);

            // Se agregan todos los jugadores.
            this._game.Add(this._traveler);
            this._game.Add(this._traveler2);
            this._game.Add(this._traveler3);

            // Comienza el juego.
            this._game.StartGame();

            int expectedInt = 0;
            int expectedInt2 = 0;
            int expectedInt3 = 0;

            this._game.Move(this._traveler, this._termal3);
            expectedInt += this._convertor.Convert(new Points(2));
            this._game.Move(this._traveler2, this._termal3);
            expectedInt2 += this._convertor.Convert(new Points(2));
            this._game.Move(this._traveler3, this._termal3);
            expectedInt3 += this._convertor.Convert(new Coins(3));

            this._game.Move(this._traveler, this._kyoto);
            this._game.Move(this._traveler2, this._kyoto);
            this._game.Move(this._traveler3, this._kyoto);

            List<(string, int)> expected = new List<(string,int)> {};
            expected.Add(("",expectedInt));
            expected.Add(("",expectedInt2));
            expected.Add(("",expectedInt3));
            // Assert.
            Assert.AreEqual(expected,this._game.Result());  
        }
    }
}