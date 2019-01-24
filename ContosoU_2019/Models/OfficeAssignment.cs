using System.ComponentModel.DataAnnotations;

namespace ContosoU_2019.Models
{
    public class OfficeAssignment
    {
        [Key]
        public int InstructorID { get; set; }

        [StringLength(60, ErrorMessage = "Can only be 60 characters long"), Display(Name = "Office Location")]
        public string Location { get; set; }    

        public virtual Instructor Instructor { get; set; }

    }
}