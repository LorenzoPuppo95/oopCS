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
            var c4 = new VipCustomer("Paperon", "de Paperoni", 1920, 2, 7, "via de' cazzi in culo 1000", "paperon@paperoni.it");
        }
    }
}
