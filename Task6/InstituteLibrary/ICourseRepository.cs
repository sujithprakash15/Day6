namespace InstituteLibrary;

using System.Collections;

public interface ICourseRepository
{
    void AddCourse(Course cmp);
    Task UpdateCourse(int coursecode, Course cmp);
    Task DeleteCourse(int coursecode);
    List<Course> GetAllCourse();
    Task<Course> GetCourse(int coursecode);

}
