namespace InstituteLibrary;

using System.Collections;

public interface ICourseRepository
{
    void AddCourse(Course cmp);
    void UpdateCourse(int coursecode, Course cmp);
    void DeleteCourse(int coursecode);
    List<Course> GetAllCourse();
    Course GetCourse(int coursecode);

}
