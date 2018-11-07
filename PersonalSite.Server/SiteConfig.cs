using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalSite.Server
{
    public class SiteConfig
    {
        public AWSConfig AWS { get; set; }
    }

    public class AWSConfig
    {
        public string S3_Bucket { get; set; }
    }
}
