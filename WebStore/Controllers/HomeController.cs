using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using WebStore.Infrastructure;
using WebStore.Infrastructure.Models;
using WebStore.Models;

namespace WebStore.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly ApplicationContext _context;

		public HomeController(ILogger<HomeController> logger, ApplicationContext context)
		{
			_logger = logger;
			_context = context;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> GetPacients([FromBody] string fullSearch)
		{
			var orders = _context.Pacients.Select(x => new
			{
				x.Id,
				x.FirstName,
				x.SurName,
				x.Patronymic,
				Birthday = x.Birthday.ToShortDateString(),
				x.PhoneNumber
			}).Where(x => x.FirstName.Contains(fullSearch, StringComparison.InvariantCultureIgnoreCase)
			|| x.Patronymic.Contains(fullSearch, StringComparison.InvariantCultureIgnoreCase)
			|| x.SurName.Contains(fullSearch, StringComparison.InvariantCultureIgnoreCase)).ToList();
			return Json(orders);
		}
		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
