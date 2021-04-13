using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace API.Controllers
{
    public class cartAPIcontroller
    {
        [Route("api/[controller]")]
        [ApiController]
    public class cartAPIController : ControllerBase
    {
        // GET: api/cartAPI
        [EnableCors("AnotherPolicy")]
        [HttpGet]
        public List<cart> Get()
        {
            iReadAllData readObject = new saveData();
            return readObject.GetAllItems();
        }

        // GET: api/cartAPI/5
        [EnableCors("AnotherPolicy")]
        [HttpGet("{id}", Name = "Get")]
        public Post Get(int id)
        {
            iGetPost realObject = new readData();
            return realObject.GetPost(id);
        }

        // POST: api/bigalapi
        [EnableCors("AnotherPolicy")]
        [HttpPost]
        public void Post([FromBody] cart value)
        {
            iAddCart insertObject = new addCart();
            insertObject.addCartItem(value);
        }

        // PUT: api/bigalapi/5
        [EnableCors("AnotherPolicy")]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] cart value)
        {
            iAddCart putObject = new addCart();
            putObject.addCartItem(id, value);
        }

        // DELETE: api/bigalapi/5
        [EnableCors("AnotherPolicy")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            iDelCart deleteObject = new delCart();
            deleteObject.DeleteCartItem(id);
            Console.WriteLine(id);
        }
    }
    }
}
