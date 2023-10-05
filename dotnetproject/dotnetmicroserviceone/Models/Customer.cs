using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetmicroserviceone.Models
{
    public class Customer
    {
        public int CustomerId{get; set;} 
        public string CustomerName{get; set;}
        public string MobileNumber{get; set;}
        public string Email{get; set;}
   }
}