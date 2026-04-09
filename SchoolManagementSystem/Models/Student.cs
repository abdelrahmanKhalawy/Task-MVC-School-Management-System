using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.Models
{
    public class Student
    {
        public int id { get; set; }
        // [Required(ErrorMessage = "Name is required")]
        public string name { get; set; }
        // [Range(6, 25, ErrorMessage = "Age must be between 6 and 25")]
        public int age { get; set; }
        // [Required(ErrorMessage = "Grade is required")]
        // [Range(0, 100, ErrorMessage = "Grade must be between 0 and 100")]
        public string? grade { get; set; }

        public Student()
        {
            id = 0;
            name = string.Empty;
            age = 0;
        }
    }
}
