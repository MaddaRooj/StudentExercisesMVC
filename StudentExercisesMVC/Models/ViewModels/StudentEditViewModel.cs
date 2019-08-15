using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models.ViewModels
{
    public class StudentEditViewModel
    {
        public Student Student { get; set; }
        public List<SelectListItem> Cohorts { get; set; }

        public StudentEditViewModel()
        {

        }
        public StudentEditViewModel(Student student, List<Cohort> cohortList)
        {
            Student = student;
            Cohorts = cohortList.Select(cohort => new SelectListItem
            {
                Text = cohort.Name,
                Value = cohort.Id.ToString()
            })
              .ToList();

            Cohorts.Insert(0, new SelectListItem
            {
                Text = "Choose cohort...",
                Value = "0"
            });
        }
    }
}
