using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PayPal.Api;

namespace PersonalSite.Server.Services
{
    public class PayPalService
    {
        public string MerchantId => "4dx9yx44hqvvwq7v";
        public string PublicKey => "jxzk566nd96cpcxj";
        public string PrivateKey => "335ef1dd63768bafd77cf4828d103041";

        public void Test()
        {
            OAuthTokenCredential creds = new OAuthTokenCredential(PublicKey, PrivateKey);
            var accessToken = creds.GetAccessToken();

            var payment = new Payment();
            payment = Payment.Create(new APIContext(accessToken), payment);

        }
    }
}
