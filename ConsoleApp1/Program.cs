using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        public static string JelszoGenerator(int hossz)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!.,-_<>;#&@{}đĐ[]$ß÷×¨˝()=%+*";
            var stringChar = new char[hossz];
            var random = new Random();
            var nemfelel = true;
            while (nemfelel)
            {
                for (int i = 0; i < stringChar.Length; i++)
                {
                    stringChar[i] = chars[random.Next(chars.Length)];
                }
                var checkString = new String(stringChar);
                Console.WriteLine("Trying...");
                Console.WriteLine(checkString);
                Regex regex1 = new Regex("[\\[!\\.,-_<>;#&@{}đĐ\\]\\$ß÷×¨˝\\(\\)=%\\+\\*]+");
                Regex regex2 = new Regex("[0-9]+");
                if (regex1.IsMatch(checkString) && regex2.IsMatch(checkString))
                {
                    var finalPass = new String(stringChar);
                    nemfelel = false;
                    return finalPass;
                }
            }

            return "";
            
        }


        static void Main(string[] args)
        {
            
        }
    }
}
