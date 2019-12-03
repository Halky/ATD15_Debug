using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Text;

namespace ATD15_Demo.Models
{
    //[DebuggerDisplay("{FullName}", Name = "{OIB}")]
    //[DebuggerTypeProxy(typeof(PersonDebuggerView))]
    class Person
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string Name { get; set; }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string LastName { get; set; }

        public string FullName
        {
            get { return $"{Name} {LastName}"; }
        }

        public string OIB { get; set; }
        public int Years { get; set; }

        public static string SayHi(string name)
        {
            return String.IsNullOrWhiteSpace(name) ? 
                "Hi stranger!" :
                $"Hi {name}!";
        }

        public override string ToString()
        {
            return $"{OIB} - {LastName}";
        }

        internal class PersonDebuggerView
        {
            private Person person;

            public PersonDebuggerView(Person person)
            {
                this.person = person;
            }

            public string FullNameWithYears
            {
                get { return $"{person.FullName}, {person.Years}"; }
            }

            public bool HasFullNameCroDiacriticSign
            {
                get
                {
                    return person.FullName.Contains('ć') ||
                           person.FullName.Contains('č') ||
                           person.FullName.Contains('š') ||
                           person.FullName.Contains('ž');
                }
            }
        }
    }
}