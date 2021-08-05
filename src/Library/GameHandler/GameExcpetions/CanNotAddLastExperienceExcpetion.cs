using System;

namespace Library
{
    /// <summary>
    /// Esta clase representa la excepcion a ser lanzada cuando se trate de agregar mas de una vez una misma experiencia que marca el final del camino del juego (normalmente una <c>KyotoExperience</c>).
    /// </summary>
    [Serializable]
    public class CanNotAddLastExperienceExcpetion : Exception
    {
        /// <summary>
        /// Inicializa una instancia de <c>CanNotAddLastExperienceExcpetion</c>.
        /// </summary>
        public CanNotAddLastExperienceExcpetion()
        :base("No puedes agregar mas de una ultima excpetion.")
        {
        }
    }
}