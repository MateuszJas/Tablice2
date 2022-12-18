using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pobierz rozmiar tablicy od użytkownika
            Console.WriteLine("Podaj rozmiar tablicy:");
            int n = int.Parse(Console.ReadLine());

            // Stwórz tablicę o podanym rozmiarze
            int[] t1 = new int[n];

            // Wypełnij tablicę wartościami podanymi przez użytkownika
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj wartość dla elementu o indeksie {0}:", i);
                t1[i] = int.Parse(Console.ReadLine());
            }

            // Wyświetl zawartość tablicy
            Console.WriteLine("Zawartość tablicy:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(t1[i]);
                
            }

            Console.ReadKey();
        }
    }
}



