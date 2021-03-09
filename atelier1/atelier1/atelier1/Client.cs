using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier1
{
    class Client
    {
        private string nom, prenom, adresse;
        public Client(string n,string p,string a)
        {
            nom = n;
            prenom = p;
            adresse = a;
        }
        public void afficher()
        {
            Console.WriteLine("nom :"+nom);
            Console.WriteLine("prenom :"+prenom);
            Console.WriteLine("adresse :"+adresse);

        }
    }
}
