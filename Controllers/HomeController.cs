using Microsoft.AspNetCore.Mvc;


namespace Neri_SportsStore.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index() => View();

	}
}
