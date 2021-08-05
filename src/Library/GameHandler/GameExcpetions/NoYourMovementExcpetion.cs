using System;

namespace Library
{
    /// <summary>
    /// Esta clase representa la excepcion a ser lanzada cuando se trate de realizar una movimiento de un viajero que no es el siguiente en mover.
    /// </summary>
    [Serializable]
    public class NoYourMovementExcpetion : Exception
    {
        /// <summary>
        /// Inicializa una instancia de <c>NoYourMovementExcpetion</c>.
        /// </summary>
        public NoYourMovementExcpetion()
        :base("No es tu turno.")
        {
        }
    }
}