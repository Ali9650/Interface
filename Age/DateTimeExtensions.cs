

namespace Age
{
    internal static class DateTimeExtensions
    {
        public static int Age(this DateTime birthDate)
        {
            if (birthDate > DateTime.Now)
            {
                Console.WriteLine( "Tevelludu sehvdi");
            }

            int age = DateTime.Now.Year - birthDate.Year;

            return age;
            
        }
    }
}

   
