using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7._2
{
    class Program
    {   //Найти объем и площадь куба
        static void Main(string[] args)
        {
            Console.Write("Введите длину стороны куба: ");
            byte a = Convert.ToByte(Console.ReadLine());
            double V, S;
            VolumeSquare(a, out V, out S);
            Console.WriteLine("Объем куба равен {0:f2}\nПлощадь поверхности куба равна {1:f2}", V, S);
            Console.ReadKey();        
        }
        static void VolumeSquare (byte a, out double V, out double S)
        {
            V = Math.Pow(a, 3);
            S = 6 * Math.Pow(a, 2);
        }
    }
}
