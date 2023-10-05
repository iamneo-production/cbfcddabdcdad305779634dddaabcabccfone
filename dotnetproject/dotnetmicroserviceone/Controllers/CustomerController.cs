using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnetmicroserviceone.Controllers
{
    
    [Route("[controller]")]
    public class CustomerController : Controller
    {
       private readonly CustomerDbContext _context;
       public CustomerController(CustomerDbContext context){
        this._context = context;
       }
        public IEnumerable<Customer> Get()
        {
            return _context.Customers;
        }

        public IActionResult Get(int id)
        {
           var Customer = _context.Customers.Find(id);
           if(Customer == null){
                return NotFound();
            return Ok(Customer);
           }
        }

         public IActionResult Get(int id)
        {
           var Customer = _context.Customers.Find(id);
           if(Customer == null){
                return NotFound();
            return Ok(Customer);
           }
        }

    }
}