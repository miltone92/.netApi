using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using BbgApi.Models;
using BbgApi.DataAccess;

namespace BbgApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        // GET: api/values
        [HttpGet]
        public List<UserModel> Get()
        {
            MongoCRUD db = new MongoCRUD("BbgCluster");
            var results = db.Get<UserModel>("Users");
            return results;
         
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]UserModel value)
        {
            MongoCRUD db = new MongoCRUD("BbgCluster");
            db.Post("Users", value );
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
