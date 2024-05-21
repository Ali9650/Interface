namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ICalculator calculator = new Calculator();
            double num1 = 10;
            double num2 = 5;

           
            Console.WriteLine($"Toplama: {calculator.Add(num1, num2)}");

           
            Console.WriteLine($"Ferq: {calculator.Subtract(num1, num2)}");

            
            Console.WriteLine($"Vurma: {calculator.Multiply(num1, num2)}");

          
             Console.WriteLine($"Bölme: {calculator.Divide(num1, num2)}");    
        }
    }
}

