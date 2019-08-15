using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models
{
    public class Exercise
    {   
        [Required]
        [Display(Name = "Exercise Id")]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Exercise Name")]
        public string ExerciseName { get; set; }
        [Required]
        [Display(Name = "Exercise Language")]
        public string ExerciseLanguage { get; set; }
    }
}
