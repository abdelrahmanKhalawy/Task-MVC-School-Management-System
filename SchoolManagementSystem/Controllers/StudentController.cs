
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

		[HttpGet("Add")]
		public IActionResult Create()
		{
			return View("create");
		}

		[HttpPost("View")]
		public IActionResult Create(Student student)
		{
			return Content("Student Added: " + student.name);
		}
	}
}