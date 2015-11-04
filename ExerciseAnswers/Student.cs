using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{ 
    public class Student
    {
        private int sumOfLetterGrades;
        private int totalClasesTaken;

        public Student(int id)
        {
            this.Id = id;
        }

        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public double GradePointAverage =>
            (totalClasesTaken != 0) ? (double)sumOfLetterGrades / (double)totalClasesTaken : 0;


        public void RecordClassGrade(Grade letterGrade)
        {
            this.sumOfLetterGrades += (int)letterGrade;
            this.totalClasesTaken++;
        }
    }
}
