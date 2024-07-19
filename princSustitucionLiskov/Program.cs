using System;

namespace princSustitucionLiskov
{
    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Course onlineCourse = new OnlineCourse { CourseId = 976, Title = "ITLA1" };
            Course onsiteCourse = new OnsiteCourse { CourseId = 809, Title = "ITLA2" };
            Course hybridCourse = new HybridCourse { CourseId = 236, Title = "ITLA3" };

            Student student = new Student { firstName = "Paula", lastName = "Henrsez" };

            SubscribeAndDetails(onlineCourse, student);
            SubscribeAndDetails(onsiteCourse, student);
            SubscribeAndDetails(hybridCourse, student);
        }

        static void SubscribeAndDetails(Course course, Student student)
        {
            course.Subscribe(student);
            Console.WriteLine(course.GetCourseDetails());
        }
    }
}
