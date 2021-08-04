using System;

namespace Library
{
    public class AlreadyAddedExperience : Exception
    {
        public AlreadyAddedExperience()
        :base("Ya se agrego esa experiencia.")
        {
        }
    }
}