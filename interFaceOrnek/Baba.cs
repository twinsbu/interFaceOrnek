
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interFaceOrnek
{
    internal class Baba : IArabaSuren, ICalisabilir, ITuvaleteGiden
    {
        public void ArabaSuren()
        {
            Console.WriteLine("Ben bir babayım, araba sürerim");
        }

        public void Calisabilir()
        {
            Console.WriteLine("Ben bir babayım eve ekmek parası getirim");
        }

        public void TuvaleteGiden()
        {
            Console.WriteLine("Ben bir baba olsamda tuvalete giderim");
        }
    }
}
