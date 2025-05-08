using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopCS
{
    internal class Customer
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Dob { get; set; }
        public string? Gender { get; set; }
        public string Address { get; set; }
        public string? Phone { get; set; }
        public string Email { get; set; }
        public string? Mdp { get; set; }

        public Customer(string name, string surname, DateTime dob, string address, string email)
        {
            Name = name;
            Surname = surname;
            Dob = dob; 
            Address = address;
            Email = email;
        }
        public Customer(string name, string surname, int year, int month, int day, string address, string email)
        {
            Name = name;
            Surname = surname;
            Dob = new DateTime(year, month, day);
            Address = address;
            Email = email;
        }
        public Customer()
        {
        }
        
        public override string ToString()
        {
            return Name + " " + Surname + " " + Dob.ToString("dd/MM/yyyy") + " " + Address + " " + Email;
        }
    }
}
