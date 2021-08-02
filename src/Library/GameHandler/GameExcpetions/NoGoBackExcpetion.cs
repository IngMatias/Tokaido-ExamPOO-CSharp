using System;

namespace Library
{
    [Serializable]
    public class NoGoBackExcpetion : Exception
    {
        public NoGoBackExcpetion()
        :base("No se permiten los movimientos hacia atrás.")
        {
        }
    }
}