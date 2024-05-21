namespace Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime birthDate = new DateTime(1996, 6, 2);
            int age = birthDate.Age();
            Console.WriteLine($"Ali Cahangirov is {age} years old.");


        }
    }
}
