using Microsoft.AspNetCore.Mvc;

namespace MvcTemplateProject.Controllers
{
	public class DefaultController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Hakkimizda()
		{
			return View();
		}
	}
}
