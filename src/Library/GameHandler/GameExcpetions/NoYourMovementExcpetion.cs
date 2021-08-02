using System;

namespace Library
{
    [Serializable]
    public class NoYourMovementExcpetion : Exception
    {
        public NoYourMovementExcpetion()
        :base("No es tu turno.")
        {
        }
    }
}