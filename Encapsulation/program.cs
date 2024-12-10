// Missing encapsulation, member variables are public
public class Product
{
    public string name;
    public int productId;
    public double price;
    public int quantity;
}

public class Customer
{
    public string name;
    public string address;  // Directly using a string instead of Address class
}

public class Order
{
    public List<Product> products;
    public Customer customer;

    public double GetTotalPrice()
    {
        double totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.price * product.quantity;
        }

        return totalCost + 5;  // Assume shipping cost is always $5
    }
}

public class Program
{
    public static void Main()
    {
        Product product1 = new Product { name = "Laptop", productId = 101, price = 800, quantity = 2 };
        Product product2 = new Product { name = "Mouse", productId = 102, price = 25, quantity = 1 };
        List<Product> products = new List<Product> { product1, product2 };

        Customer customer = new Customer { name = "Micheal kyle", address = "123 Main St" };

        Order order = new Order { products = products, customer = customer };

        Console.WriteLine("Total Price: $" + order.GetTotalPrice());
    }
}
