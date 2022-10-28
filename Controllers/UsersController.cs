using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsApi.Models;

namespace ProductsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {


        [HttpGet]
        [Route("GetUser")]
        public User[] GetUsers()
        {
            var users = new User[2];

            var user1 = new User();
            user1.UserId = 1;
            user1.UserName = "nouman";
            user1.FirstName = "Nouman";
            user1.LastName = "Sultan";
            user1.Password = "Noumnaaaa";
            users[0] = user1;


            var user2 = new User();
            user2.UserId = 2;
            user2.UserName = "faizan";
            user2.FirstName = "faizan";
            user2.LastName = "Sikandar";
            user2.Password = "faizanSikanadar";
            users[1] = user2;

            return users;
        }

    }

    
}
