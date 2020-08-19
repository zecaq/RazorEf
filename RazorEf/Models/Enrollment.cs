using System.Threading;

namespace RazorEf.Models
{
    public enum Grade
    {
        A = 10,
        B = 9,
        C = 8,
        D = 7,
        E = 6,
        F = 5
    }

    public class Enrollment
    {

        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        //The question mark after the Grade type declaration indicates that the Grade property is nullable.
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }

    }
}