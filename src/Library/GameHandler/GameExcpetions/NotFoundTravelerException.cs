using System;

namespace Library
{
    /// <summary>
    /// Esta clase representa la excepcion a ser lanzada cuando se trate de realizar una operacion sobre una viajero no encontrado.
    /// </summary>
    [Serializable]
    public class NotFoundTravelerException : Exception
    {
        /// <summary>
        /// Inicializa una instancia de <c>NotFoundTravelerException</c>.
        /// </summary>
        public NotFoundTravelerException()
        :base("No se encontro ese viajero.")
        {
        }
    }
}