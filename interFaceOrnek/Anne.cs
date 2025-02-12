using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interFaceOrnek
{
    internal class Anne : IYemekYapan, ICocukBakan, ITuvaleteGiden
    {
        public void CocukBakan()
        {
            Console.WriteLine("Bn bir anneyim, çocuğuma bakarım");
        }

        public void TuvaleteGiden()
        {
            Console.WriteLine("Ben bir anne olsamda tuvalete giderim");
        }

        public void YemekYapan()
        {
            Console.WriteLine("Ben bir anneyim, yemek yaparım");
        }
    }
}
