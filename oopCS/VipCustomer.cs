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
            NegativeThreshold = threshold;
        }
        public VipCustomer(string name, string surname, int year, int month, int day, string address, string email, decimal threshold) : base(name, surname, year, month, day, address, email)
        {
            NegativeThreshold = threshold;
        }
    }
}
