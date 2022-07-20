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
            //MakePayment.PaymentAsync(mp.cardnumber, mp.month, mp.year, mp.cvc, mp.value);
            //db.Payment.Add(mp);
            //await db.SaveChangesAsync();
            return MakePayment.PaymentAsync(mp.cardnumber, mp.month, mp.year, mp.cvc, mp.value);

        }
    }
}
