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
            Console.WriteLine("Helloo!\nPlease choose your profession.\n1 - Nooremarendaja\n2 - Vanemarendaja\n3 - Koristaja\n4 - Spetsiaalkoristaja\n5 - Ülemus\n6 - Andmetöötleja\n0 - I do not work in this company.");
            int profession = Int32.Parse(Console.ReadLine());

            if (profession == 1)
            {
                Console.WriteLine("Welcome work!\nWhere do you want to go?\n1 - Arendajate ruum\n2 - Ülemuste ruum\n3 - Köök\n4 - Andmetöötlejate ruum");

            }
            if (profession == 2)
            {
                Console.WriteLine("Welcome work!\nWhere do you want to go?\n1 - Arendajate ruum\n2 - Ülemuste ruum\n3 - Köök\n4 - Andmetöötlejate ruum");
            }
            if (profession == 3)
            {
                Console.WriteLine("Welcome work!\nWhere do you want to go?\n1 - Arendajate ruum\n2 - Ülemuste ruum\n3 - Köök\n4 - Andmetöötlejate ruum");
            }
            if (profession == 4)
            {
                Console.WriteLine("Welcome work!\nWhere do you want to go?\n1 - Arendajate ruum\n2 - Ülemuste ruum\n3 - Köök\n4 - Andmetöötlejate ruum");
            }
            if (profession == 5)
            {
                Console.WriteLine("Welcome work!\nWhere do you want to go?\n1 - Arendajate ruum\n2 - Ülemuste ruum\n3 - Köök\n4 - Andmetöötlejate ruum");
            }
            if (profession == 6)
            {
                Console.WriteLine("Welcome work!\nWhere do you want to go?\n1 - Arendajate ruum\n2 - Ülemuste ruum\n3 - Köök\n4 - Andmetöötlejate ruum");
            }
            else if(profession == 0)
            {
                Console.WriteLine("You can't go in if you do not work here!");
            }
            Console.ReadKey();
        }
    }
}
