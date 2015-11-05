using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    public class Teacher
    {
        public Teacher(int v)
        {
            this.Id = v;
        }

        public void AddClassTitle(string title)
        {
            if (!classTitles.Contains(title))
            {
                classTitles.Add(title);
            }
        }

        private readonly List<string> classTitles = new List<string>();

        public int Id { get; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SubjectArea { get; set; }
        public IEnumerable<string> ClassTitles => classTitles;
    }
}
