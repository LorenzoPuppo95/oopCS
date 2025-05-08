using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace oopCS
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Branch { get; set; }
        public decimal Ral { get; set; }
        public string Level { get; set; }

        public Employee(string id, string name, string surname, string gender, DateTime dob, string? branch, string? ral, string? level)
        {
            Id = int.Parse(id);
            Name = name;
            Surname = surname;
            Dob = dob;
            Gender = gender;
            Branch = branch ?? string.Empty;
            Ral = string.IsNullOrEmpty(ral) ? 0 : decimal.Parse(ral);
            Level = level ?? string.Empty;
        }
    }
}
