using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Braintree;
namespace PersonalSite.Server.Services
{
    public class BrainTreeService
    {
        private readonly PayPal _paypal;
        private BraintreeGateway Gateway { get; }

        public BrainTreeService(SiteConfig config)
        {
            _paypal = config.PayPal;
            Gateway = new BraintreeGateway
            {
                MerchantId = _paypal.MerchantId,
                PublicKey = _paypal.PublicKey,
                PrivateKey = _paypal.PrivateKey,
                Environment = Braintree.Environment.SANDBOX
            };
          
        }

        public bool SubmitPayment(string nonce, string customerId, string cardToken)
        {
            var clientToken = Gateway.ClientToken.Generate(new ClientTokenRequest { CustomerId = customerId });
            TransactionRequest request = new TransactionRequest
            {
                Type = TransactionType.SALE,
                Amount = 1000.00M,
                PaymentMethodNonce = nonce,
                Options = new TransactionOptionsRequest
                {
                    SubmitForSettlement = true, PayPal = new TransactionOptionsPayPalRequest
                    {
                        CustomField = "Custom123",
                    },
                    StoreInVault = true,
                    SkipCvv = false,
                    SkipAvs = false
                },  CreditCard = new TransactionCreditCardRequest
                {
                    Token = cardToken,
                    Number = "1311-2322-2234",
                    CVV = "123",
                    CardholderName = "Testy McTest",
                    ExpirationDate = "1223",
                    ExpirationYear = "23",
                    ExpirationMonth = "12"
                },
            };

            Result<Transaction> result = Gateway.Transaction.Sale(request);

            if (result.IsSuccess())
            {
                Transaction transaction = result.Target;
                Console.WriteLine("Success!: " + transaction.Id);
            }
            else if (result.Transaction != null)
            {
                Transaction transaction = result.Transaction;
                Console.WriteLine("Error processing transaction:");
                Console.WriteLine("  Status: " + transaction.Status);
                Console.WriteLine("  Code: " + transaction.ProcessorResponseCode);
                Console.WriteLine("  Text: " + transaction.ProcessorResponseText);
            }
            else
            {
                foreach (ValidationError error in result.Errors.DeepAll())
                {
                    Console.WriteLine("Attribute: " + error.Attribute);
                    Console.WriteLine("  Code: " + error.Code);
                    Console.WriteLine("  Message: " + error.Message);
                }
            }

            return false;
        }
    }
}