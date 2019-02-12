using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSite.Shared.Blog
{
    public class Post
    {
        public string Id { get; set; }

        public string Title { get; set; }
        public string SubTitle { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        
        public string TextContent { get; set; }
        public string Content { get; set; }

        public string ImageUrl { get; set; }
        public string ImageAltText { get; set; }

        public static Post TestPost() => new Post
        {
            Title = "Test Post Title",
            SubTitle = "Subtitle",
            CreatedBy = "Nick Galvin",
            TextContent = "Test Content",
            ImageUrl = "https://s3.amazonaws.com/nickgalvin.com/Slideshow/GravitynShit.jpg",
            ImageAltText = "Gravity n' Shit",
            Content = "This is a post about Gravity n' Shit. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
        };
    }
}
