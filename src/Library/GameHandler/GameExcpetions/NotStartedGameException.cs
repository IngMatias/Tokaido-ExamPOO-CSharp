using System;

namespace Library
{
    /// <summary>
    /// Esta clase representa la excepcion a ser lanzada cuando se trate de realizar una operacion no permitida antes de iniciado el juego.
    /// </summary>
    [Serializable]
    public class NotStartedGameException : Exception
    {
        /// <summary>
        /// Inicializa una instancia de <c>NotStartedGameException</c>.
        /// </summary>
        public NotStartedGameException()
        :base("El juego no ha comenzado.")
        {
        }
    }
}