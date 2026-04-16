using System.ComponentModel.Design;
using System.Xml;

namespace ConsoleApp1
{
    internal class Program
    {
        static void JelszoEllenorzes()
        {
            string jelszo = Console.ReadLine();
            int pontszam = 0;

            if (jelszo == "") {
                return;
            }

            for (int i = 0; i < jelszo.Length; i++)
            {
                pontszam += 1;
                if (char.IsUpper(jelszo[i])) { pontszam += 1; }
                else if (char.IsDigit(jelszo[i])) { pontszam += 2; }
                else if (char.IsSymbol(jelszo[i]) || char.IsPunctuation(jelszo[i])) { pontszam += 3; }
            }

            double ero = pontszam / jelszo.Length;

            if (ero < 1 || jelszo.Length < 10){ Console.WriteLine($"Gyenge jelszó. ({ero})"); }
            else if (ero > 1 && ero < 3) { Console.WriteLine($"Közepes jelszó. ({ero})"); }
            else if (ero > 3) { Console.WriteLine($"Erős jelszó. ({ero})"); }
        }

        static void Main(string[] args)
        {
            string nev = "";
            while (true) {

                //Menu
                if (nev == "") {
                    Console.WriteLine("Add meg a neved:");
                    nev = Console.ReadLine();
                }

                Console.WriteLine("- - -");
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
                    Console.WriteLine("Jelszó ellenőrzése ciklus jön ide. Kérjük írd be a jelszavad:");
                    JelszoEllenorzes();
                    program = 0;
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
