﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT
{
    class KoristajaNimi : MyProfession
    {
        public KoristajaNimi()
        {
            Name = "koristaja";
            sinuAmet();
            Console.WriteLine("Millisesse ruumi soovid siseneda\n1 - Arendajate ruumi.\n2 - Ülemuste ruumi.\n3 - Kööki.\n4 - Andmetöötlejate ruumi.");
            int ruum = Int32.Parse(Console.ReadLine());
            var Koristaja = new Koristaja();
            

            if (ruum == 1)
            {

                if (ArendajateRuum == true)
                {
                    Console.WriteLine("Sissepääs olemas.");
                }
                else if (ArendajateRuum == false)
                {
                    Console.WriteLine("Sissepääsu ei ole.");
                }

            }
            if (ruum == 2)
            {
                if (ÜlemusteRuum == true)
                {
                    Console.WriteLine("Sissepääs olemas.");
                }
                else if (ÜlemusteRuum == false)
                {
                    Console.WriteLine("Sissepääsu ei ole.");
                }
            }
            if (ruum == 3)
            {
                if (Köök == true)
                {
                    Console.WriteLine("Sissepääs olemas.");
                }
                else if (Köök == false)
                {
                    Console.WriteLine("Sissepääsu ei ole.");
                }
            }
            if (ruum == 4)
            {
                if (AndmetetöötlejateRuum == true)
                {
                    Console.WriteLine("Sissepääs olemas.");
                }
                else if (AndmetetöötlejateRuum == false)
                {
                    Console.WriteLine("Sissepääsu ei ole.");
                }
            }
        }
    }
}
