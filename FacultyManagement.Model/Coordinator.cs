using System.ComponentModel.DataAnnotations;

namespace FacultyManagement.Model
{
    public class Coordinator
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "First Name length could not be more than 50")]
        public string? FirstName { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Last Name length could not be more than 50")]
        public string? LastName { get; set; }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
