using System;

namespace Library
{
    [Serializable]
    public class NotFoundTravelerException : Exception
    {
        public NotFoundTravelerException()
        :base("No se encontro ese viajero.")
        {
        }
    }
}