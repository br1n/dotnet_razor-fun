using System;
using Microsoft.AspNetCore.Mvc;
namespace razor_fun
{
    public class RazorController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}