using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using ATD15_Demo.Models;

namespace ATD15_Demo.Data
{
    //[DebuggerDisplay("Populated - {Count > 0}")]
    class PeopleRepo
    {
        public PeopleRepo()
        {
            Seed();
        }
        public PeopleRepo(bool populate)
        {
            if (populate)
                Seed();
        }

        private List<Person> people = new List<Person>();
        public int Count
        {
            get { return people.Count; }
        }

        private void Seed()
        {
            people = new List<Person>();
            people.Add(new Person
            {
                Name = "Petar",
                LastName = "Halusek",
                Years = 31,
                OIB = "11161084054",
            });
            people.Add(new Person
            {
                Name = "Ivan",
                LastName = "Ivanović",
                Years = 31,
                OIB = "21361784044",
            });
            people.Add(new Person
            {
                Name = "Petar",
                LastName = "Petrić",
                Years = 25,
                OIB = "81211085053",
            });
            people.Add(new Person
            {
                Name = "Marko",
                LastName = "Markić",
                Years = 43,
                OIB = "50961084432",
            });
            people.Add(new Person
            {
                Name = "Joško",
                LastName = "Joškić",
                Years = 21,
                OIB = "10261084526",
            });
            people.Add(new Person
            {
                Name = "Lovro",
                LastName = "Lovrić",
                Years = 37,
                OIB = "12741089514",
            });
        }

        public ICollection<Person> GetAll()
        {
            return people;
        }
    }
}
