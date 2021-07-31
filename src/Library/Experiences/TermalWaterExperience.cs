
// SRP: Esta clase tiene la responsabilidad de contener a los viajeros.

// OCP: Esta clase es un ejemplo del agregado de una experiencia implementando la interface IExperience.

// LSP: Esta clase es subtipo de IExperience por lo tanto puede sustituirlo. 

// DIP: Esta clase de bajo nivel depende de abstracciones y clases de bajo nivel (Points).

// Expert: Como esta clase almacena viajeros, un tamaño maximo y el beneficio que otorga,
// se encarga de retornar si esta vacia, agregarlos o removerlos entregando el beneficio correspondiente.

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library
{
    public class TermalWaterExperience : IExperience
    {
        private IAcumulable _benefict;

        private int _size;
        private List<AbstractTraveler> _travelers;
        public ReadOnlyCollection<AbstractTraveler> Travelers
        {
            get 
            {
                return this._travelers.AsReadOnly();
            }
        }
        public TermalWaterExperience(int size)
        {
            this._benefict = new Points(2);

            this._size = size;
            this._travelers = new List<AbstractTraveler> ();
        }
        public bool IsEmpty()
        {
            return this._travelers.Count == 0;
        }
        public bool Add(AbstractTraveler traveler)
        {
            if (this._travelers.Count + 1 <= this._size)
            {
                this._travelers.Add(traveler);
                traveler.Add(this, this._benefict);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Remove(AbstractTraveler traveler)
        {
            return this._travelers.Remove(traveler);
        }
    }
}