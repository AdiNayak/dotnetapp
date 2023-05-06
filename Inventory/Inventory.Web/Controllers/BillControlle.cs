using Microsoft.AspNetCore.Mvc;

namespace Inventory.Web.Controllers
{
	public class BillControlle : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
