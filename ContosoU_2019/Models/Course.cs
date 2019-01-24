using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoU_2019.Models
{
    public class Course
    {   
        /*
        * Remove identity - autonumber feature - Choices are Computed, Identity, None
        * Computed: Database generates a value when a row is inserted or updated
        * Identity: Database generates a vlue when a row is inserted
        * None: Database does not generate a value 
        */

        //User will have to eneter the courseID manually
        [Display(Name = "Course Number"), DatabaseGenerated(DatabaseGeneratedOption.None)] 
        public int CourseID { get; set; }//PK

        [Required, StringLength(50, MinimumLength = 3, ErrorMessage = "You must have over 3 characters and under 50 characters")]
        public string Title { get; set; }


        public int Credits { get; set; }    

        //Calculated readonly property
        //return the course id and course title
        public string CourseIdTitle
        {
            get
            {
                return CourseID + ": " + Title;
            }
        }

        //Navigation Properties
        //1 course to many enrollments
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        //A course can only belong at most to one department, so the Department property 
        //holds a single Department Entity (which may be null if no department is assigned)
        public virtual Department Department { get; set; }
    }
}