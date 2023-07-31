using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Phase1Section5._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inheritance
            runApp();
            Console.ReadKey();
        }

        public static void runApp()
        {
            Subject algebra = new Subject();
            algebra.Name = "Algebra";

            Subject physics = new Subject();
            physics.Name = "Physics";

            SubjectTeacher algebraTeacher = new SubjectTeacher();
            algebraTeacher.Name = "Mr.Algebra";
            algebraTeacher.ContactAddress = "Some Address";
            algebraTeacher.DateOfJoining = Convert.ToDateTime("2009-10-20 00:00:00");
            algebraTeacher.WhichSubject = algebra;

            SubjectTeacher physicsTeacher = new SubjectTeacher();
            physicsTeacher.Name = "Mr.Physics";
            physicsTeacher.ContactAddress = "Some Address";
            physicsTeacher.DateOfJoining = Convert.ToDateTime("2009-10-20 00:00:00");
            physicsTeacher.WhichSubject = physics;

            CClass class8 = new CClass();
            class8.Name = "8";

            ClassTeacher teacherOf8 = new ClassTeacher();
            teacherOf8.Name = "Mrs.Class 8 Teachers";
            teacherOf8.ContactAddress = "Some Address";
            teacherOf8.DateOfJoining = Convert.ToDateTime("2009-10-20 00:00:00");
            teacherOf8.WhichClass = class8;

            class8.WhichTeacher = teacherOf8;

            Console.WriteLine("Subject: " + algebra.Name);
            Console.WriteLine("Subject Teacher: " + algebraTeacher.Name);
            Console.WriteLine("Subject Teacher Contact Address: " + algebraTeacher.ContactAddress);
            Console.WriteLine("Subject Teacher Date of Joining: " + algebraTeacher.DateOfJoining);
            Console.WriteLine("Subject Taught by Subject Teacher: " + algebraTeacher.WhichSubject.Name);

            Console.WriteLine();

            Console.WriteLine("Subject: " + physics.Name);
            Console.WriteLine("Subject Teacher: " + physicsTeacher.Name);
            Console.WriteLine("Subject Teacher Contact Address: " + physicsTeacher.ContactAddress);
            Console.WriteLine("Subject Teacher Date of Joining: " + physicsTeacher.DateOfJoining);
            Console.WriteLine("Subject Taught by Subject Teacher: " + physicsTeacher.WhichSubject.Name);

            Console.WriteLine();

            Console.WriteLine("Class: " + class8.Name);
            Console.WriteLine("Class Teacher: " + teacherOf8.Name);
            Console.WriteLine("Class Teacher Contact Address: " + teacherOf8.ContactAddress);
            Console.WriteLine("Class Teacher Date of Joining: " + teacherOf8.DateOfJoining);
            Console.WriteLine("Class Taught by Class Teacher: " + teacherOf8.WhichClass.Name);

        }
    }
}
