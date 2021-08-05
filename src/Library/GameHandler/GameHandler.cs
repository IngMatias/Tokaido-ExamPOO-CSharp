
// SRP: Esta clase tiene la responsabilidad manejar el flujo de una partida.

// OCP: Esta clase es un ejemplo del agregado de un manejador de partida implementando la interface IGameHandler.

// LSP: Esta clase es subtipo de IGameHandler por lo tanto puede sustituirlo. 

// DIP: Esta clase de bajo nivel depende de abstracciones y clases de bajo nivel (excepciones lanzadas).

// Expert: Como esta clase conoce todas las experiencias, se encarga de definir el comportamiento de agregado de nuevas experiencias,
// de agregado de nuevos viajeros, de comenzar el juego, etc.

// Creator: Se crean las expceciones lanzadas ya que se usan de manera cercana.

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library
{
    /// <summary>
    /// Esta clase se encarga de manejar el camino del juego.
    /// </summary>
    public class GameHandler : IGameHandler
    {
        private IExperience _first;
        private IExperience _last;
        private List<IExperience> _way;
        /// <summary>
        /// Inicializa una instancia de <c>GameHandler</c>
        /// </summary>
        /// <param name="first">Experiencia que marca el inicio del camino del juego, no puede haber mas de una de este tipo en el camino.</param>
        /// <param name="last">Experiencia que marca el fin del camino del juego, no puede haber mas de una de este tipo en el camino.</param>
        public GameHandler(IExperience first, IExperience last)
        {
            this._first = first;
            this._last = last;

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
            if (experience.GetType().Equals(this._first.GetType()))
            {
                throw new CanNotAddFirstExperienceExcpetion();
            }
            if (experience.GetType().Equals(this._last.GetType()))
            {
                throw new CanNotAddLastExperienceExcpetion();
            }
            if (this._way.IndexOf(experience) != -1)
            {
                throw new AlreadyAddedExperience();
            }
            this._way.Add(experience);
        }
        public void Remove(IExperience experience)
        {
            if (this.IsStarted())
            {
                throw new AlreadyStartedGameExcpetion();
            }
            if (experience.GetType().Equals(this._first.GetType()))
            {
                throw new CanNotAddFirstExperienceExcpetion();
            }
            if (experience.GetType().Equals(this._last.GetType()))
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
                    if (this._way.IndexOf(experience) >= this._way.IndexOf(to))
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
                    break;
                }
            }
        }
        public bool IsEnded()
        {
            foreach (IExperience experience in this._way)
            {
                if (!this.IsStarted())
                {
                    return false;
                }
                if (!experience.IsEmpty() && experience != this._last)
                {
                    return false;
                }
            }
            return true;
        }
        public ReadOnlyCollection<(string, int)> Result()
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
            return toReturn.AsReadOnly();
        }
    }
}