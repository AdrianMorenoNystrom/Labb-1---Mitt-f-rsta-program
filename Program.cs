using System;

namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal");
            string input = Console.ReadLine();
            int siffra;
            Int32.TryParse(input, out siffra);

            if (siffra >= 10)
            {
                Console.WriteLine("Talet är stort!");
            }
            else
            {
                Console.WriteLine("Oj. Lågt tal!");
            }

            Console.WriteLine("Vad heter du?");
            string namn = Console.ReadLine();
            Console.WriteLine($"Hej, { namn}!");

            // HÄR SKA DET VARA EN LOOP som skriver ut alla tal från noll upp till det nummer som du satte i din tidigare variabel.
        }
    }
}