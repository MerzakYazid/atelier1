using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier1
{
    class Compte
    {
        private readonly int numcompte;
        private readonly Client C;
        private static int cpt;
        private MAD solde;
        private static MAD plafond;
        static Compte()
        {
            cpt = 1;
            plafond = new MAD(50000);

        }
        public Compte(string n, string p, string a, double s)
        {
            numcompte = cpt++;
            C = new Client(n, p, a);
            solde = new MAD(s);
        }
         public bool crediter(MAD mt)
        {
            if (mt>0)
            {
                solde = solde + mt;
                Console.WriteLine("operation de credit effectue");
                return true;
            }
            else
            {
                Console.WriteLine("Montant invalide");
                return false;
            }
        }
        public bool debiter(MAD mt)
        {
            if (plafond>mt)
            {
                solde = solde - mt;
                Console.WriteLine("operation de debit effectue");
                return true;
            }
            else
            {
                Console.WriteLine("Montant invalide");
                return false;
            }
        }
        public bool verser(Compte C,MAD somme)
        {
            if (this.debiter(somme))
            {
                if (C.crediter(somme))
                {
                    Console.WriteLine("operation de versement reussie");
                    return true;
                }
                else
                {
                    Console.WriteLine("operation invalide");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("operation invalide");
                return false;
            }

        }
        public void consulter()
        {
            Console.WriteLine("numero de compte :"+numcompte);
            C.afficher();
            Console.WriteLine("solde:");
            solde.afficher();
        }
    }
}
