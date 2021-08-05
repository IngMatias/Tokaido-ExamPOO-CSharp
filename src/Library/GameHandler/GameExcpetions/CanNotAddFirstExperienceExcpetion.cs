using System;

namespace Library
{
    /// <summary>
    /// Esta clase representa la excepcion a ser lanzada cuando se trate de agregar mas de una vez una misma experiencia que marca el incio del camino del juego (normalmente una <c>EdoExperience</c>).
    /// </summary>
    [Serializable]
    public class CanNotAddFirstExperienceExcpetion : Exception
    {
        /// <summary>
        /// Inicializa una instancia de <c>CanNotAddFirstExperienceExcpetion</c>.
        /// </summary>
        public CanNotAddFirstExperienceExcpetion()
        :base("No puedes agregar mas de una primera excpetion.")
        {
        }
    }
}