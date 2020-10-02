using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DataAccessLibrary;
using RoomLibrary;
using System.Configuration;
using Microsoft.AspNetCore.Cors;

namespace SchoolsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        DataAccess db = new DataAccess();
        List<Rooms> rooms = new List<Rooms>();
        // GET api/values
        [HttpGet]        
        [EnableCors("AllowOrigin")]
        public ActionResult<IEnumerable<Rooms>> Get()
        {
            string connectionstring = @"Server=(localdb)\MSSQLLocalDB;Database=SchoolRooms;Trusted_Connection=True;";
            rooms = db.GetAllRooms(connectionstring);

            return rooms.ToArray();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
