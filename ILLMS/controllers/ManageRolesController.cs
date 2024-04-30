using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ILLMS.models;
using ILLMS.service;

namespace ILLMS.controller
{
    
    [ApiController]
    [Route("[controller]")]
    public class ManageRolesController : ControllerBase
    {
        private readonly RegisteredUserHandler userService;

        public ManageRolesController(RegisteredUserHandler userService)
        {
            this.userService = userService;
        }

        [HttpGet("registered")]
        public ActionResult<IEnumerable<RegisteredUser>> GetRegisteredUsers()
        {
            var registeredUsers = userService.GetAllUsers(isRegistered: true);
            return Ok(registeredUsers);
        }
        
    }
}