namespace Reversed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Good night";
            string reversedText = text.Reverse();
            Console.WriteLine($"Original: {text}");
            Console.WriteLine($"Reversed: {reversedText}");
        }
    }
}
