using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace oopCS
{
    internal abstract class Person
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Gender { get; set; }
        public DateTime Dob { get; set; }
        protected Person(string name, string surname, int year, int month, int day)
        {
            Name = name;
            Surname = surname;
            Dob = new DateTime(year, month, day);
        }
        public override string ToString()
        {
            return Name + " " + Surname + ", " + Dob.ToString("dd/MM/yyyy");
        }
        public abstract string Welcome();
    }
}
