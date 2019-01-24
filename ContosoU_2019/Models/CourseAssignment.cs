namespace ContosoU_2019.Models
{
    public class CourseAssignment
    {
        public int InstructorID { get; set; }//Composite PK, FK to Instructor Entity

        public int CourseID { get; set; }//Composite PK, FK to Course Entity

        /*
         * The only way to identify composite pk to EF is by using the Fluent API
         * Within the DbContext class (in this case the SchoolContext class)
         * It cannot be done using attributes
         */

        //Navigation properties
        //Many to Many (this is the junction table between courses and instructor)
        //Many instructors teaching many courses
        //1 course many Course Assignments
        //1 instructor many course Assignments\

        public virtual Instructor Instructor { get; set; }
        public virtual Course Course { get; set; }

    }
}