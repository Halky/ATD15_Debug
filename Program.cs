using System;
using System.Diagnostics;
using ATD15_Demo.Data;

namespace ATD15_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            var repo = new PeopleRepo();
            var people = repo.GetAll();

            foreach (var person in people)
            {
                Console.WriteLine(person);
                //WriteInforMessageToDisplay(person.FullName);
                //Debug.WriteLine($"Outputing - {person.FullName}");
            }

            Console.WriteLine("Done");
            Console.ReadKey();
        }
        [Conditional("DEBUG")]
        private static void WriteInforMessageToDisplay(string fullName)
        {
            Console.WriteLine($"DEBUG - string length {fullName.Length}");
        }
    }
}
