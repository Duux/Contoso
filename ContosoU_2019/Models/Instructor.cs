using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoU_2019.Models
{
    //jconnors: Part 2: Create the data models
    public class Instructor:Person
    {
        [DataType(DataType.Date), Display(Name = "Enrollment Date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime HireDate { get; set; }

        //Navigation property
        //An instructor can teach ny number of courses, so Courses is defined as a collection of the CourseAssignment Entity
        public virtual ICollection<CourseAssignment> Courses { get; set; }

    }
}
