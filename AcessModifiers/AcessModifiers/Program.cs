using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessModifiers
{
    internal class Program
    {
        public class Person
        {
            private DateTime _birthdate;

            public void Set(DateTime birthdate)
            {
                _birthdate = birthdate;
            }

            public DateTime Get()
            {
                return _birthdate;
            }
        }
        
        static void Main(string[] args)
        {
            var person = new Person();
            person.Set(new DateTime(1920, 1, 1));
            Console.WriteLine(person.Get());
        }
    }
}
