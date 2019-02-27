using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalSite.Server.Controllers
{
    [Route("api/File")]
    public class FileController : ControllerBase
    {
        public FileController()
        {
        }

        [HttpGet("Slideshow")]
        public IActionResult Slideshow()
        {
            List<string> images = new List<string>()
            {
                "https://s3.amazonaws.com/nickgalvin.com/Slideshow/Flatirons.jpg",
                "https://s3.amazonaws.com/nickgalvin.com/Slideshow/GravitynShit.jpg",
                "https://s3.amazonaws.com/nickgalvin.com/Slideshow/Oscar.jpg"
            };

            return Ok(images);
        }
    }
}
