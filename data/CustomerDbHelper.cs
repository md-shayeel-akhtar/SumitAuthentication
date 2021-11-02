using CustomerMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace customer.data
{
    public class CustomerDbHelper
    {
        public static List<Customer> customers = new List<Customer>()
        {
            new Customer(){CustomerId = 991, FirstName = "Cyril", LastName = "Joseph", Address = "Chennai", DateOfBirth = new DateTime(2000,02,02), PanNumber = "ABCD10002Z"},
            new Customer(){CustomerId = 992, FirstName = "Waseem", LastName = "Akram", Address = "Chennai", DateOfBirth = new DateTime(2000,02,02), PanNumber = "ABCD10001Z"},
            new Customer(){CustomerId = 101, FirstName = "Abhishek", LastName = "Choudhary", Address = "Bihar", DateOfBirth = new DateTime(2000,02,02), PanNumber = "ABCD10001A"},
            new Customer(){CustomerId = 102, FirstName = "Aditya", LastName = "Mohan", Address = "Bihar", DateOfBirth = new DateTime(1998,07,20), PanNumber = "ABCD10002B"},
            new Customer(){CustomerId = 103, FirstName = "Sumit", LastName = "Sharad", Address = "Bihar", DateOfBirth = new DateTime(1998,04,15), PanNumber = "ABCD10003C"},
            new Customer(){CustomerId = 104, FirstName = "Soham", LastName = "Patra", Address = "Jamsedhpur", DateOfBirth = new DateTime(1998,08,25), PanNumber = "ABCD10004B"},
            new Customer(){CustomerId = 105, FirstName = "Aditya", LastName = "Mishra", Address = "UP", DateOfBirth = new DateTime(1999,02,02), PanNumber = "ABCD10001D"}
        };
    }
}