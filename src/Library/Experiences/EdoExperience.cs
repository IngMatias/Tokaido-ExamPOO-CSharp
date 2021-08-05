
// SRP: Esta clase tiene la responsabilidad de contener a los viajeros.

// OCP: Esta clase es un ejemplo del agregado de una experiencia implementando la interface IExperience.

// LSP: Esta clase es subtipo de IExperience por lo tanto puede sustituirlo. 

// DIP: Esta clase de bajo nivel depende de abstracciones.

// Expert: Como esta clase almacena viajeros, se encarga de retornar si esta vacia, agregarlos o removerlos.

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library
{
    /// <summary>
    /// Esta clase representa la experiencia Kyoto, que normalmente es la primera en el camino del juego.
    /// </summary>
    public class EdoExperience : IExperience
    {
        private List<AbstractTraveler> _travelers;
        public ReadOnlyCollection<AbstractTraveler> Travelers
        {
            get 
            {
                return this._travelers.AsReadOnly();
            }
        }
        /// <summary>
        /// Inicializa una instancia de <c>EdoExperience</c>.
        /// </summary>
        public EdoExperience()
        {
            this._travelers = new List<AbstractTraveler>();
        }
        public bool IsEmpty()
        {
            return this._travelers.Count == 0;
        }
        public bool Add(AbstractTraveler traveler)
        {
            if (this._travelers.IndexOf(traveler) != -1)
            {
                return false;
            }
            traveler.Add(this, new Coins(0));
            this._travelers.Add(traveler);
            return true;
        }
        public bool Remove(AbstractTraveler traveler)
        {
            return this._travelers.Remove(traveler);
        }
    }
}