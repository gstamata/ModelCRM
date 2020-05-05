using ModelCRM.Models;
using ModelCRM.Options;
using ModelCRM.Services;
using System;


namespace ModelCRM
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerOptions custOpt = new CustomerOptions
            {
                FirstName = "Mema",
                LastName = "Stamataki",
                Address = "Kallithea",
                VatNumber = "123456789",
                Email = "stamataki.mema@gmail.com",
                Phone = "6951915214",
                Dob = new DateTime(1993, 7, 6),

            };
            CustomerCrud custCrud = new CustomerCrud();
            Customer customer = custCrud.CreateCustomer(custOpt);
            Console.WriteLine( $"Id = { customer.Id}"  +  $"FirstName = { customer.FirstName}" );

            Customer toFind = custCrud.GetCustomerById(1);
            Console.WriteLine($"Id = { toFind.Id}" + $"FirstName = { toFind.FirstName}");
        }
    }
}
