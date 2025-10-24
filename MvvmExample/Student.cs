using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MvvmExample
{
    public class Student : INotifyPropertyChanged
    {
        /// <summary>Notifies when a property changes</summary>        
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>The student's course-taking history</summary>
        private List<CourseRecord> _courseRecords = new();

        /// <summary>The student's first name</summary>
        public string FirstName { get; init; }

        /// <summary>The student's last name</summary>
        public string LastName { get; init; }

        /// <summary>The student's course records</summary>
        /// <remarks>We return a copy of the course records to prevent modifications</remarks>
        public IEnumerable<CourseRecord> CourseRecords => _courseRecords.ToArray();

        /// <summary>The student's GPA</summary>
        public double GPA
        {
            get
            {
                var points = 0.0;
                var hours = 0.0;
                foreach (var cr in CourseRecords)
                {
                    points += (double)cr.Grade * cr.CreditHours;
                    hours += cr.CreditHours;
                }
                return points / hours;
            }
        }

        /// <summary>
        /// Adds <paramref name="cr"/> to the students' course history
        /// </summary>
        /// <param name="cr">The course record to add</param>
        public void AddCourseRecord(CourseRecord cr)
        {
            _courseRecords.Add(cr);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CourseRecords)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(GPA)));
        }

        /// <summary>
        /// Constructs the student object
        /// </summary>
        /// <param name="firstName">The student's first name</param>
        /// <param name="lastName">The student's last name</param>
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
