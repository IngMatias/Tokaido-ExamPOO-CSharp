using System;

namespace Library
{
    /// <summary>
    /// Esta clase representa la excepcion a ser lanzada cuando se trate de agregar mas de una vez una misma instancia de un jugador.
    /// </summary>
    [Serializable]
    public class AlreadyInGameExcpetion : Exception
    {
        /// <summary>
        /// Inicializa una instancia de <c>AlreadyInGameExcpetion</c>.
        /// </summary>
        public AlreadyInGameExcpetion()
        :base("Ya te encuentras en partida.")
        {
        }
    }
}