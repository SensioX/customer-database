using System;
using System.Collections.Generic;

namespace CustomerDatabase
{
    // Define the Customer class
    class Customer
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public Customer(string name, string phoneNumber, string address)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Phone: {PhoneNumber}, Address: {Address}";
        }
    }

    class Program
    {
        // List to store customer data
        static List<Customer> customers = new List<Customer>();

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nCustomer Database");
                Console.WriteLine("1. Add New Customer");
                Console.WriteLine("2. View Customer by Name");
                Console.WriteLine("3. View All Customers");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option (1-4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddCustomer();
                        break;
                    case "2":
                        ViewCustomerByName();
                        break;
                    case "3":
                        ViewAllCustomers();
                        break;
                    case "4":
                        running = false;
                        Console.WriteLine("Exiting the program...");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }

        // Method to add a new customer
        static void AddCustomer()
        {
            Console.Write("\nEnter customer's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter customer's phone number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter customer's address: ");
            string address = Console.ReadLine();

            // Add customer to the list
            customers.Add(new Customer(name, phoneNumber, address));
            Console.WriteLine("\nCustomer added successfully!");
        }

        // Method to view a customer's information by name
        static void ViewCustomerByName()
        {
            Console.Write("\nEnter the name of the customer to search: ");
            string name = Console.ReadLine();
            bool found = false;

            foreach (Customer customer in customers)
            {
                if (customer.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nCustomer Information:");
                    Console.WriteLine(customer);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Customer not found.");
            }
        }

        // Method to view all customers
        static void ViewAllCustomers()
        {
            if (customers.Count == 0)
            {
                Console.WriteLine("\nNo customers found.");
            }
            else
            {
                Console.WriteLine("\nAll Customers:");
                foreach (Customer customer in customers)
                {
                    Console.WriteLine(customer);
                }
            }
        }
    }
}