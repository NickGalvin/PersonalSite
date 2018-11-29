using System;

namespace Site.Core
{
    public class File
    {
        public string Id { get; set; }
        public string Extension { get; set; }
        public string FileName { get; set; }
        public Metadata Meta { get; set; }
    }
}
