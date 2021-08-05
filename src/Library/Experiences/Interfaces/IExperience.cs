
// OCP: Basta con implementar esta interface para agregar un nuevo tipo de experiencia (no paisaje).

// ISP: Esta interface define dos operaciones que el cliente debe usar para no depender de tipos que no se usan.

// DIP: Esta clase de alto nivel depende solamente de abstracciones.

// Polimorfismo: Las cuatro operaciones definidas son polimorficas a todos los IExperience.

using System.Collections.ObjectModel;

namespace Library
{
    /// <summary>
    /// Esta interface representa una experiencia.
    /// </summary>
    public interface IExperience
    {
        /// <summary>
        /// Obtiene una lista de los viajeros presentes en la experiencia.
        /// </summary>
        /// <value></value>
        public ReadOnlyCollection<AbstractTraveler> Travelers {get; }

        /// <summary>
        /// Obtiene un valor que indica si la experiencia se encuentra vacia (sin viajeros en ella).
        /// </summary>
        /// <returns><c>true</c> cuando la experiencia tiene cero viajeros, <c>false</c> en caso contrario.</returns>
        public bool IsEmpty();

        /// <summary>
        /// Agrega un viajero dado a la experiencia en caso de que halla espacio suficiente.
        /// </summary>
        /// <param name="traveler">Viajero para agregar a la experiencia.</param>
        /// <returns><c>true</c> cuando la experiencia logra guardar el viajero, <c>false</c> en caso contrario, cuando se encuentra llena la experiencia.</returns>
        public bool Add(AbstractTraveler traveler);

        /// <summary>
        /// Remueve un viajero dado de la experiencia.
        /// </summary>
        /// <param name="traveler">Viajero para ser removido de la experiencia.</param>
        /// <returns><c>true</c> cuando el viajero se encuentra en la experiencia y es removido, <c>false</c> en caso contrario, cuando no se encuentra el viajero.</returns>
        public bool Remove(AbstractTraveler traveler);
    }
}