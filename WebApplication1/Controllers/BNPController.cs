using Microsoft.AspNetCore.Mvc;
using WebApplication1.Business;

namespace WebApplication1.Controllers
{
    public class BNPController : Controller
    {
        private readonly IBNPBusiness _bNPBusiness;
        public BNPController(IBNPBusiness bNPBusiness)
        {
            _bNPBusiness = bNPBusiness;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ActionPrices(IEnumerable<string> isins) {

            _bNPBusiness.PrepareData(isins);

            return Ok();
        }
    }
}
