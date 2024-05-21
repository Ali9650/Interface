namespace Months
{
    public static class Program {
        public static void Main()
        {
            int months = Convert.ToInt32(Console.ReadLine());

            switch (months)
            {
                case (int) Months.Yanvar:
                    Console.WriteLine("Yanvar, qis ayidir");
                    break;
                case (int)Months.Fevral:
                    Console.WriteLine("Fevral, qis ayidir");
                    break;
                case (int)Months.Mart:
                    Console.WriteLine("Mart, yaz ayidir");
                    break;
                case (int)Months.Aprel:
                    Console.WriteLine("Aprel, yaz ayidir");
                    break;
                case (int)Months.May:
                    Console.WriteLine("May, yaz ayidir");
                    break;
                case (int)Months.İyun:
                    Console.WriteLine("Iyun, yay ayidir");
                    break;
                case (int)Months.İyul:
                    Console.WriteLine("Iyul, yay ayidir");
                    break;
                case (int)Months.Avqust:
                    Console.WriteLine("Avqust, yay ayidir");
                    break;
                case (int)Months.Sentyabr:
                    Console.WriteLine("Sentyabr, payiz ayidir");
                    break;
                case (int)Months.Oktyabr:
                    Console.WriteLine("Oktyabr, payiz ayidir");
                    break;
                case (int)Months.Noyabr:
                    Console.WriteLine("Noyabr, payiz ayidir");
                    break;
                case (int)Months.Dekabr:
                    Console.WriteLine("Dekabr, qis ayidir");
                    break;
                default:
                    Console.WriteLine("Bele ay yoxdur");
                    break;

            }
        }
    } }
    

