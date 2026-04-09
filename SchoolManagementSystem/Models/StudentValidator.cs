using FluentValidation;
using SchoolManagementSystem.Models;

public class StudentValidator : AbstractValidator<Student>
{
    public StudentValidator()
    {
        RuleFor(Student => Student.name)
            .NotEmpty().WithMessage("Name is required")
            .MinimumLength(3).WithMessage("Name must be at least 3 characters");
        RuleFor(Student => Student.age)
            .InclusiveBetween(6, 25).WithMessage("Age must be between 6 and 25");
        RuleFor(Student => Student.grade)
            .NotEmpty().WithMessage("Grade is required")
            .Must(grade => int.TryParse(grade, out int gradeValue) && gradeValue >= 0 && gradeValue <= 100)
            .WithMessage("Grade must be a number between 0 and 100");
    }
}