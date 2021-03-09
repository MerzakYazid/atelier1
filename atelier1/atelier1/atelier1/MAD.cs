using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier1
{
    class MAD
    {
        private double val;
        public MAD(double v)
        {
            val = v;
        }
        public void afficher()
        {
            Console.WriteLine(val+"MAD");
        }
        public static MAD operator+(MAD mt1,MAD mt2)
        {
            mt1.val = mt1.val + mt2.val;
            return mt1;
        }
        public static MAD operator-(MAD mt1, MAD mt2)
        {
            mt1.val = mt1.val - mt2.val;
            return mt1;
        }
        public static bool operator<(MAD mt1,MAD mt2)
        {
            if (mt1.val <= mt2.val)
                return true;
            else
                return false;
        }
        public bool infe(double mt)
        {
            if (mt > val)
                return true;
            else
                return false;
        }
        public static bool operator>(MAD mt1, MAD mt2)
        {
            if (mt1.val > mt2.val)
                return true;
            else
                return false;
        }
        public static bool operator>(MAD mt1, double mt2)
        {
            if (mt1.val > mt2)
                return true;
            else
                return false;
        }
        public static bool operator <(MAD mt1, double mt2)
        {
            if (mt1.val < mt2)
                return true;
            else
                return false;
        }
    }
}
