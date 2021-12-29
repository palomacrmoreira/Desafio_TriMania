using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Desafio_TriMania.Data;
using Desafio_TriMania.Models;
using Desafio_TriMania.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Desafio_TriMania.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {
        public readonly IUserServices _userServices;
        public UserController(IUserServices services)
        {
            _userServices = services;
        }

        [HttpGet]
        public List<User> GetUsers() => _userServices.GetUsers();

        [HttpGet("{id}")]
        public User GetUser(int id)
        {
            return _userServices.GetUser(id);
        }

        [HttpPost]
        public User CreateUser([FromBody] User user)
        {
            _userServices.CreateUser(user);
            return user;
        }

        [HttpPut]
        public User UpdateUser([FromBody] User user)
        {
            _userServices.UpdateUser(user);
            return user;
        }


        [HttpDelete("{id}")]
        public int DeleteUser(int id)
        {

            _userServices.DeleteUser(id);
            return id;

        }


    }
}