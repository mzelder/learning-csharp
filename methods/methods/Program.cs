using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var firstPoint = new Point(5, 10);
            var secondPoint = new Point(10, 20);

            Console.WriteLine($"{firstPoint.X}, {firstPoint.Y}");

            firstPoint.Move(50, 100);
            Console.WriteLine($"{firstPoint.X}, {firstPoint.Y}");

            firstPoint.Move(secondPoint);
            Console.WriteLine($"{firstPoint.X}, {firstPoint.Y}");
        }
    }
}
