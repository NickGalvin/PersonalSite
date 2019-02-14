using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalSite.Server
{
    public class SiteConfig
    {
        /// <summary>
        /// Amazon Web Services
        /// </summary>
        public AWSConfig AWS { get; set; }

        /// <summary>
        /// JSON Web Token
        /// </summary>
        public JWTConfig JWT { get; set; }

        public PayPal PayPal { get; set; }
    }

    public class AWSConfig
    {
        public string S3_Bucket { get; set; }
        public string ProfileName { get; set; }
        public string AccessKey { get; set; }
        public string SecretKey { get; set; }
    }

    public class JWTConfig
    {
        public string SigningSecret { get; set; }
        public int ExpiryDuration { get; set; }
    }

    public class PayPal
    {
        public string MerchantId { get; set; }
        public string PublicKey { get; set; }
        public string PrivateKey { get; set; }
    }

    public class FacebookConfig
    {
        public string SecretKey { get; set; }
        public string AccessKey { get; set; }
    }
}
