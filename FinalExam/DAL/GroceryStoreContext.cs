using FinalExam.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity; //add this to fix the DbContext squiggly
using System.Linq;
using System.Web;

//add two useing statements to fix errors
//add 
namespace FinalExam.DAL
{
    public class GroceryStoreContext : DbContext // add this line
    {
        public GroceryStoreContext() : base("GroceryStoreContext")//add the connection
        {

        }
        //add the tables, make the name of the table plural to differentiate
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order_Detail> Order_Details { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

    }
}