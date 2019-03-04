using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lato = new int[3];
            for (int i = 0; i < 3; i++)
            {
                lato[i] = AskandCheckNumber(string.Concat("inserisci lato", i + 1));
            }

           

            if (IsTriangle(lato[0],lato[1],lato[2]))
            {
                Console.WriteLine("è un triangolo");
            }
            else
            {
                Console.WriteLine("non è un triangolo");

                do
                {
                    int m = Math.Max(Math.Max(lato[0], lato[1]), lato[2]);

                    int index = Array.IndexOf(lato, m);
                    lato[index] = lato[index]-1;
                }
                while (!IsTriangle(lato[0], lato[1], lato[2]));
                Console.WriteLine($"questi valori invece costituiscono un triangolo {lato[0]}, {lato[1]}, {lato[2]}");
            }

            Console.ReadLine();
        }
        /// <summary>
        /// Mostra all'utente il messaggio e prova
        /// convertire il valore inserito in input in un intero
        /// </summary>
        /// <param name="message">Messaggio mostrato all'utente</param>
        /// <returns></returns>
        static int AskandCheckNumber(string message)
        {
            System.Diagnostics.Debug.WriteLine(string.Concat("Message:", message));
            Console.WriteLine(message);
            string input = Console.ReadLine();
            bool conversionOk = int.TryParse(input, out int convertedValue);

            if (!conversionOk)
                Console.WriteLine("l'imput non valido");

            if (convertedValue <= 0)
                Console.WriteLine("il valore deve essere un intero positivo");

            System.Diagnostics.Debug.WriteLine($"{message}:{input}");

            return convertedValue;

        }
        /// <summary>
        /// Algoritmo per verificare se è un triangolo
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>true se a, b, c formano triangolo, false in caso contrario </returns>
        static bool IsTriangle (int a , int b, int c)
        {
            bool sumOK = a + b > c && a + c > b && b + c > a;
            bool difOk = a > Math.Abs(b - c) && b > Math.Abs(a - c) && c > Math.Abs(b - a);

            return sumOK && difOk;
        }
    }
}
