using System;

namespace Library
{
    /// <summary>
    /// Esta clase representa la excepcion a ser lanzada cuando se trate de realizar una operacion no permitida luego de comenzado el juego.
    /// </summary>
    [Serializable]
    public class AlreadyStartedGameExcpetion : Exception
    {
        /// <summary>
        /// Inicializa una instancia de <c>AlreadyStartedGameExcpetion</c>.
        /// </summary>
        public AlreadyStartedGameExcpetion()
        :base("El juego ya esta comenzado.")
        {
        }
    }
}