using DemoWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoWebApp.Controllers
{
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { FirstName = "Tim", LastName = "Larry", Id = 1 });
            people.Add(new Person { FirstName = "Kim", LastName = "Larry", Id = 2 });
            people.Add(new Person { FirstName = "Randy", LastName = "Larry", Id = 3 });
        }

        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }



        // POST: api/People
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/People/5
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
