using System;

namespace Library
{
    [Serializable]
    public class AlreadyStartedGameExcpetion : Exception
    {
        public AlreadyStartedGameExcpetion()
        :base("El juego ya esta comenzado.")
        {
        }
    }
}