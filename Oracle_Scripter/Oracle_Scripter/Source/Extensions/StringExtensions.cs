namespace Oracle_Scripter.Source.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNullOrWhiteSpace(this string s)
        {
            return string.IsNullOrWhiteSpace(s);
        }

        public static string Implode(this string str, params object[] args)
        {
            string result = string.Empty;
            string s = str ?? string.Empty;

            if (args == null)
                return result;

            if (args.Length == 0)
                return result;

            if (args.Length == 1)
                return args[0].ToStr();

            for (int counter = 0; counter < args.Length - 1; counter++)
            {
                result = string.Format("{0}{1}{2}", result, args[counter], s);
            }

            result = string.Format("{0}{1}", result, args[args.Length - 1]);

            return result;
        }
    }
}