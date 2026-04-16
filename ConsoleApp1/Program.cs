using System.ComponentModel.Design;
using System.Xml;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nev = "";
            while (true) {

                //Menu
                if (nev == "") {
                    Console.WriteLine("Add meg a neved:");
                    nev = Console.ReadLine();
                }
                    
                Console.WriteLine($"Üdvözöllek,{nev}!");
                Console.WriteLine("Mit szeretnél csinálni?");
                Console.WriteLine("1. Jelszó ellenőrzése");
                Console.WriteLine("2. Jelszó generálása");
                Console.WriteLine("3. Kilépés");

                var program = 0;

                switch (Convert.ToInt32(Console.ReadLine())){
                    case 1: program = 1; break;
                    case 2: program = 2; break;
                    case 3: Environment.Exit(0); break;
                    default: Console.WriteLine("Hibás választás! Próbáld újra."); break;
                }

                //Ellenőrzés
                while (program == 1) {
                    Console.WriteLine("Jelszó ellenőrzése ciklus jön ide. Kilépéshez nyomj entert.");
                    if (Console.ReadLine() == "") { program = 0; break; }
                }

                //Generálás
                while (program == 2) {
                    Console.WriteLine("Jelszó generálás ciklus jön ide. Kilépéshez nyomj entert.");
                    if (Console.ReadLine() == "") { program = 0; break; }
                }
            }
        }
    }
}
