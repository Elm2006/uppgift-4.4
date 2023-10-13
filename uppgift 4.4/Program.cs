using System;
using static System.Net.Mime.MediaTypeNames;

namespace uppgift_4.__4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett tal");
            string svar =Console.ReadLine();
            int siffersumma = 0;
            for (int i = 0; i < svar.Length; i++) 
            {
                string teckenString = svar[i].ToString();
                int tal = int.Parse(teckenString);
                siffersumma += tal;
            }
            Console.WriteLine("Siffersumman av talet " + svar + " = " + siffersumma);
        }
    }
}
