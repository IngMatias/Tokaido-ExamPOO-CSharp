using System;

namespace Library
{
    [Serializable]
    public class NotEndedGameException : Exception
    {
        public NotEndedGameException()
        :base("El juego no ha terminado.")
        {
        }
    }
}