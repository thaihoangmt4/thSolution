using Microsoft.AspNetCore.Mvc;

namespace thSolution.API.Controllers
{
    public class AccountController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
