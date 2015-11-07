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

        public Teacher(int v) : base(v) { }

        public void AddClassTitle(string title)
        {
            if (!classTitles.Contains(title))
            {
                classTitles.Add(title);
                OnClassAdded?.Invoke(this, new AddClassEventArgs(title, this.SubjectArea));
            }
        }

        private readonly List<string> classTitles = new List<string>();

        public string SubjectArea { get; set; }
        public IEnumerable<string> ClassTitles => classTitles;

        public void RemoveClassTitle(string title)
        {
            classTitles.Remove(title);
        }
    }
}
