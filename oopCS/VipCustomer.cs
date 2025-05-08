using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopCS
{
    internal class VipCustomer: Customer
    {
        private string? NamePrefix { get; set; }
        private decimal NegativeThreshold { get; set; }
        public VipCustomer(string name, string surname, DateTime dob, string address, string email, decimal threshold) : base(name, surname, dob, address, email)
        {
            NamePrefix = "Me povero, me tapino";
            NegativeThreshold = threshold;
        }
        public VipCustomer(string name, string surname, int year, int month, int day, string address, string email, decimal threshold) : base(name, surname, year, month, day, address, email)
        {
            NamePrefix = "Me povero, me tapino";
            NegativeThreshold = threshold;
        }
        public override string ToString()
        {
            return NamePrefix + " " + base.ToString();
        }
        public override string Welcome()
        {
            return "Benvenuto " + NamePrefix + " " + base.Welcome();
        }
        public override string PrintAddress()
        {
            return NamePrefix + " " + base.PrintAddress();
        }
    }
}
