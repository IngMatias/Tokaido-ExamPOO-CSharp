using System;

namespace Library
{
    [Serializable]
    public class CanNotAddLastExperienceExcpetion : Exception
    {
        public CanNotAddLastExperienceExcpetion()
        :base("No puedes agregar mas de una ultima excpetion.")
        {
        }
    }
}