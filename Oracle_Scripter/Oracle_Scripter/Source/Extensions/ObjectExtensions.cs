using System;

namespace Oracle_Scripter.Source.Extensions
{
    public static class ObjectExtensions
    {
        public static string ToStr(this object obj)
        {
            string s = string.Empty;

            try
            {
                s = string.Format("{0}", obj);
            }
            catch (Exception)
            {
            }

            return s;
        }
    }
}