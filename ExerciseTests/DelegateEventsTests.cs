using ClassExercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ExerciseTests
{
    public class DelegateEventsTests
    {
        [Fact]
        public void AStudentCanRegistorForNewClassOfferings()
        {
            var title = default(string);
            var t = new Teacher(1);


            t.OnClassAdded += (tt, args) => title = args.ClassTitle;

            t.AddClassTitle("A cool class");
            Assert.Equal("A cool class", title);
        }
        
        [Fact]
        public void TeacherGradesHomework()
        {
            bool assigned = false;
            var t = new Teacher(1);
            var offer = new ClassOffering(t, (assignment, name) => { assigned = true; return 5; });

            var s = new Student(2);
            offer.TurnInAssignment(s, "assignment", "result");

            Assert.True(assigned);
        }
    }
}
