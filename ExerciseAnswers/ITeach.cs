using System.Collections.Generic;

namespace ClassExercises
{
    public interface ITeach
    {
        IEnumerable<string> ClassTitles { get; }
        string SubjectArea { get; set; }

        void AddClassTitle(string title);
        void RemoveClassTitle(string title);
    }
}