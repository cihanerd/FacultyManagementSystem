using System.ComponentModel.DataAnnotations;

namespace FacultyManagement.Model
{
    public class Course
    {
        public Course()
        {
            Name = "New Course";
        }

        public Course(string name)
        {
            Name = name;
        }
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [MaxLength(255)]
        public string? Details { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public Instructor? Instructor { get; set; }
        public List<Student> Students { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
