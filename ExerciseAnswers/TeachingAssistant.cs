using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    public class TeachingAssistant : Student, ITeach
    {
        private string classOne;
        private string classTwo;

        public TeachingAssistant(int id) : base(id) { }

        public IEnumerable<string> ClassTitles
        {
            get
            {
                if (classOne != null)
                    yield return classOne;
                if (classTwo != null)
                    yield return classTwo;
            }
        }

        public string SubjectArea { get; set; }

        public void AddClassTitle(string title)
        {
            if ((classOne == title) || (classTwo == title))
                return;

            if (classOne == null)
                classOne = title;
            else if (classTwo == null)
                classTwo = title;
            else
                throw new InvalidOperationException("T.A.s can only teach two classes");
        }

        public void RemoveClassTitle(string title)
        {
            if (classOne == title)
                classOne = null;
            if (classTwo == title)
                classTwo = null;
        }

    }
}
