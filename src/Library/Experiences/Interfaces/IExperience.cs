
// OCP: Basta con implementar esta interface para agregar un nuevo tipo de experiencia (no paisaje).

// ISP: Esta interface define dos operaciones que el cliente debe usar para no depender de tipos que no se usan.

// DIP: Esta clase de alto nivel depende solamente de abstracciones.

// Polimorfismo: Las cuatro operaciones definidas son polimorficas a todos los IExperience.

using System.Collections.ObjectModel;

namespace Library
{
    public interface IExperience
    {
        public ReadOnlyCollection<AbstractTraveler> Travelers {get; }
        public bool IsEmpty();
        public bool Add(AbstractTraveler traveler);
        public bool Remove(AbstractTraveler traveler);
    }
}