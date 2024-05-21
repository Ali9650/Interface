namespace MathUtils
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 13;
            if (MathUtils.IsPrime(num))
                Console.WriteLine($"{num} is a prime number.");
            else
                Console.WriteLine($"{num} is not a prime number.");
        }
    }
}

