using ClassExercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ExerciseTests
{
    public class EncapsulationTests
    {
        [Fact]
        public void StudentHasNameAndId()
        {
            var underTest = new Student(2)
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            Assert.Equal(2, underTest.Id);
            Assert.Equal("Sample", underTest.FirstName);
            Assert.Equal("Student", underTest.LastName);
            Assert.Equal(0, underTest.GradePointAverage);
        }

        [Fact]
        public void AfterOneClassGPAReflectsSingleClass()
        {
            var underTest = new Student(1);

            underTest.RecordClassGrade(Grade.C);

            Assert.Equal((double)Grade.C, underTest.GradePointAverage);
        }

        [Fact]
        public void GPACalculationPerformsAverageCalculation()
        {
            var underTest = new Student(1);

            underTest.RecordClassGrade(Grade.C);
            Assert.Equal((double)Grade.C, underTest.GradePointAverage);

            underTest.RecordClassGrade(Grade.C);
            Assert.Equal((double)Grade.C, underTest.GradePointAverage);

            underTest.RecordClassGrade(Grade.A);
            Assert.Equal((double)8/3, underTest.GradePointAverage);

            underTest.RecordClassGrade(Grade.A);
            Assert.Equal((double)Grade.B, underTest.GradePointAverage);
        }
    }
}
