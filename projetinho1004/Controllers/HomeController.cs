using Microsoft.AspNetCore.Mvc;
using projetinho1004.Models;
using System.Diagnostics;

namespace projetinho1004.Controllers
{
	public class HomeController : Controller
	{
		

	

		public IActionResult Index()
		{
			return View();
		}

		
		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
