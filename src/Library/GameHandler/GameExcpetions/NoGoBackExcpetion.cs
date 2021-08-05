using System;

namespace Library
{
    /// <summary>
    /// Esta clase representa la excepcion a ser lanzada cuando se trate de mover un viajero hacia atrás.
    /// </summary>
    [Serializable]
    public class NoGoBackExcpetion : Exception
    {
        /// <summary>
        /// Inicializa una instancia de <c>NoGoBackExcpetion</c>.
        /// </summary>
        public NoGoBackExcpetion()
        :base("No se permiten los movimientos hacia atrás.")
        {
        }
    }
}