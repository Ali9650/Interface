

using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace User
{
    internal class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public RegistrationMonth RegistrationMonth { get; set; }
        public string PIN { get; set; }

        public User(string name, string surname, RegistrationMonth registrationMonth, string pin)
        {
            Name = name;
            Surname = surname;
            RegistrationMonth = registrationMonth;
            PIN = pin;
        }
        public string GetDetails()
        {
            return $"Name: {Name}, Surname: {Surname}, Registration Month: {RegistrationMonth}, PIN: {PIN}";
        }

    }
}
