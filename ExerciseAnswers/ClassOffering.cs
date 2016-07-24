using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    public class ClassOffering
    {
        private readonly Teacher leadInstructor;
        private readonly List<TeachingAssistant> assisstants = new List<TeachingAssistant>();
        private readonly List<Student> students = new List<Student>();
        private readonly Func<string, string, int> gradingFunc;

        public ClassOffering(Teacher leadInstructor, Func<string, string, int> gradingFunction)
        {
            this.leadInstructor = leadInstructor;
            this.gradingFunc = gradingFunction;
        }

        public void EnrollStudent(Student s)
        {
            if (!students.Any(s1 => s1.Id == s.Id))
                students.Add(s);
        }

        public void TurnInAssignment(Student enrollee, string assignment, string result)
        {
            var points = gradingFunc(assignment, result);


            enrollee.AssignGrade(assignment, points);
        }

        public double AverageGPAForStudents()
        {
            if (!students.Any())
                return 0.0;
            return Enumerable.Average(students.Select(s => s.GradePointAverage));
        }
    }
}
