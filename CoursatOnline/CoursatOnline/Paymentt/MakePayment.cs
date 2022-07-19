using Stripe;
namespace CoursatOnline.Paymentt
{
    public class MakePayment
    {
        public static async Task<dynamic> PaymentAsync(string cardnumder, int month, int year, string cvc, int value)
        {
            try
            {
                StripeConfiguration.ApiKey = "sk_test_51LMQ2dEiGk4ND4kcFA1N0JBXLgKTs62voOubvQxKOD44M8K6Khcw5GYtndFS7kjXMX58D1NTcsFI1QVyX1Ezm9hD00AWhcZs6N";
                var optionToken = new TokenCreateOptions
                {
                    Card = new TokenCardOptions
                    {
                        Number = cardnumder,
                        ExpMonth = month,
                        ExpYear = year,
                        Cvc = cvc,

                    }
                };
                var serviceToken = new TokenService();
                Token stripetoken = await serviceToken.CreateAsync(optionToken);

                var option = new ChargeCreateOptions
                {
                    Amount = value,
                    Currency = "usd",
                    Description = "test",
                    Source = stripetoken.Id
                };

                var service = new ChargeService();
                Charge charge = await service.CreateAsync(option);

                if (charge.Paid)
                    return "Success Paid";
                else
                    return "Faild Paid";


            }catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
