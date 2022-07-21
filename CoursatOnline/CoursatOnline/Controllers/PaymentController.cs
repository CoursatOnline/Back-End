using CoursatOnline.Paymentt;
using CoursatOnline.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoursatOnline.Data;

namespace CoursatOnline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        CoursatOnlineDbContext db;
        public PaymentController(CoursatOnlineDbContext db)
        {
            this.db = db;
        }

        [Route("pay")]
        [HttpPost]
        public async Task<dynamic> Pay(Models.Payment mp)
        {
            MakePayment mpMakePayment = new MakePayment();
            
            
            
            return await mpMakePayment.PaymentAsync(mp.cardnumber, mp.month, mp.year, mp.cvc, mp.value); ; 

        }
    }
}
