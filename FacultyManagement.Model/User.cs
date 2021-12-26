using System;
using System.ComponentModel.DataAnnotations;

namespace FacultyManagement.Model
{
    public class User
    {
        public Guid Id { get; set; }
        public Guid PersonalId { get; set; }
        public Role Role { get; set; }
        [MaxLength(20, ErrorMessage = "FirstName length could not be more than 50")]
        public string UserName { get; set; }
        [MaxLength(20, ErrorMessage = "Password length could not be more than 20")]
        [MinLength(6, ErrorMessage = "Password length could not be less than 6")]
        public string Password { get; set; }
        public override string ToString()
        {
            return UserName;
        }
    }
}
