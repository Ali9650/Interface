namespace User
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Ali", " Cahangirov", RegistrationMonth.January, "3AB78EA");
            User user2 = new User("Ali", "Ibrahimov", RegistrationMonth.March, "ABCDE56");
            User user3 = new User("Ismayil", "Cavadzade", RegistrationMonth.May, "1234ABC");
            User user4 = new User("Oqtay", "Babayev", RegistrationMonth.August, "PQS5899");
            User user5 = new User("Kenan", "Ibrahimli", RegistrationMonth.December, "VVUU444");

            Console.WriteLine(user1.GetDetails());
            Console.WriteLine(user2.GetDetails());
            Console.WriteLine(user3.GetDetails());
            Console.WriteLine(user4.GetDetails());
            Console.WriteLine(user5.GetDetails());

        }
    }
}
