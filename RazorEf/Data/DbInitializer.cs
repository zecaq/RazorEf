using RazorEf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorEf.Data
{
    public static class DbInitializer
    {

        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            if (context.Student.Any())
            {
                return;
            }

            var students = new Student[]
            {
                new Student{FirstName="Marko",LastName="Njagrin",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Student{FirstName="Nemanja",LastName="Barac",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstName="Suncica",LastName="Janus",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstName="Djordje",LastName="Vojcanin",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstName="Ervin",LastName="Letonai",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstName="Nikola",LastName="Jeremic",EnrollmentDate=DateTime.Parse("2001-09-01")},
                new Student{FirstName="Aleksa",LastName="Bugarski",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstName="Nikola",LastName="Egic",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            foreach(Student s in students)
            {
                context.Student.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{CourseID=1011, Title="Marketing", Credits=6},
                new Course{CourseID=2099, Title="Business information systems", Credits=8},
                new Course{CourseID=2233, Title="Accounting and auditing", Credits=9},
                new Course{CourseID=3212, Title="Management", Credits=7},
                new Course{CourseID=4232, Title="Trade", Credits=6},
                new Course{CourseID=4889, Title="Finance, banking and insurance", Credits=7},
                new Course{CourseID=5002, Title="European and international economy and business", Credits=7},
                new Course{CourseID=5003, Title="Agrarian economy and agribusiness", Credits=7},
            };

            foreach(Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();


            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1, CourseID=1011, Grade=Grade.A},
                new Enrollment{StudentID=1, CourseID=2099, Grade=Grade.C},
                new Enrollment{StudentID=1 ,CourseID=2233, Grade=Grade.B},
                new Enrollment{StudentID=2, CourseID=3212, Grade=Grade.B},
                new Enrollment{StudentID=2, CourseID=4232, Grade=Grade.F},
                new Enrollment{StudentID=2, CourseID=4889, Grade=Grade.F},
                new Enrollment{StudentID=3, CourseID=5002},
                new Enrollment{StudentID=4, CourseID=5003},
                new Enrollment{StudentID=4, CourseID=3212, Grade=Grade.F},
                new Enrollment{StudentID=5, CourseID=2099, Grade=Grade.C},
                new Enrollment{StudentID=6, CourseID=5003},
                new Enrollment{StudentID=7, CourseID=1011, Grade=Grade.A},
            };
            foreach(Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges(); 

        }

    }
}
