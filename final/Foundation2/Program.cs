using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        Address address1 = new Address("123 Main St.", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Elm St.", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Doe", address2);

        Product product1 = new Product("Cheese", "P1", 10, 2);
        Product product2 = new Product("Chocolate", "P2", 20, 3);
        Product product3 = new Product("Beef", "P3", 35, 1);
        Product product4 = new Product("Chicken", "P4", 40, 2);
        Product product5 = new Product("Pork", "P5", 50, 1);
        Product product6 = new Product("Rice", "P6", 60, 3);

        List<Product> products1 = new List<Product> { product1, product2, product3 };
        List<Product> products2 = new List<Product> { product4, product5, product6 };

        Order order1 = new Order(products1, customer1);
        Order order2 = new Order(products2, customer2);

        Console.WriteLine("Order 1 name: " + customer1.Name);
        Console.WriteLine("Order 1 total price: " + order1.GetTotalPrice());
        Console.WriteLine("Order 1 packing label: " + order1.GetPackingLabel());
        Console.WriteLine("Order 1 shipping label: " + customer1.Name + " " + order1.GetShippingLabel());
        Console.WriteLine("");
        
        Console.WriteLine("Order 2 name: " + customer2.Name);
        Console.WriteLine("Order 2 total price: " + order2.GetTotalPrice());
        Console.WriteLine("Order 2 packing label: " + order2.GetPackingLabel());
        Console.WriteLine("Order 2 shipping label: " + customer2.Name + " " + order2.GetShippingLabel());
    }
}