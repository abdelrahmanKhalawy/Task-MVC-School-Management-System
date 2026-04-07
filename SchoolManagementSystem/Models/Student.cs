namespace SchoolManagementSystem.Models
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string grade { get; set; }

        public Student()
        {
            id = 0;
            name = string.Empty;
            age = 0;
            grade = string.Empty;
        }
    }
}
