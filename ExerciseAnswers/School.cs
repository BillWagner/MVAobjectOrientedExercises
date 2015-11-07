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
}

