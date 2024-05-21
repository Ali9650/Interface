using System.Threading.Channels;

namespace TemperatureConverter
{
    internal class Program
    {
        static void Main ()
        {
            double celsius = 56;
            double fahrenheit = 45;
            Console.WriteLine(TemperatureConverter.CelsiusToFahrenheit(celsius));
            Console.WriteLine(TemperatureConverter.FahrenheitToCelsius(fahrenheit));
        }
    
    }
}
