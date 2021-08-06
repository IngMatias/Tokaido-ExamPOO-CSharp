
// OCP: Basta con implementar esta interface para agregar un nuevo tipo de manejador de partida.

// ISP: Esta interface define varias operaciones, que el cliente debe usar para no depender de tipos que no se usan.

// DIP: Esta clase de alto nivel depende solamente de abstracciones.

using System.Collections.ObjectModel;

namespace Library
{
    /// <summary>
    /// Esta interface representa un manjeador de juego, con las operaciones basicas que debe tener.
    /// </summary>
    public interface IGameHandler
    {
        /// <summary>
        /// Comienza el juego (se habilitan ciertas operaciones, mientras se inhabilitan otras).
        /// </summary>
        public void StartGame();

        /// <summary>
        /// Obtiene un valor que indica si si el juego ha comenzado.
        /// </summary>
        /// <returns><c>true</c> si el juego ya ha comenzado, <c>false</c> en caso contrario.</returns>
        public bool IsStarted();

        /// <summary>
        /// Agrega una experiencia al camino del juego.
        /// </summary>
        /// <param name="experience">Experiencia a ser agregada en el camino.</param>
        public void Add(IExperience experience);

        /// <summary>
        /// Remueve una experiencia del camino del juego.
        /// </summary>
        /// <param name="experience">Experiencia a ser removida del juego.</param>
        public void Remove(IExperience experience);

        /// <summary>
        /// Agrega un viajero al juego.
        /// </summary>
        /// <param name="traveler">Viajero a ser agregado al juego.</param>
        public void Add(AbstractTraveler traveler);

        /// <summary>
        /// Remueve un viajero al juego.
        /// </summary>
        /// <param name="traveler">Viajero a ser removido del juego.</param>
        public void Remove(AbstractTraveler traveler);

        /// <summary>
        /// Mueve un viajero desde su posicion a la experiencia dada.
        /// </summary>
        /// <param name="traveler">Viajero a ser movido.</param>
        /// <param name="to">Experiencia a la que es movido el viajero.</param>
        public void Move(AbstractTraveler traveler, IExperience to);

        /// <summary>
        /// Obtiene un valor que indica si el juego ha terminado.
        /// </summary>
        /// <returns><c>true</c> si el juego esta terminado <c>false</c> en caso contrario.</returns>
        public bool IsEnded();

        /// <summary>
        /// Obtine una lista de parejas con los nombres de los jugadores y sus puntajes al final del juego.
        /// </summary>
        /// <returns>Retorna la lista resultado de toda la partida (parejas nombre-puntaje).</returns>
        public ReadOnlyCollection<(string, int)> Result();

        /// <summary>
        /// Obtiene una lista de personas con el maximo puntaje (los ganadores).
        /// </summary>
        /// <returns>Retorna la lista de ganadores (todos aquellos con el puntaje mas alto).</returns>
        public ReadOnlyCollection<(string, int)> Winners();
    }
}