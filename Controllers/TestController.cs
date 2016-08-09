using Microsoft.AspNetCore.Mvc;

namespace WebApplication
{
    public class TestController : Controller 
    {
        public IActionResult Index() {
            return Content("hello from asp.net");
        }
    }
}