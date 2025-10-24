using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmExample
{
    /// <summary>
    /// Represents the outcome of a student taking a particular course
    /// </summary>
    public class CourseRecord
    {
        /// <summary>
        /// The name of the course this record represents
        /// </summary>
        public string CourseName { get; init; }

        /// <summary>
        /// The grade earned by the student in the course
        /// </summary>
        public Grade Grade { get; init; }

        /// <summary>
        /// The credit hours of the course
        /// </summary>
        public double CreditHours { get; init; }

        /// <summary>
        /// Constructs a new GradeRecord for the outcome of a student taking a course
        /// </summary>
        /// <param name="courseName">The name of the course</param>
        /// <param name="grade">The grade earned in the course</param>
        /// <param name="creditHours">The credit hours the course was worth</param>
        public CourseRecord(string courseName, Grade grade, double creditHours)
        {
            CourseName = courseName;
            Grade = grade;
            CreditHours = creditHours;
        }

        /// <summary>
        /// Returns a string representing this course record
        /// </summary>
        /// <returns>A string identifying the course, grade, and credit hours of this record</returns>
        public override string ToString() => $"{CourseName} ({CreditHours} credits with a grade of {Grade})";
    }
}
