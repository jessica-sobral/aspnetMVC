using Microsoft.AspNetCore.Mvc;

namespace controlOfContacts.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}