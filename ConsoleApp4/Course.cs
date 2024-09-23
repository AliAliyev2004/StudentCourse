namespace ConsoleApp4;

public class Course
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public List<StudentCourse> StudentCourses { get; set; }
}