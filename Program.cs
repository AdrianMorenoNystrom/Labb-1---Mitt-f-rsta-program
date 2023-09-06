// Adrian Moreno Nyström - .NET23

using System;

namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal");
            // Denna rad skriver ut till användaren att den ska skriva in ett tal.
            string input = Console.ReadLine();
            int number;
            Int32.TryParse(input, out number);

            /* I dessa rader så förvarar jag det användaren skriver i en stringvariabel som jag döper till input.
             * Men eftersom Console.Readline() förvarar inputen som en string, så gör jag om den till en int.
            */

            if (number >= 10)
            {
                Console.WriteLine("Talet är stort!");
            }
            else
            {
                Console.WriteLine("Oj. Lågt tal!");
            }

            /* Här är IF-satsen som kollar om talet är större eller lika med 10
             * är det inte större eller lika med 10 så skriver den ut en annan mening.
            */

            Console.WriteLine("Vad heter du?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hej, { name}!");
            
            /* I dessa 3 rader frågar jag användaren vad den heter, sparar namnet i en variabel som jag döper
             * till name och matar sedan ut texten "Hej (variabel)".
             */

            for(int i=0; i<number+1; i++)
            {
                Console.WriteLine(i);
            }

            /* Här är for-loopen som räknar upp sifforna från 0 till det tal användaren väljer
             *jag ger en int variabel namnet i som tilldelas siffran 0, och säger att så länge 
             *i är mindre än variabel "number" som är den användaren matar in så ska den plussa på en.
             *koden som loopas är en utmatning av detta.
             */
           
        }
    }
}