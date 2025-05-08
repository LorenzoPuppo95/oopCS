using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace oopCS
{
    internal class Employee : Person
    {
        public string Branch { get; set; }
        public decimal? Ral { get; set; }
        public ExperienceLevels? Level { get; set; }
        public Employee(string name, string surname, int year, int month, int day, string? branch) : base(name, surname, year, month, day)
        {
            Branch = branch ?? string.Empty;
        }
        public override string ToString()
        {
            return "Impiegato" + " " + base.ToString() + ", " + Branch;
        }
        public override string Welcome()
        {
            return "Benvenuto " + Name + " " + Surname + ", sei un impiegato dimmerda, coglione.";
        }
    }
    public enum ExperienceLevels
    {   
        Apprentice,
        Junior,
        Middle,
        Senior,
        Manager,
        Director
    }
}
