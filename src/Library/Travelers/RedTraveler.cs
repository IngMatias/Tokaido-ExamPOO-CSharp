
// SRP: Esta clase tiene la responsabilidad de definir un jugador rojo. 

// OCP: Esta clase es un ejemplo del agregado de un jugador heredando la interface IExperience.

// LSP: Esta clase es subtipo de AbstractTraveler por lo tanto puede sustituirlo. 

// DIP: Esta clase de bajo nivel depende de clases de alto nivel.

namespace Library
{
    /// <summary>
    /// Esta clase representa un jugador Rojo.
    /// </summary>
    public class RedTraveler : AbstractTraveler
    {
        /// <summary>
        /// Se inicializa una instancia de <c>AbstractTraveler</c>.
        /// </summary>
        /// <param name="name">Nombre del jugador</param>
        public RedTraveler(string name)
        :base(name)
        {
        }
    }
}