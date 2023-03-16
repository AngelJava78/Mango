using Mango.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Web.Controllers
{
    public class SonarController : Controller
    {
        ExampleClass exampleClass;
        public IActionResult Index()
        {
            exampleClass.ExampleMethod(10);
            exampleClass.ExampleMethod2();

            return View();
        }
    }
}
