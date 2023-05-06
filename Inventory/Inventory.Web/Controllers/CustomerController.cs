using Microsoft.AspNetCore.Mvc;

namespace Inventory.Web.Controllers
{
	public class CustomerController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
