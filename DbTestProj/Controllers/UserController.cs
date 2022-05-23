using DbTestProj.Data;
using DbTestProj.Models;
using Microsoft.AspNetCore.Mvc;


namespace DbTestProj.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController
    {
        private readonly DbTestProjContext _context;
         public UserController(DbTestProjContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<User> Get()
        {
            var result = new List<User>();

            result.Add(new User()
            {
                Id = 1,
                Nickname = "riatree",
                Data = "2022-05-23",
                Created = DateTime.Now
            });

            return result;
        }

        [HttpGet]
        [Route("action")]
        public string hello()
        {
            return "Hello";
        }
    }
}
