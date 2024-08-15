using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace project_with_moshi_part1
{
    partial class Program
    {
        
        public static void Main(string[] args)
        {
            var customer = new Customer(25, "Maciek");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
