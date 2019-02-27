using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSite.Shared
{
    public class Metadata
    {
        public string ItemId { get; set; }

        public string Title { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }

        public string Type { get; set; }
        public string Source { get; set; }
        public string Format { get; set; }

        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public List<string> Tags { get; set; }
    }
}
