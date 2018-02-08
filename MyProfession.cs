using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT
{
    class MyProfession
    {
        public string Name;
        public bool ArendajateRuum;
        public bool ÜlemusteRuum;
        public bool Köök;
        public bool AndmetetöötlejateRuum;


        public void arendajateruum()
        {
            if (ArendajateRuum == true)
            {
                Console.WriteLine("Sissepääs arendajateruumi olemas");
            }
            else if(ArendajateRuum == false)
            {
                Console.WriteLine("Sissepääsu arendajateruumi pole");
            }

        }
        public void ülemusteruum()
        {
            if(ÜlemusteRuum == true)
            {
                Console.WriteLine("Sissepääs ülemusteruumi olemas");
            }
            else if(ÜlemusteRuum == false)
            {
                Console.WriteLine("Sissepääsu pole");
            }


        }
        public void köök()
        {
            if(Köök == true)
            {
                Console.WriteLine("Sissepääs kööki olemas");
            }
            else if(Köök == false)
            {
                Console.WriteLine("Sissepääsu pole");
            }

        }
        public void andmetöötlejateruum()
        {
            if(AndmetetöötlejateRuum == true)
            {
                Console.WriteLine("Sissepääs andmetöötlejate ruumi olemas");
            }
            else if(AndmetetöötlejateRuum == false)
            {
                Console.WriteLine("Sissepääsu pole");
            }

        }
    }
}
