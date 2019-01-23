using System.ComponentModel.DataAnnotations;

namespace ContosoU_2019.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }//PK
        public int CourseID { get; set; }//FK to course
        public int StudentID { get; set; }//FK to student entitiy

        //Show "No Grade" in client instead of blank when grade is null
        [DisplayFormat(NullDisplayText = "No Grade Yet")]
        public Grade? Grade { get; set; }//? = Nullable

        //Navigation Property
        public virtual Student Student { get; set; } //Many enrollments to 1 student
        public virtual Course Course { get; set; } //Many enrollments to 1 course

    }

    //Grade enumeration
    public enum Grade
    { A, B, C, D, F}
}