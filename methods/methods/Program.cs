using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach(var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }

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

            var calculator = new Calculator();
            var total = calculator.Add(1, 2, 3, 4, 5);
            Console.WriteLine(total);
        }
    }
}
