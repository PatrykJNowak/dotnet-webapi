using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using dotnet_webapp.Models;
using MediatR;


namespace dotnet_webapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddCustController : ControllerBase
    {
        // public async Task<ActionResult> AddMany(
        //     [FromServices] IMediator mediator,
        //     CancellationToken cancellationToken, [FromBody]
        
        
        // GET: api/AddCustomer
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            using Context myContext = new Context();
            var Customer = myContext
                .Customer
                .ToList();
            return Customer;
        }

        // GET: api/AddCustomer/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/AddCustomer
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/AddCustomer/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/AddCustomer/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
