
// SRP: Esta clase tiene la responsabilidad de contener a los viajeros.

// OCP: Esta clase es un ejemplo del agregado de un paisaje implementando la interface ILandscape.

// LSP: Esta clase es subtipo de ILandscape por lo tanto puede sustituirlo. 

// DIP: Esta clase de bajo nivel depende de abstracciones y clases de bajo nivel (Coins).

// Expert: Como esta clase almacena viajeros, un tamaño maximo y la diferencia entre beneficios al mismo viajero, 
// se encarga de retornar si esta vacia, agregarlos o removerlos entregando el beneficio correspondiente.

// Creator: Como esta clase almacena la diferencia entre beneficios al mismo viajero (tiene informacion necesaria),
// se encarga de crear el beneficio.

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library
{
    public class OceanLandscape : ILandscape
    {
        public int _valueDifference;

        private int _size;
        private List<AbstractTraveler> _travelers;
        public ReadOnlyCollection<AbstractTraveler> Travelers
        {
            get 
            {
                return this._travelers.AsReadOnly();
            }
        }
        public OceanLandscape(int size)
        {
            this._valueDifference = 2;

            this._size = size;
            this._travelers = new List<AbstractTraveler> ();
        }
        public bool IsEmpty()
        {
            return this._travelers.Count == 0;
        }
        public int NextValueBenefict(AbstractTraveler traveler)
        {
            int visits = traveler.Visits(this);
            int value = 1;
            for (int i = 1; i<=visits ;i++)
            {
                value += this._valueDifference;
            }
            return value;
        }
        private IAcumulable Benefict(AbstractTraveler traveler)
        {
            return new Points(this.NextValueBenefict(traveler));
        }
        public bool Add(AbstractTraveler traveler)
        {
            if (this._travelers.IndexOf(traveler) != -1)
            {
                return false;
            }
            if (this._travelers.Count + 1 <= this._size)
            {
                this._travelers.Add(traveler);
                traveler.Add(this, this.Benefict(traveler));
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