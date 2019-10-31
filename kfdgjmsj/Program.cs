using System;

namespace kfdgjmsj
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //declaraties
            ushort leeftijd;

            //input
            Console.WriteLine("wat is uw huidige leeftijd?: ");
            leeftijd = ushort.Parse(Console.ReadLine());

            //bereken
            if (leeftijd > 18)
            {
                Console.WriteLine("je bent oud genoeg om deel te nemen aan de loterij");
            }
            else
            {
                Console.WriteLine("om deel te nemen moet je minimum 18 jaar oud zijn");
            }

            //toon


            //wachten
            Console.WriteLine();
            Console.WriteLine("druk op enter om af te sluiten");
            Console.ReadKey();
        }
    }
}
