using CreateDb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace test2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private TestContext _dbContext;
        public ServiceController(TestContext context) {
            _dbContext = context;
        }
        // GET: api/<ServiceController>
        [HttpGet]
        public List<Service> Get()
        {
            var services = _dbContext.Services.ToList();
            return services;
        }

        // GET api/<ServiceController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "service";
        }

        // POST api/<ServiceController>
        [HttpPost]
        public void Post([FromBody] Service value)
        {
            _dbContext.Add(value);
            _dbContext.SaveChanges();
        }

        // PUT api/<ServiceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ServiceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
