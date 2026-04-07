using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Controllers
{
	[Route("[controller]")]
	public class StudentController : Controller
	{
		static List<Student> students = new List<Student>();

		[HttpGet("Index")]
		public IActionResult Index()
		{
			return View(students);
		}


		[HttpGet("Add")]
		public IActionResult Create()
		{
			return View("create");
		}

		[HttpPost("Add")]
		public IActionResult Create(Student student)
		{
			student.id = students.Count + 1;
			students.Add(student);
			return RedirectToAction("Index");
		}

		[HttpGet("Details/{id}")]
		public IActionResult Details(int id)
		{
			var student = students.FirstOrDefault(s => s.id == id);
			return View(student);
		}


		[HttpGet("Edit/{id}")]
		public IActionResult Edit(int id)
		{
			var student = students.FirstOrDefault(s => s.id == id);
			return View(student);
		}

		[HttpPost("Edit/{id}")]
		public IActionResult Edit(Student student)
		{
			var existing = students.FirstOrDefault(s => s.id == student.id);
			if (existing != null)
			{
				existing.name = student.name;
				existing.age = student.age;
				existing.grade = student.grade;
			}
			return RedirectToAction("Index");
		}

		[HttpGet("Delete/{id}")]
		public IActionResult Delete(int id)
		{
			var student = students.FirstOrDefault(s => s.id == id);
			if (student != null)
			{
				students.Remove(student);
			}
			return RedirectToAction("Index");
		}
	}
}