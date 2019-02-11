using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalSite.Shared;
using PersonalSite.Server.Services;
using PersonalSite.Shared.Auth;
using PersonalSite.Shared.Blog;
using Microsoft.AspNetCore.Authorization;

namespace PersonalSite.Server.Controllers
{
    [Route("api/User")]
    public class UserController : ControllerBase
    {
        private UserService _user;

        public UserController(UserService user)
        {
            _user = user;
        }

        [HttpGet]
        public IActionResult GetUser()
        {
            var user = _user.GetUser();
            return Ok(user);
        }

        [HttpPost("Authenticate")]
        public IActionResult Authenticate([FromBody]AuthenticationRequest request)
        {
            var jwt = _user.Authenticate(request.Username, request.ProvidedPassword);
            if (jwt == null)
            {
                return Unauthorized();
            }
            var authResponse = new AuthenticateResponse
            {
                Token = jwt,
                Profile = UserProfile.TestProfile()
            };
            return Ok(authResponse);
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public IActionResult Create(User user)
        {
            var userIdClaim = HttpContext.User.Claims.Where(x => x.Type == "userid").SingleOrDefault();
            return Ok($"Your User ID is {userIdClaim.Value} and you can create invoices!");
        }

        [HttpGet("posts")]
        public IActionResult GetUserPosts()
        {
            var posts = new List<Post> { Post.TestPost(), Post.TestPost() };
            return Ok(posts);
        }
    }
}
