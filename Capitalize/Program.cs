using System.Text;

namespace Capitalize
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string name = "ali";
            Console.WriteLine(Capitalize(name));
        }
        public static string Capitalize(this string word)
        {
            StringBuilder sb = new();
            for (int i = 0; i < word.Length; i++)
            {
                {
                    if (i == 0)
                    {
                        sb.Append(word[0].ToString().ToUpper());
                        continue;
                    }
                    sb.Append(word[i]);
                }
            }
            return sb.ToString();
        }
    }
}

