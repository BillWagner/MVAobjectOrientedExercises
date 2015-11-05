using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    public class Teacher : Person
    {
        public Teacher(int v) : base(v) { }

        public void AddClassTitle(string title)
        {
            if (!classTitles.Contains(title))
            {
                classTitles.Add(title);
            }
        }

        private readonly List<string> classTitles = new List<string>();

        public string SubjectArea { get; set; }
        public IEnumerable<string> ClassTitles => classTitles;
    }
}
