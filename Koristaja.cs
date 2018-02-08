using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT
{
    class Koristaja: MyProfession
    {
        public Koristaja()
        {
            Name = "Koristaja";
            ArendajateRuum = true;
            ÜlemusteRuum = false;
            Köök = true;
            AndmetetöötlejateRuum = true;
        }
    }
}
