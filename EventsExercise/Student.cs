using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExercise
{
    public class Student : Person
    {
        public Student(string name)
        {
            this.Name = name;
        }

        public string StudyField {  get; set; }
        public List<Subject> RegisteredSubjects {  get; set; } = new List<Subject>();
        public int YearOfStudies { get; set;}
        public double AverageGrade { get; set;}

        #region Event handling

        public event EventHandler? ReachedRegistrationLimit;
        private int NumberOfRegisteredSubjects = 0;
        public void RegisterSubject()
        {
            this.NumberOfRegisteredSubjects++;
            if (NumberOfRegisteredSubjects >= 3)
            {
                if (ReachedRegistrationLimit is not null)
                {
                    ReachedRegistrationLimit(this, EventArgs.Empty);
                }
            }
        }
        #endregion
    }
}
