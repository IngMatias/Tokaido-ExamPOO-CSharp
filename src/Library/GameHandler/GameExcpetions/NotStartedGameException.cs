using System;

namespace Library
{
    [Serializable]
    public class NotStartedGameException : Exception
    {
        public NotStartedGameException()
        :base("El juego no ha comenzado.")
        {
        }
    }
}