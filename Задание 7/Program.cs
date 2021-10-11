using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7
{
    class Program
    {   //Сравнить площади треугольников
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон первого тругольника:");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длины сторон второго тругольника:");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            int c2 = Convert.ToInt32(Console.ReadLine());

            if (SquareExists(a1,b1,c1)&&SquareExists(a2,b2,c2))
            {
                if (SquareTriangle(a1, b1, c1) == SquareTriangle(a2, b2, c2))
                {
                    Console.WriteLine("Площади треугольников равны");
                }
                else
                {
                    Console.WriteLine((SquareTriangle(a1, b1, c1) > SquareTriangle(a2, b2, c2)) ? "Площадь первого треугольника больше" : "Площадь второго треугольника больше");
                }
            }
            else
            {
                Console.WriteLine((SquareExists(a1, b1, c1) ? "Второй треугольник не существует" : "Первый треугольник не существует"));
            }            
            Console.ReadKey();
        }
        static double SquareTriangle(int a, int b, int c)
        {
            double p = (a + b + c) / 2;
            double square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return square;
        }
        static bool SquareExists(int a, int b, int c)
        {
            bool exists = (a + b > c && a + c > b && c + b > a);
            return exists;
        }

    }
}
