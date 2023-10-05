using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace dotnetmicroserviceone.Models
{
    public class CustomerDbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext>options):base(options){

        }
        
    }
}