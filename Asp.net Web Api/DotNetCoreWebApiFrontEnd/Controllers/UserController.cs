using DotNetCoreWebApiFrontEnd.Data;
using DotNetCoreWebApiFrontEnd.Model;
using DotNetCoreWebApiFrontEnd.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWebApiFrontEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserDetailsServices _userService;

        private UserManagementDbContext _context;
        public UserController(UserDetailsServices userService, UserManagementDbContext context)
        {
            _userService = userService;
            _context = context;
        }
        
       /* [HttpGet("GetAllUserDetails")]
        public List<UserDetails> GetAllUsers()
        {
            return _userService.GetAllUserDetails();
        }

        [HttpGet("SearchById")]
        public IActionResult GetUserByIds(int id)
        {
            var user1 = _userService.GetUserById(id);

            if (user1 == null)
            {
                return NotFound();
            }

            return Ok(user1);
        }*/

        [HttpPost("CreateUser")]
        public IActionResult AddUsers(UserDetails user)
        {
            if(_context.UserDetails.Where(u => u.Email == user.Email).FirstOrDefault() !=null )
            {
                return Ok("Already exits");
            }
            user.MemberSince = DateTime.Now;
            var query = _userService.AddUser(user);
            return Ok("Success from create Method");
        }
       /* [HttpPut]
        public IActionResult UpdateUsers(int id, UserDetails user)
        {
            var Details = _userService.UpdateUser(id, user);
            if (Details == null)
            {
                return NotFound();
            }
            return Ok(Details);

        }
        [HttpDelete]
        public IActionResult DeleteUsers(int id)
        {
            var Details1 = _userService.DeleteUser(id);
            if (Details1 == null)
            {
                return NotFound();
            }
            return Ok(Details1);

        }*/

    }
}
