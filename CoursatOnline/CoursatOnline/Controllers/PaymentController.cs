using CoursatOnline.Paymentt;
using CoursatOnline.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoursatOnline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        [Route("pay")]
        [HttpPost]
        public async Task<dynamic> Pay(Models.Payment mp)
        {
            
            return await MakePayment.PaymentAsync(mp.cardnumber, mp.month, mp.year, mp.cvc, mp.value);
        }
    }
}
