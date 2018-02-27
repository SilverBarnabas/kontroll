using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Helloo!\nPlease choose your profession.\n1 - Nooremarendaja" +
                "\n2 - Vanemarendaja\n3 - Koristaja\n4 - Spetsiaalkoristaja\n5 - Ülemus" +
                "\n6 - Andmetöötleja\n0 - I do not work in this company.");
            int profession = Int32.Parse(Console.ReadLine());

            if (profession == 1)
            {
                var Nooremarendaja = new NooremarendajaNimi();

            }
            if (profession == 2)
            {
                var vanemarendaja = new VanemarendajaNimi();
            }
            if (profession == 3)
            {
                var koristaja = new KoristajaNimi();
            }
            if (profession == 4)
            {
                var spetsiaalkoristaja = new SpetsiaalkoristajaNimi();
            }
            if (profession == 5)
            {
                var ülemus = new ÜlemusNimi();
            }
            if (profession == 6)
            {
                var andmetöötleja = new AndmetöötlejaNimi();
            }
            else if(profession == 0)
            {
                Console.WriteLine("You can't go in if you do not work here!");
            }
            
            
            Console.ReadLine();
        }
        














    }
}
