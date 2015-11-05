using System;

namespace Vsite.CSharp
{
    class GranjanjeIf
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši neki cijeli broj:");
            string unos = Console.ReadLine();

            try
            {
                int broj = int.Parse(unos);

                // TODO: Napisati grananja if koja će za uneseni broj:
                // 1. provjeriti je li broj paran. Ako je broj paran, ispisat će poruku "broj N je djeljiv s 2", a inače će
                if (broj % 2 == 0)
                    Console.WriteLine("broj {0} je djeljiv s 2",broj);
                // 2. provjeriti je li broj djeljiv s 3. Ako je broj djeljiv, ispisat će poruku "broj N je djeljiv s 3", a inače će
                else if (broj % 3 == 0)
                    Console.WriteLine("broj {0} je djeljiv s 3",broj);
                // 3. provjeriti je li broj djeljiv s 5. Ako je broj djeljiv, ispisat će poruku "broj N je djeljiv s 5", a inače će
                else if (broj % 5 == 0)
                    Console.WriteLine("broj {0} je djeljiv s 5",broj);
                //    ispisati da nije djeljiv niti s jednim brojem
                else
                    Console.WriteLine("Broj {0} nije djeljiv s niti jednim brojem",broj);

            }
            catch (Exception)
            {
                Console.WriteLine("Neispravan unos");
            }
            Console.ReadKey();
        }
    }
}
