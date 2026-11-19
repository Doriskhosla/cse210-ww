using System;

class Program
{
    static void Main(string[] args)
    {
        //USA Customer
        Address address1 = new Address(
            "313 Main Street",
            "Los Angeles",
            "California",
            "USA");

        Customer customer1 = new Customer(
         "Ronda Carpenter",
         address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Headphones", "P100", 900, 1));

        order1.AddProduct(new Product("Camera", "P200", 20, 2));



        //International Customer

        Address address2 = new Address(
           "Calle Emilio Carranza #23",
           "Guadalajara",
           "Jalisco",
           "Mexico");

        Customer customer2 = new Customer(
           "Josefa Aguilar",
           address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(
        new Product("Computer Microphone", "P300", 70, 1));

        order2.AddProduct(
        new Product("Computer speakers", "P400", 250, 1));


        Console.WriteLine("ORDER 1");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total: ${order1.GetTotalCost()}");

        Console.WriteLine();

        Console.WriteLine("ORDER 2");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total: ${order2.GetTotalCost()}");







    }
}