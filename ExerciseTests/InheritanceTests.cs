using ClassExercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ExerciseTests
{
    public class InheritanceTests
    {
        [Fact]
        public void TeachHasNameAndSubjectAreaAndId()
        {
            var underTest = new Teacher(7)
            {
                FirstName = "Sample",
                LastName = "Teacher",
                SubjectArea = "Maths"
            };

            Assert.Equal(7, underTest.Id);
            Assert.Equal("Maths", underTest.SubjectArea);
            Assert.False(underTest.ClassTitles.Any());

        }

        [Fact]
        public void TeachercCanTeachASingleClass()
        {
            var underTest = new Teacher(3);
            underTest.AddClassTitle("Remedial Math");

            Assert.Equal("Remedial Math", underTest.ClassTitles.Single());
        }

        [Fact]
        public void TeachercCanTeachMultipleClass()
        {
            var underTest = new Teacher(3);
            underTest.AddClassTitle("Remedial Math");
            underTest.AddClassTitle("General Math");
            underTest.AddClassTitle("Advanced Math");


            Assert.Equal("Remedial Math", underTest.ClassTitles.First());
            Assert.Equal("General Math", underTest.ClassTitles.Skip(1).First());
            Assert.Equal("Advanced Math", underTest.ClassTitles.Last());
            Assert.Equal(3, underTest.ClassTitles.Count());
        }

        [Fact]
        public void DuplicateClassIsNotAdded()
        {
            var underTest = new Teacher(3);
            underTest.AddClassTitle("Remedial Math");
            underTest.AddClassTitle("General Math");
            underTest.AddClassTitle("Advanced Math");
            underTest.AddClassTitle("General Math");

            Assert.Equal("Remedial Math", underTest.ClassTitles.First());
            Assert.Equal("General Math", underTest.ClassTitles.Skip(1).First());
            Assert.Equal("Advanced Math", underTest.ClassTitles.Last());
            Assert.Equal(3, underTest.ClassTitles.Count());
        }

    }
}
