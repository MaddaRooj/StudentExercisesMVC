using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models
{
    public class Student
    {
        [Required]
        [Display(Name = "StudentId")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "FirstName")]

        public string FirstName { get; set; }

        [Required]
        [Display(Name = "LastName")]

        public string LastName { get; set; }

        [Required]
        [Display(Name = "SlackHandle")]

        public string SlackHandle { get; set; }

        [Required]
        [Display(Name = "CohortId")]

        public int CohortId { get; set; }

        [Required]
        [Display(Name = "FullName")]

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
