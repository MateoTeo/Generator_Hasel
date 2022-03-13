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


            string[] znaki = new string[]{"!", "\"", "#", "$", "%", "&", "'", "(", ")", "*", "+", ",", "-", ".", "/",
                          "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ":", ";", "<", "=", ">", "?",
                          "@", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O",
                          "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "[", "\\", "]", "^", "_",
                          "'", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o",
                          "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "{", "|", "}", "~"};
                      

            Console.WriteLine("Podaj ilość znaków do stworzenia klucza \nmaksymalna ilość 255");
            ilosc = byte.Parse(Console.ReadLine());
                        
            for (int i = 0; i <= ilosc; i++)
            {                
                int pozycja = rnd.Next(0, 93);
                klucz += znaki[pozycja];
            }
            Console.WriteLine(klucz);

            Console.ReadKey();            
        }

        

        
    }
}
