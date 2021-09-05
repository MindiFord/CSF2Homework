using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace TesterProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();

            s1.FirstName = "Johnny";
            s1.LastName = "Castle";
            s1.Id = "1963";
            s1.Gpa = 2.9f;

            Console.WriteLine(s1);

            Student s2 = new Student("Vida", "Boheme", "1995", 3.8f);

            Console.WriteLine(s2);

            Console.WriteLine("\n\n\n");

            Vehicle v1 = new Vehicle();

            v1.Make = "Triumph";
            v1.Model = "Mayflower";
            v1.Year = 1949;
            v1.Weight = 2050f;

            Console.WriteLine(v1);

            Vehicle v2 = new Vehicle("Mercury", "Bobcat", 1974, 2300);

            Console.WriteLine(v2);

        }
    }
}
