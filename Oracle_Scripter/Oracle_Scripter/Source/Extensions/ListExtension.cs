using System.Collections.Generic;

namespace Oracle_Scripter.Source.Extensions
{
    public static class ListExtension
    {
        public static bool IsNullOrEmpty<T>(this IList<T> lst) where T : new()
        {
            bool isEmpty = true;

            if (lst == null)
                return isEmpty;

            isEmpty = lst.Count < 1;
            return isEmpty;
        }
    }
}