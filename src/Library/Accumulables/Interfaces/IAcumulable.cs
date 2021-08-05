
// OCP: Basta con implementar esta interface para agregar un nuevo tipo de moneda.

// ISP: Esta interface define una sola operacion para que el cliente no dependa de tipos que no se usa.

// DIP: Esta clase de alto nivel depende solamente de abstracciones.

// Polimorfismo: Value es una propiedad polimorfica a todos los IAcumulables.

namespace Library
{
    /// <summary>
    /// Esta interface representa una bolsa de monedas.
    /// </summary>
    public interface IAcumulable
    {
        /// <summary>
        /// Obtiene la cantidad de monedas dentro de la bolsa (sin tener en cuenta su valor).
        /// </summary>
        /// <value>Cero si la bolsa de monedas se encuentra vacia.</value>
        public int Value {get; }
    }
}