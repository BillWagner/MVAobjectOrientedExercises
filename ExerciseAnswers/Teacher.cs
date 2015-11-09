using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    public class AddClassEventArgs : EventArgs
    {
        public string ClassTitle { get; }
        public string Subject { get; }
        public AddClassEventArgs(string title, string subject)
        {
            this.ClassTitle = title;
            this.Subject = subject;
        }
    }

    public class Teacher : Person, ITeach
    {
        public event EventHandler<AddClassEventArgs> OnClassAdded;

        public Teacher(int id) : base(id) { }

        public string SubjectArea { get; set; }

        private List<string> classTitles = new List<string>();

        private int totalPointsGiven;
        private int numberOfGradesGiven;
        public void AddClassTitle(string title)
        {
            if (!classTitles.Contains(title))
            {
                classTitles.Add(title);
                OnClassAdded?.Invoke(this, new AddClassEventArgs(title, this.SubjectArea));
                var offering = new ClassOffering(this, (assignemt, result) => computePoints(assignemt, result));
                School.Singleton().AddClassOffering(offering);
            }
        }

        private int computePoints(string assignemt, string result)
        {
            var grade = new Random().Next(0, 100);
            totalPointsGiven += grade;
            numberOfGradesGiven++;

            return grade;
        }

        public double AverageStudentGrade()
        {
            return (double)totalPointsGiven / (double)numberOfGradesGiven;
        }

        public void RemoveClassTitle(string title)
        {
            classTitles.Remove(title);
        }

        public IEnumerable<string> ClassTitles => classTitles;
    }
}
