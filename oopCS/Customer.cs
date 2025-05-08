using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace oopCS
{
    internal class Customer: Person
    {
        public string Address { get; set; }
        public string? Phone { get; set; }
        public string Email { get; set; }
        public PaymentMethod? Mdp { get; set; }
        public Customer(string name, string surname, DateTime dob, string address, string email) : base(name, surname, dob.Year, dob.Month, dob.Day)
        {
            Address = address;
            Email = email;
        }
        public Customer(string name, string surname, int year, int month, int day, string address, string email) : base(name, surname, year, month, day)
        {
            Address = address;
            Email = email;
        }     
        public override string ToString()
        {
            return base.ToString() + ", " + Address + ", " + Email;
        }
        public override string Welcome()
        {
            return Name + " " + Surname + ", ti trovi in " + Address;
        }
        public virtual string PrintAddress()
        {
            return Name + " " + Surname + "\n" + Address.Replace(", ", "\n");
        }

    }
    public enum PaymentMethod
    {
        Cash,
        CreditCard,
        Iban,
        Paypal
    }
}
