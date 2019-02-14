using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonalSite.Shared
{
    public class Inquiry
    {
        public string Id { get; set; }
        public DateTime Timestamp { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        public string Email { get; set; }

        public string Phone { get; set; }

        public MethodOfContact PreferredMethodOfContact { get; set; }
        public string OtherMethodOfContact { get; set; }
    }
}
