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
            int lato1 = AskandCheckNumber("inserisci primo lato");
            int lato2 = AskandCheckNumber("inserisci secondo lato");
            int lato3 = AskandCheckNumber("inserisci terzo lato");


            bool sumOK = lato1 + lato2 > lato3 && lato1 + lato3 > lato2 && lato2 + lato3 > lato1;
            bool difOk = lato1 > Math.Abs(lato2 - lato3) && lato2 > Math.Abs(lato1 - lato3) && lato3 > Math.Abs(lato2 - lato1);



            if ( sumOK && difOk )
            {
                Console.WriteLine("è un triangolo");
            }
            else
            {
                Console.WriteLine("non è un triangolo");
            }

            Console.ReadLine();
        }
        /// <summary>
        /// Nostra all'utente il messaggio e prova
        /// convertire il valore inserito in input in un intero
        /// </summary>
        /// <param name="message">Messaggio mostrato all'utente</param>
        /// <returns></returns>
        static int AskandCheckNumber (string message)
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
    }
}
