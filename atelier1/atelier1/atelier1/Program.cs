using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier1
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte C1 = new Compte("merzak", "yazid", "haychrifa", 45000);
            Compte C2 = new Compte("fatene", "yassine", "elquods", 50000);
            MAD mt = new MAD(5000);
            C1.consulter();
            C1.crediter(mt);
            C1.consulter();
            C1.debiter(mt);
            C1.consulter();
            C2.consulter();
            C1.verser(C2, mt);
            C1.consulter();
            C2.consulter();

            Console.ReadKey();
        }
    }
}
