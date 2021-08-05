using System;

namespace Library
{
    /// <summary>
    /// Esta clase representa la excepcion a ser lanzada cuando se trate de realizar una operacion no permitida antes de finalizado el juego.
    /// </summary>
    [Serializable]
    public class NotEndedGameException : Exception
    {
        /// <summary>
        /// Inicializa una instancia de <c>NotEndedGameException</c>.
        /// </summary>
        public NotEndedGameException()
        :base("El juego no ha terminado.")
        {
        }
    }
}