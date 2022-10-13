using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void GetCubeAreaAndVolume(double a, out double S, out double V)
        {
            S = a * a * 6;
            V = a * a * a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину стороны куба");
            double a = Convert.ToDouble(Console.ReadLine());
            double cubeS, cubeV;
            GetCubeAreaAndVolume(a, out cubeS, out cubeV);
            
            Console.WriteLine("Площадь куба - {0:.00}, Объем куба - {1:.00}", cubeS, cubeV);
            Console.ReadKey();
        }
    }
}
