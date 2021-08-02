using System;

namespace Library
{
    [Serializable]
    public class NotFoundExperienceException : Exception
    {
        public NotFoundExperienceException()
        :base("No se encontro esa experiencia.")
        {
        }
    }
}