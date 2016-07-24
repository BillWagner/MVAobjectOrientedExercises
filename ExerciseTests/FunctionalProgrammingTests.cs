using ClassExercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ExerciseTests
{
    public class FunctionalProgrammingTests
    {

        // Compute the average grade for all students that have taken a given class.
        [Fact]
        public void AverageOfZeroStudentsIsZero()
        {
            var classoffering = new ClassOffering(new Teacher(1), (s1, s2) => 0);
            var avg = classoffering.AverageGPAForStudents();
            Assert.Equal(0.0, avg);
        }

        [Fact]
        public void AverageOfStudentsGetsComputed()
        {
            var classoffering = new ClassOffering(new Teacher(1), (s1, s2) => 0);

            var s = new Student(1);
            s.RecordClassGrade(Grade.A);
            classoffering.EnrollStudent(s);
            s = new Student(2);
            s.RecordClassGrade(Grade.C);
            classoffering.EnrollStudent(s);

            var gpa = classoffering.AverageGPAForStudents();

            Assert.Equal(3.0, gpa);
        }

        // Sort all students by G.P.A.
        [Fact]
        public void StudentsCanBeSortedByGPA()
        {
            var students = new List<Student>
            {
                new Student(1) {FirstName = "First", LastName = "First" },
                new Student(2) {FirstName = "Second", LastName = "Second" }
            };

            students[0].RecordClassGrade(Grade.D);
            students[1].RecordClassGrade(Grade.A);

            var sorted = students.SortByGrade();
            Assert.Equal(2, sorted.First().Id);
            Assert.Equal(1, sorted.Last().Id);
        }

        // Sort all students alphabetically.
        [Fact]
        public void StudentsCanBeSortedByName()
        {
            var students = new List<Student>
            {
                new Student(1) {FirstName = "ZZZ", LastName = "ZZZ" },
                new Student(2) {FirstName = "AAA", LastName = "AAA" }
            };


            var sorted = students.SortByName();
            Assert.Equal(2, sorted.First().Id);
            Assert.Equal(1, sorted.Last().Id);
        }

        // Find the teacher that grades the easiest.

        // Find the teacher that grades the hardest.

        // For demo purposes, the grades are random, so I can't write 
        // good tests. We'll stop here.

    }
}
