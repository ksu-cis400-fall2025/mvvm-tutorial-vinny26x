using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmExample
{
    public class ComputerScienceStudentViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// notifies when a property of class changes
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// student that this class wraps
        /// </summary>
        private Student _student { get; init;}
        /// <summary>
        /// student's first name
        /// </summary>
        public string FirstName => _student.FirstName;

        /// <summary>
        /// student's last name 
        /// </summary>
        public string LastName => _student.LastName;
        /// <summary>
        /// student gpa
        /// </summary>
        public double GPA => _student. GPA;
    }
}
