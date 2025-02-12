using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interFaceOrnek
{
    internal class Cocuk : IDersCalisan, IOyunOynayan, ITuvaleteGiden
    {
        public void DersCalisan()
        {
            Console.WriteLine("Ben bir çocuğum ders çalışırım :)");
        }

        public void OyunOynayan()
        {
            Console.WriteLine("Ben bir çocuğum oyun oynarım :)");
        }

        public void TuvaleteGiden()
        {
            Console.WriteLine("Herkes gibi tuvalete giderim :)");
        }
    }
}
