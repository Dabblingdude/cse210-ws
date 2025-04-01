using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();


        Address address0 = new Address("12345 Main St", "New York City", "NY", "USA");
        Customer customer0 = new Customer("Sir Elton Josh", address0);
        Order order0 = new Order(customer0);

        order0.AddProduct(new Product("Yamaha Keyboard", "A832946", 1199.99m, 3));
        order0.AddProduct(new Product("Sony Headphones", "T356279", 499.99m, 2));
        orders.Add(order0);


    
        Address address1 = new Address("67890 2nd St", "Metro Manila", "Manila", "PH");
        Customer customer1 = new Customer("Jose Magellan", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Hait Nga Sundang", "10391", 30, 10));
        order1.AddProduct(new Product("Init Nga Habol", "10258", 10, 5));
        orders.Add(order1);

        foreach (var order in orders)
        {
            order.DisplayOrderSummary();
        }
    }
}