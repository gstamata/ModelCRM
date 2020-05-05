using ModelCRM.CrmDbContext;
using ModelCRM.Models;
using ModelCRM.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelCRM.Services
{
    public class CustomerCrud
    {
        public Customer CreateCustomer(CustomerOptions customerOptions)
        {
            Customer customer = new Customer {
                Address = customerOptions.Address,
                CreateDate = DateTime.Now,
                Dob = customerOptions.Dob,
                Email = customerOptions.Email,
                FirstName = customerOptions.FirstName,
                IsActive = true,
                LastName = customerOptions.LastName,
                Phone = customerOptions.Phone,
                TotalGross =0M,
                VatNumber = customerOptions.VatNumber,
                 
            };
            using CrmAppDbContext dbContext = new CrmAppDbContext();
            dbContext.Customers.Add(customer);
            dbContext.SaveChanges();


            return customer;
        }
        public Customer GetCustomerById(int id)
        {
            using CrmAppDbContext dbContext = new CrmAppDbContext();
            Customer customer = dbContext.Customers.Find(id);

            return customer;
        }
    }
}
