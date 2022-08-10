using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;
using dotnet_webapp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;

namespace dotnet_webapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {

        // GET: api/Contact
        [HttpGet]
        public IEnumerable<Contact> Get()
        {
            using Context myContext = new Context();
            var Contact = myContext
                .Contact
                .ToList();
            return Contact;
        }
        
        // GET: api/Contact/5
        [HttpGet("{id}")]
        public IEnumerable<Contact>  Get(int id)
        {
            using Context myContext = new Context();
            var Contact = myContext
                .Contact
                .Where(x => x.Id == id)
                .ToList();
            return Contact;
        }
        
        // POST: api/Contact/5
        [HttpPost("{firstNameFromLink}, {lastNameFromLink}, {nickNameFromLink}, {placeFromLink}")]
        public void Post(string firstNameFromLink, string lastNameFromLink, string nickNameFromLink, string placeFromLink)
        {
            using Context myContext = new Context();
            myContext.Contact.Add(new Contact()
            {
                FirstName = firstNameFromLink,
                LastName = lastNameFromLink,
                NickName = nickNameFromLink,
                Place = placeFromLink
            });
            myContext.SaveChanges();
        }

        // PUT: api/Contact/?id=5
        [HttpPut("{id}, {firstNameFromLink}, {lastNameFromLink}, {nickNameFromLink}, {placeFromLink}")]
        public void Put(int id, string firstNameFromLink, string lastNameFromLink, string nickNameFromLink, string placeFromLink)
        {
            using Context myContext = new Context();
            // var Contact = myContext
            //     .Contact
            //     .ToList();
            // // return Contact;
            // Contact test = new Contact()
            // {
            //     
            // };
            // using Context myContext = new Context();
            // var Contact = myContext;
            myContext.Contact.UpdateRange(new Contact()
            {
                Id = id,
                FirstName = firstNameFromLink,
                LastName = lastNameFromLink,
                NickName = nickNameFromLink,
                Place = placeFromLink
            });
            myContext.SaveChanges();
        }

        // DELETE: api/Contact/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using Context myContext = new Context();
            // var Contact = myContext;
            myContext.Contact.RemoveRange(new Contact()
            {
                Id = id
            });
            myContext.SaveChanges();
        }
    }
}
