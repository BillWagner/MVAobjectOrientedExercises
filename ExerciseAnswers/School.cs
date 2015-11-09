using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    public class School
    {
        private List<Student> allStudents = new List<Student>();
        private List<Teacher> allInstructors = new List<Teacher>();
        private List<ClassOffering> allClasses = new List<ClassOffering>();

        private School()
        {

        }

        private static School instance;

        public static School Singleton()
        {
            if (instance == null)
                instance = new School();
            return instance;
        }

        public void AddClassOffering(ClassOffering offering)
        {
            allClasses.Add(offering);
        }
    }

    public static class Extensions
    {
        public static IEnumerable<Student> SortByName(this IEnumerable<Student> students)
        {
            return students.OrderBy(s => s.LastName)
                .ThenBy(s => s.FirstName);
        }

        public static IEnumerable<Student> SortByGrade(this IEnumerable<Student> students)
        {
            return students.OrderByDescending(s => s.GradePointAverage);
        }

        public static Teacher HardestGrader(this IEnumerable<Teacher> instructors)
        {
            return instructors.Aggregate((min, current) =>
            {
                if (min.AverageStudentGrade() < current.AverageStudentGrade())
                    return min;
                else
                    return current;
            });
        }

        public static Teacher EasiestGrader(this IEnumerable<Teacher> instructors)
        {
            return instructors.Aggregate((max, current) =>
            {
                if (max.AverageStudentGrade() > current.AverageStudentGrade())
                    return max;
                else
                    return current;
            });
        }
    }
}

