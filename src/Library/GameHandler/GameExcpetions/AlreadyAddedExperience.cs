using System;

namespace Library
{
    /// <summary>
    /// Esta clase representa la excepcion a ser lanzada cuando se trate de agregar mas de una vez una misma instancia de una experiencia.
    /// </summary>
    [Serializable]
    public class AlreadyAddedExperience : Exception
    {
        /// <summary>
        /// Inicializa una instancia de <c>AlreadyAddedExperience</c>.
        /// </summary>
        public AlreadyAddedExperience()
        :base("Ya se agrego esa experiencia.")
        {
        }
    }
}