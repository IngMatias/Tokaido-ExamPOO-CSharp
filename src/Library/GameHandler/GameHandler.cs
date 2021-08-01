
// SRP: Esta clase tiene la responsabilidad manejar el flujo de una partida.

// OCP: Esta clase es un ejemplo del agregado de un manejador de partida implementando la interface IGameHandler.

// LSP: Esta clase es subtipo de IGameHandler por lo tanto puede sustituirlo. 

// DIP: Esta clase de bajo nivel depende de abstracciones y clases de bajo nivel (EdoExperience, KyotoExperience, admeas de las excepciones lanzadas).

// Expert: Como esta clase conoce todas las experiencias, se encarga de definir el comportamiento de agregado de nuevas experiencias,
// de agregado de nuevos viajeros, de comenzar el juego, etc.

// Creator: Se crean las expceciones lanzadas ya que se usan de manera cercana.

using System.Collections.Generic;

namespace Library
{
    public class GameHandler : IGameHandler
    {
        private IExperience _first;
        private IExperience _last;
        private List<IExperience> _way;

        public GameHandler()
        {
            this._first = new EdoExperience();
            this._last = new KyotoExperience();

            this._way = new List<IExperience>();

            this._way.Add(this._first);
        }
        public void StartGame()
        {
            if (this._way.IndexOf(this._last) != -1)
            {
                throw new AlreadyStartedGameExcpetion();
            }
            this._way.Add(this._last);
        }
        public bool IsStarted()
        {
            int lastIndex = this._way.Count - 1;
            return this._way[lastIndex] == this._last;
        }
        public void Add(IExperience experience)
        {
            if (this.IsStarted())
            {
                throw new AlreadyStartedGameExcpetion();
            }
            if (experience.GetType().Equals(this._first))
            {
                throw new CanNotAddFirstExperienceExcpetion();
            }
            if (experience.GetType().Equals(this._last))
            {
                throw new CanNotAddLastExperienceExcpetion();
            }
            this._way.Add(experience);
        }
        public void Remove(IExperience experience)
        {
            if (this.IsStarted())
            {
                throw new AlreadyStartedGameExcpetion();
            }
            if (experience.GetType().Equals(this._first))
            {
                throw new CanNotAddFirstExperienceExcpetion();
            }
            if (experience.GetType().Equals(this._last))
            {
                throw new CanNotAddLastExperienceExcpetion();
            }
            if (this._way.IndexOf(experience) == -1)
            {
                throw new NotFoundExperienceException();
            }
            this._way.Remove(experience);
        }
        public void Add(AbstractTraveler traveler)
        {
            if (this.IsStarted())
            {
                throw new AlreadyStartedGameExcpetion();
            }
            if (this._first.Travelers.IndexOf(traveler) != -1)
            {
                throw new AlreadyInGameExcpetion();
            }
            this._first.Add(traveler);
        }
        public void Remove(AbstractTraveler traveler)
        {
            if (this.IsStarted())
            {
                throw new AlreadyStartedGameExcpetion();
            }
            if (this._first.Travelers.IndexOf(traveler) == -1)
            {
                throw new NotFoundTravelerException();
            }
            this._first.Remove(traveler);
        }
        public void Move(AbstractTraveler traveler, IExperience to)
        {
            if (!this.IsStarted())
            {
                throw new NotStartedGameException();
            }
            int intTo = this._way.IndexOf(to);
            if (intTo == -1)
            {
                throw new NotFoundExperienceException();
            }
            foreach (IExperience experience in this._way)
            {
                if (!experience.IsEmpty())
                {
                    if (experience.Travelers[0] != traveler)
                    {
                        throw new NoYourMovementExcpetion();
                    }
                    if (this._way.IndexOf(experience) > this._way.IndexOf(to))
                    {
                        throw new NoGoBackExcpetion();
                    }
                    experience.Remove(traveler);
                    IExperience tryTo = to;
                    bool added = tryTo.Add(traveler);
                    while (!added)
                    {
                        tryTo = this._way[intTo + 1];
                        intTo++;
                        added = tryTo.Add(traveler);
                    }
                }
            }
        }
        public bool IsEnded()
        {
            foreach (IExperience experience in this._way)
            {
                if (!experience.IsEmpty() && experience != this._last)
                {
                    return false;
                }
            }
            return true;
        }
        public List<(string, int)> Result()
        {
            if (!this.IsEnded())
            {
                throw new NotEndedGameException();
            }
            List<(string, int)> toReturn = new List<(string, int)>();
            foreach (AbstractTraveler traveler in this._last.Travelers)
            {
                toReturn.Add(traveler.Result());
            }
            return toReturn;
        }
    }
}