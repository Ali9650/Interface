

namespace User
{
    internal static class StringExtension
    {
        public static bool IsValidPIN(this string pin)
        {
            return pin.Length == 7 && pin.ToUpper() == pin;
        }
    }
}
