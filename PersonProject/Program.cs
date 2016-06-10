using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person newPerson = new Person(25, "Zaheen");
            Student Meer = new Student(26, "Meer", "A123456");
            Console.WriteLine(Meer.ToString());
        }
    }
}
