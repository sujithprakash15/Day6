using System.Reflection.PortableExecutable;

namespace InstituteLibrary;

public class CourseRepository : ICourseRepository
{
  List<Course> list = new List<Course>();

    public void AddCourse(Course cmp)
    {
        list.Add(cmp);
    }

    public void DeleteCourse(int coursecode)
    {
        Course new1 = GetCourse(coursecode);
        list.Remove(new1);
    }

    public List<Course> GetAllCourse()
    {
        return list;
    }

    public Course GetCourse(int coursecode)
    {
        Course cmp = null;
        foreach(Course course in list)
        {
            if (course.CourseCode == coursecode)
            {
                cmp=course;
                break;
            }
        }
        return cmp;
    }

    public void UpdateCourse(int coursecode, Course cmp)
    {
        Course new2 = GetCourse(coursecode);
        if (coursecode != null)
        {
            new2.CourseTitle=cmp.CourseTitle;
            new2.CourseDuration=cmp.CourseDuration;
            new2.CourseFee=cmp.CourseFee;
        }
    }
}
