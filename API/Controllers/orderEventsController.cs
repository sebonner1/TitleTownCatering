using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Interfaces;
using API.Models;
using Microsoft.AspNetCore.Cors;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class orderEventsController : ControllerBase
    {
        [EnableCors("AnotherPolicy")]
        // GET: api/posts
        [HttpGet]
        public List<OrderEvent> Get()
        {
            IReadAllData readObject = new ReadData();
            return readObject.GetAllOrderEvents();
        }

        [EnableCors("AnotherPolicy")]
        // GET: api/posts/5
        [HttpGet("{id}", Name = "Get")] // for a single post, not needed.
        public void Get(int id)
        {
            IReadAllData readObject = new ReadData();
        }

        // POST: api/posts
        // Post updates a tweet
        [EnableCors("AnotherPolicy")]
        [HttpPost]
        public void Post(int id)
        {
            ISaveData InsertObject = new SaveData();
            InsertObject.SaveOrderEvent(value); // Office Hours question: would I make this an overload method??
        }

        // PUT: api/posts/5
        // Put edits a tweet 
        [EnableCors("AnotherPolicy")]
        [HttpPut("{id}")]
        public void Put(int id)
        {
            IEditData NewEditObject = new EditData();
            NewEdittObject.SaveOrderEvent(id);
        }

        // DELETE: api/ApiWithActions/5
        [EnableCors("AnotherPolicy")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Console.WriteLine(id);
            IAddDeleteData NewDeleteObject = new AddDeleteData();
            NewDeleteObject.DeleteOrderEvent(id);
        }
    }
}
