

namespace Polindrom
{
    internal static class StringPolindrom
    {
        public static bool IsPolindrom(this string word)
        {
            var reversedWord = new string(word.Reverse().ToArray());

            if (reversedWord == word)
            {
                return true;
            }

            return false;
        }
    }
}
