namespace oopCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dob1 = new DateTime(1990, 1, 1);
            var c1 = new Customer("Pippo", "de Pippis", dob1, "via de' cazzi in culo 3, 16123 Genova, Italy", "pippopippis@topomail.it");            
            var c2 = new Customer("Clarabella", "de Pippis", 1990, 1, 2, "via de' cazzi in culo 4, 16123 Genova, Italy", "clarabella@topomail.it");
            var c3 = new Customer("Orazio", "de Pippis", new DateTime(1990, 1, 3), "via de' cazzi in culo 5, 16123 Genova, Italy", "orazio@topomail.it");
            var v1 = new VipCustomer("Paperon", "de Paperoni", 1920, 2, 7, "via de' cazzi in culo ma con la piscina di monete", "paperon@paperoni.it", 100000000000000);

            var e1 = new Employee("Paperino", "de Paperis", 1930, 3, 18, "genova1");

            //var p1 = new Person("Pippo", "de Pippis", 1990, 1, 1);
            // This line does not work because 'Person' is an abstract class and cannot be instantiated directly.
            // To use this, you need to create an instance of a concrete subclass of 'Person', such as 'Customer' or 'Employee'.

            List<VipCustomer> vipCustomers = [];
            vipCustomers.Add(v1);

            List<Customer> customers = [];
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);
            customers.Add(v1);

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.ToString());
                Console.WriteLine(customer.PrintAddress());
            }

            List<Person> people = [];
            people.Add(c1);
            people.Add(c2);
            people.Add(c3);
            people.Add(v1);
            people.Add(e1);
            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
                Console.WriteLine(person.Welcome());
            }
            c1.Mdp = PaymentMethod.Paypal;
            e1.Level = ExperienceLevels.Middle;
        }
    }
}
