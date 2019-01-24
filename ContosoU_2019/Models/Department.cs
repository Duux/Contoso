using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoU_2019.Models
{
    public class Department
    {

        public int DepartmentID { get; set; }//pk

        [Required, StringLength(60, MinimumLength = 3, ErrorMessage = "Must have over 3 and under 60 characters")]
        public string Name { get; set; }

        [DataType(DataType.Currency), Column(TypeName = "money")]
        public decimal Budget { get; set; }

        [DataType(DataType.Date), Display(Name = "Date Created"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        //Relationship to instructor
        //A department MAY have an Administrator (isntructor), and an Administrator is always an Instructor
        [Display(Name = "Administrator")]
        public int? InstructorID { get; set; }

        //Navigation properties
        //Administrator is always an Instructor
        public virtual Instructor Administrator { get; set; }

        //One department to many courses
        public virtual ICollection<Course> Courses { get; set; }
    }
}
