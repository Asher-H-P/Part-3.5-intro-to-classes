using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3._5_intro_to_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Name student;
            Name actor = new Name("Sir", "Patrick", "Stewart");
            Console.WriteLine(actor.FirstName);
            Console.WriteLine(actor.LastName);
            Console.WriteLine(actor);
            Console.WriteLine(actor.Initials);
            actor.FirstName = "John";
            Console.WriteLine(actor);
            Console.WriteLine(actor.Initials);
            student = new Name("Jane", "Doe");
            Console.WriteLine($"{student}, your username is: {student.UserName}");

        }
    }
}
