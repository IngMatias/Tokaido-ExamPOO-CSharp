using System;

namespace Library
{
    [Serializable]
    public class CanNotAddFirstExperienceExcpetion : Exception
    {
        public CanNotAddFirstExperienceExcpetion()
        :base("No puedes agregar mas de una primera excpetion.")
        {
        }
    }
}