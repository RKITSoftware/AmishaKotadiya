
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestWebAPIDemo.Controllers
{
    public class WebAPIController : ApiController
    {

        static List<string> studentnames = new List<string> {"a", "b", "c", "d" };
        // GET api/<controller>
        public IEnumerable<string> GetNames()
        {
            return studentnames;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return studentnames[id];
        }

        // Use Route attribute
        [Route("api/WebAPI/{id}/courses")]
        // GET api/<controller>/<id>/courses
        public IEnumerable<string> GetCourses(int id)
        {
            if (id == 1)
                return new List<String>() { "C", "ASP.NET", "JAVA"};
            else if (id == 2)
                return new List<String>() { "C#", "PHP", "ANDROID" };
            else
                return new List<String>() { "C++", "HTML", "SQL" };
        }



        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
            var(Studentnames)
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}