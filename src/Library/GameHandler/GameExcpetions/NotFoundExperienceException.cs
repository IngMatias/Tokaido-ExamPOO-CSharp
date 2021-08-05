using System;

namespace Library
{
    /// <summary>
    /// Esta clase representa la excepcion a ser lanzada cuando se trate de realizar una operacion sobre una experiencia no encontrada.
    /// </summary>
    [Serializable]
    public class NotFoundExperienceException : Exception
    {
        /// <summary>
        /// Inicializa una instancia de <c>NotFoundExperienceException</c>.
        /// </summary>
        public NotFoundExperienceException()
        :base("No se encontro esa experiencia.")
        {
        }
    }
}