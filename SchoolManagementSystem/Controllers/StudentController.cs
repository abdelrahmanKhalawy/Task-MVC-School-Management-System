using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Controllers
{
	[Route("[controller]")]
	public class StudentController : Controller
	{
		private readonly AppDbContext context;

		public StudentController(AppDbContext context)
		{
			this.context = context;
		}

		[HttpGet("Index")]
		public IActionResult Index()
		{
			return View(context.Students.ToList());
		}


		[HttpGet("Add")]
		public IActionResult Create()
		{
			return View("create");
		}

		[HttpPost("Add")]
		public IActionResult Create(Student student)
		{
			if (ModelState.IsValid)
			{
				context.Students.Add(student);
				context.SaveChanges();
				return RedirectToAction("Index");
			}
			return View("create", student);
		}

		[HttpGet("Details/{id}")]
		public IActionResult Details(int id)
		{
			var student = context.Students.FirstOrDefault(s => s.id == id);
			return View(student);
		}


		[HttpGet("Edit/{id}")]
		public IActionResult Edit(int id)
		{
			var student = context.Students.FirstOrDefault(s => s.id == id);
			return View(student);
		}

		[HttpPost("Edit/{id}")]
		public IActionResult Edit(Student student)
		{
			if (ModelState.IsValid)
			{
				var existing = context.Students.FirstOrDefault(s => s.id == student.id);
				if (existing != null)
				{
					existing.name = student.name;
					existing.age = student.age;
					existing.grade = student.grade;
				}
				context.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(student);
		}

		[HttpGet("Delete/{id}")]
		public IActionResult Delete(int id)
		{
			var student = context.Students.FirstOrDefault(s => s.id == id);
			if (student != null)
			{
				context.Students.Remove(student);
				context.SaveChanges();
			}
			return RedirectToAction("Index");
		}
	}
}