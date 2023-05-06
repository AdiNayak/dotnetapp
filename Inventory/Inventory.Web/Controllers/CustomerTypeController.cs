using Microsoft.AspNetCore.Mvc;

namespace Inventory.Web.Controllers
{
	public class CustomerTypeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
