using Microsoft.AspNetCore.Mvc;

namespace dotnet_api_demo.Controllers
{
    public class DummyController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}