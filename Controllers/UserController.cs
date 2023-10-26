using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using simple_web_api.Models;

namespace simple_web_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        public static List<User> users = new List<User>(){
            //id, meno, priezvisko, vek, datum narodenia
            new User{Id = 1, Name = "Peter", Surname = "Hajduk", Years = 25, Birthdate = new DateTime(1998, 4, 20)}
        };

        [HttpGet("GetAllUsers")]
        public ActionResult<List<User>> GetAllUsers(){
            return Ok(users);
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetUserById(int id){
            var user = users.FirstOrDefault(x => x.Id == id);
            return Ok(user);
        }

        [HttpPost]
        public ActionResult<List<User>> AddUser(User user){
            users.Add(user);
            return Ok(users);
        }
        
    }
}