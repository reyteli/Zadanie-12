using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_12
{
    static class Cycle
    {
        static public double GetSquare(double r)
        {
            return r * r * Math.PI;
        }


        static public double GetDlina(double r)
        {
            return 2 * (r * Math.PI);
        }
        static public double GetProverka(double r,double x, double y)
        {
            return Math.Sqrt(Math.Pow(0 - x, 2) + Math.Pow(0 - y, 2));

        }
    }
}
    






