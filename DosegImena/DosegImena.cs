using System;

namespace Vsite.CSharp
{
    class DosegImena
    {
        static void Main(string[] args)
        {
            DosegImena p = new DosegImena();
            p.IspišiAove();

            Console.ReadKey();
        }

        void IspišiAove()
        {
            string a = "Lokalna varijabla";

            // TODO: Ispisati vrijednosti lokalne varijable a
            Console.WriteLine(a);

            // TODO: Ispisati vrijednost člana klase a
            Console.WriteLine(this.a);

            {
               //  TODO: Definirati novu varijablu a unutar ovog bloka i ispisati njenu vrijednost
                //string a = "varijabla unutar bloka";

            }
        }

        string a = "Član klase";
    }
}
