
// OCP: Basta con implementar esta interface para agregar un nuevo tipo de paisaje.

// ISP: Esta interface define una sola operacion para que el cliente no dependa de tipos que no se usa.

// DIP: Esta clase de alto nivel depende solamente de abstracciones.

// Polimorfismo: La operacion definida es polimorfica a todos los paisajes.

namespace Library
{
    /// <summary>
    /// Esta interface representa un paisaje.
    /// </summary>
    public interface ILandscape : IExperience
    {
        /// <summary>
        /// Dado un viajero retorna la proxima cantidad de monedas de su proximo beneficio.
        /// </summary>
        /// <param name="traveler">Viajero a ser consultado por su proximo beneficio.</param>
        /// <returns>Cantidad de monedas de su proximo beneficio.</returns>
        public int NextValueBenefict(AbstractTraveler traveler);
    }
}