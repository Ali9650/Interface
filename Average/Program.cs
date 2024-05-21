namespace Average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 5, 7, 8, 2 };
            double average = numbers.CalculateAverage();
            Console.WriteLine($"Average: {average}");
        }
    }
}
