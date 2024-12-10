public class Product
{
    private string name;
    private int productId;
    private double price;
    private int quantity;

    public double GetTotalCost()
    {
        return price * quantity;
    }
}

public class Customer
{
    private string name;
    private Address address;

    public bool IsInUSA()
    {
        return address.IsInUSA();  // Missing Address class method definition
    }
}

public class Order
{
    private List<Product> products;
    private Customer customer;

    public double GetTotalPrice()
    {
        double totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.GetTotalCost();
        }

        double shippingCost = customer.IsInUSA() ? 5 : 35;
        return totalCost + shippingCost;
    }
}

public class Program
{
    public static void Main()
    {
        Product product1 = new Product { name = "Laptop", productId = 101, price = 800, quantity = 2 };
        Product product2 = new Product { name = "Mouse", productId = 102, price = 25, quantity = 1 };
        List<Product> products = new List<Product> { product1, product2 };

        Address address = new Address("123 Main St", "Los Angeles", "CA", "USA");
        Customer customer = new Customer("micheal kyle", address);

        Order order = new Order(products, customer);

        Console.WriteLine("Total Price: $" + order.GetTotalPrice());
    }
}
