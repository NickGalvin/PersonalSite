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
        public string ProfileName { get; set; }
        public string AccessKey { get; set; }
        public string SecretKey { get; set; }
    }

    public class FacebookConfig
    {
        public string SecretKey { get; set; }
        public string AccessKey { get; set; }
    }
}
