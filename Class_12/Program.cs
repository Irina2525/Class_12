using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ВВедите радиус окружности r=");
            double r = Convert.ToDouble(Console.ReadLine());
            double lenght = Circle.Getlenght(r);
            double square = Circle.GetSquare(r);
            Console.WriteLine($"Длина окружности={lenght:0.000} \nПлощадь круга={square:0.000}");

            Console.WriteLine();
            Console.WriteLine("ВВедите координаты центра окружности x0, y0:");
            Console.Write("ВВедите координату x0=");
            double x0= Convert.ToDouble(Console.ReadLine());
            Console.Write("ВВедите координату y0=");
            double y0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("ВВедите координаты точки x, y:");
            Console.Write("ВВедите координату x=");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("ВВедите координату y=");
            double y = Convert.ToDouble(Console.ReadLine());
            string GetAffiliation = Circle.GetAffiliation(x, y, x0, y0,r);
            Console.WriteLine($"\nПринадлежность точки к кругу - {GetAffiliation}");

            Console.ReadKey();
        }
    }
}
