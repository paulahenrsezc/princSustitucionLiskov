using System;

namespace princSustitucionLiskov
{
    public abstract class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }

        public abstract void Subscribe(Student std);
        public abstract string GetCourseDetails();
    }

    public class OnlineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            // write code to subscribe to an online course
        }

        public override string GetCourseDetails()
        {
            return $"Online Course: {Title} / ID: {CourseId}";
        }
    }

    public class OnsiteCourse : Course
    {
        public override void Subscribe(Student std)
        {
            // write code to subscribe to an onsite course
        }

        public override string GetCourseDetails()
        {
            return $"Onsite Course: {Title} / ID: {CourseId}";
        }
    }

    public class HybridCourse : Course
    {
        public override void Subscribe(Student std)
        {
            // write code to subscribe to an hybrid course
        }

        public override string GetCourseDetails()
        {
            return $"Hybrid Course: {Title} / ID: {CourseId}";
        }
    }

}
