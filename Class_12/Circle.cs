using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_12
{
    static class Circle // если класс полностью статический, все методы у него статические, 
                        // то не нужно делать у него статических полей
    {
        static public double Getlenght(double r)
        {
            return 2 * Math.PI * r;
        }
        static public double GetSquare(double r)
        {
            return Math.PI*r * r;
        }
        static public string GetAffiliation(double x, double y, double x0, double y0, double r)
        {
            if (Math.Sqrt((x - x0) * (x - x0) + (y - y0) - (y - y0)) <= r)
            {
                return ("точка принадлежит кругу");

            }
            else
            {
                return ("точка не принадлежит кругу");
            }
        }
    }
}


