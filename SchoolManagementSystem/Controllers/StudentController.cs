
using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementSystem.Controllers
{
	[Route("[controller]")]
	public class StudentController : Controller
	{
		[HttpGet("Index")]
		public IActionResult Index()
		{
			return View();
		}
	}
}