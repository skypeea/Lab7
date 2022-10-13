using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Program
    {
        static double GetTriangleArea(double a, double b, double c)
        {
            double p = a + b + c;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны первого треугольника");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стороны второго треугольника");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());
            if (GetTriangleArea(a1, b1, c1) > GetTriangleArea(a2, b2, c2))
            {
                Console.WriteLine("Площадь первого треугольника больше");
            }
            else
                if (GetTriangleArea(a1, b1, c1) < GetTriangleArea(a2, b2, c2))
                {
                    Console.WriteLine("Площадь второго треугольника больше");
                }
            
            else { Console.WriteLine("Площади треугольников равны"); }
            Console.WriteLine("{0:.00}", GetTriangleArea(a1, b1, c1));
            Console.WriteLine("{0:.00}", GetTriangleArea(a2, b2, c2));
            Console.ReadKey();
        }
    }
}
