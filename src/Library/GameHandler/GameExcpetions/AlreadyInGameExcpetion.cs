using System;

namespace Library
{
    [Serializable]
    public class AlreadyInGameExcpetion : Exception
    {
        public AlreadyInGameExcpetion()
        :base("Ya te encuentras en partida.")
        {
        }
    }
}