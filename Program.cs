using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GetSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            Customer cust = new Customer();
                        Console.WriteLine($"{cust.Id},{cust.Name},{cust.MEndDate}");
                        cust.Id = 34;
                        cust.Name = "Praveen";
                        Console.WriteLine();
                        Console.WriteLine($"{cust.Id},{cust.Name},{cust.MEndDate}");*/
            //Customer cust = new Customer(12, "Raj", new DateTime(day: 09, month: 02, year: 2024));
            //Console.WriteLine("Customer Details as follows");
            //Console.WriteLine($"Customer ID : {cust.Id}\nCustomer Name : {cust.Name}\nMembershipEndDate : {cust.MEndDate}");
            /*Customer cust = new Customer(12, "Raj", new DateTime(day: 09, month: 02, year: 2024));
            Console.WriteLine("Customer Details as Follows");
            Console.WriteLine($"Customer ID : {cust.Id}\nCustomer Name : {cust.Name}\nMembershipEndDate : {cust.MEndDate}");
            cust.Comment = "I am Delighted with the services provided by the vendor";
            cust.ReadComment("admin@123");*/

            //Customer cust = new Customer();
            //Console.WriteLine("Enter Id");
            //cust.Id = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Name");
            //cust.Name = Console.ReadLine();
            //Console.WriteLine("Customer Details");
            //Console.WriteLine("ID : "+cust.Id+"\nName : "+cust.Name);
            /*
                        Customer cust = new Customer();
                        Customer cust2 = new Customer();
                        Console.WriteLine("Enter Tax");
                        Customer.Tax = double.Parse(Console.ReadLine());
                        Console.WriteLine("***Customer One***");
                        Console.WriteLine("Enter Id");
                        cust.Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Name");
                        cust.Name=Console.ReadLine();
                        Console.WriteLine("Customer Details");
                        Console.WriteLine(("ID : "+cust.Id+"\nName : "+cust.Name));

                        Console.WriteLine("***Customer Two***");
                        Console.WriteLine("Enter Id");
                        cust2.Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Name");
                        cust2.Name = Console.ReadLine();
                        Console.WriteLine("Customer Details");
                        Console.WriteLine(("ID : " + cust2.Id + "\nName : " + cust2.Name));*/

            Customer cust = new Customer();
            Console.WriteLine("Enter Id");
            cust.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            cust.Name = Console.ReadLine();
            Console.WriteLine("Enter Customer City");
            cust.City = Console.ReadLine();
            Console.WriteLine("Enter Customer Over Draft Limit");
            cust.ODLimit = double.Parse(Console.ReadLine());
            Console.WriteLine("Customer Detailds as follows");
            Console.WriteLine($"Id : {cust.Id} Name : {cust.Name}");
            Console.WriteLine($" City: { cust.City} ODLimit : {cust.ODLimit}");
        }
    }
}
