﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FacultyManagement.Model
{
    public class Student 
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "First Name length could not be more than 50")]
        public string? FirstName { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Last Name length could not be more than 50")]
        public string? LastName { get; set; }
        public Instructor? Advisor { get; set; }
        public List<Course> Courses { get; set; }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
