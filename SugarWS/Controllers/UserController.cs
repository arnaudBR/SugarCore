using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SugarWS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly ApplicationDbContext _context;

        public UserController(ILogger<UserController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public Core.User Get(int id)
        {
            // if(id ==1)
            //     return new Core.User("Eden", "Martin",DateTime.Now);
            // else
            //     return new Core.User("Jean", "Valjean",DateTime.Now);

            Core.User user = _context.User
                    .Single(u => u.Id == id);
            return user;
        }

        [HttpPost]
        public Core.User Create(string firstName, string lastName)
        {
            return new Core.User(firstName,lastName ,DateTime.Now);
        }
    }
}
