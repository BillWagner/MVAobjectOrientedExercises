using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{ 
    public class Student : Person
    {
        private int sumOfLetterGrades;
        private int totalClasesTaken;
        private int totalPoints;

        public Student(int id) : base(id) { }

        public double GradePointAverage =>
            (totalClasesTaken != 0) ? (double)sumOfLetterGrades / (double)totalClasesTaken : 0;


        public void RecordClassGrade(Grade letterGrade)
        {
            this.sumOfLetterGrades += (int)letterGrade;
            this.totalClasesTaken++;
        }

        internal void AssignGrade(string assignment, int points)
        {
            totalPoints += points;
        }

    }
}
