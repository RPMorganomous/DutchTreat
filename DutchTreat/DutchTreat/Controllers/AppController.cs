using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
		{
			//throw new InvalidOperationException("Bad things happened");

			return View();
		}

		public IActionResult Contact()
		{
			ViewBag.title = "Contact Us";
			return View();
		}

		public IActionResult About()
		{
			ViewBag.Title = "About Us";
			return View();
		}
    }
}
