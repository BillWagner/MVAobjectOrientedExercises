using ClassExercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ExerciseTests
{
    public class InterfaceTests
    {
        [Fact]
        public void TeachingAssistantHasProperDefault()
        {
            var underTest = new TeachingAssistant(42)
            {
                FirstName = "An",
                LastName = "Assistant",
                SubjectArea = "Science"
            };

            Assert.Equal(42, underTest.Id);
            Assert.Equal("Science", underTest.SubjectArea);
            Assert.False(underTest.ClassTitles.Any());
        }

        [Fact]
        public void TeachingAssistantCanTeachASingleClass()
        {
            var underTest = new TeachingAssistant(3);
            underTest.AddClassTitle("Biology 101");

            Assert.Equal("Biology 101", underTest.ClassTitles.Single());
        }

        [Fact]
        public void TeachingAssistantCanTeachTwoClasses()
        {
            var underTest = new TeachingAssistant(3);
            underTest.AddClassTitle("Biology 101");
            underTest.AddClassTitle("Physics 206");


            Assert.Equal("Biology 101", underTest.ClassTitles.First());
            Assert.Equal("Physics 206", underTest.ClassTitles.Last());
            Assert.Equal(2, underTest.ClassTitles.Count());
        }

        [Fact]
        public void TeachingAssistantCanTeachNoMoreThanTwoClasses()
        {
            var underTest = new TeachingAssistant(3);
            underTest.AddClassTitle("Biology 101");
            underTest.AddClassTitle("Physics 206");
            Assert.Throws<InvalidOperationException>(() => underTest.AddClassTitle("Chemistry 112"));


            Assert.Equal("Biology 101", underTest.ClassTitles.First());
            Assert.Equal("Physics 206", underTest.ClassTitles.Last());
            Assert.Equal(2, underTest.ClassTitles.Count());

        }

        [Fact]
        public void TeachingAssistantCanReplaceAClass()
        {
            var underTest = new TeachingAssistant(3);
            underTest.AddClassTitle("Biology 101");
            underTest.AddClassTitle("Physics 206");
            underTest.RemoveClassTitle("Biology 101");
            underTest.AddClassTitle("Chemistry 112");


            Assert.Equal("Chemistry 112", underTest.ClassTitles.First());
            Assert.Equal("Physics 206", underTest.ClassTitles.Last());
            Assert.Equal(2, underTest.ClassTitles.Count());

        }


    }
}
