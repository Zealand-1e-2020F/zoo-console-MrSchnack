using System;
using Zoo_ConsoleApp.Fisketyper;

namespace Zoo_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Zoo!");

            var Sild = new Dyr("Sild");

            HvalHaj hvalhaj = new HvalHaj("Hvalhaj");

            Console.WriteLine(Sild.DyreNavn);

        }
    }
}
