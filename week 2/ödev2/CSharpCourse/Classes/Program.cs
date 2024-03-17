using System.Security.Cryptography;

namespace Classes;

class Program
{
    static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add();
        customerManager.Update();

        ProductManager productManager = new ProductManager();
        productManager.Add();
        productManager.Update();

        Customer customer = new Customer();
        customer.City = "ankara";
        customer.Id = 1;
        customer.FirstName = "engin";
        customer.LastName = "demiroğ";

        Customer customer2 = new Customer
        {
            Id = 2, City = "istanbul", FirstName = "Derin", LastName = "demiroğ"
        };

        Console.WriteLine(customer2.FirstName);

        Console.ReadLine();
    }
}
