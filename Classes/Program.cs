using System;

namespace Classes
{
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
            customer.Id = 33;
            customer.FirstName = "Türkan";
            customer.LastName = "Rişvan";
            customer.City = "Mersin";

            Customer customer1 = new Customer() { Id = 22, FirstName = "Gökhan", LastName = "Rişvan", City = "Antalya" };

            Console.WriteLine(customer1.FirstName);

        }
    }
}

