using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorKluczy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte ilosc;
            string klucz = "";
            Random rnd = new Random();


            string[] tablicaZnakowZpecjalnych = new string[] {"!", "\"", "#", "$", "%", "&", "'", "(", ")", "*", "+", ",", "-", ".", "/","{", "|", "}", "~", ":", ";", "<", "=", ">", "?",  "[", "\\", "]", "^", "_", "'", "@"};
            string[] tablicaCyfr = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] tablicaDuzychLiter = new string[] {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O","P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string[] tablicaMalychLiter = new string[] {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o","p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

            string[] znaki = new string[] { };


            Console.WriteLine("Czy chcesz uzywać znaków specjalnych? (tak/nie) ");
            string znakiSpecjalne = Console.ReadLine();
            znakiSpecjalne.ToLower();

            Console.WriteLine("Czy chcesz używać cyfr? (tak/nie)");
            string cyfry = Console.ReadLine();
            cyfry.ToLower();

            Console.WriteLine("Czy chcesz używać dużych liter? (tak/nie)");
            string duzeLitery = Console.ReadLine();
            duzeLitery.ToLower();

            Console.WriteLine("Czy chcesz używać małych liter? (tak/nie)");
            string maleLitery = Console.ReadLine();
            maleLitery.ToLower();

            Console.WriteLine("Podaj ilość znaków do stworzenia klucza \nmaksymalna ilość 255");
            ilosc = byte.Parse(Console.ReadLine());



            if (znakiSpecjalne == "tak")
            {
                znaki = znaki.Concat(tablicaZnakowZpecjalnych).ToArray();
            }
            if (cyfry == "tak")
            {
                znaki = znaki.Concat(tablicaCyfr).ToArray();
            }
            if (duzeLitery == "tak")
            {
                znaki = znaki.Concat(tablicaDuzychLiter).ToArray();
            }
            if (maleLitery == "tak")
            {
                znaki = znaki.Concat(tablicaMalychLiter).ToArray();
            }


            for (int i = 0; i <= ilosc; i++)
            {
                int pozycja = rnd.Next(0, znaki.Length);
                klucz += znaki[pozycja];
            }
            Console.WriteLine(klucz);

            Console.ReadKey();
        }       

        
    }
}
