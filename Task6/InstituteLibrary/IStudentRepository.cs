namespace InstituteLibrary;

public interface IStudentRepository
{
    void AddStudent(Student stu);
    Task UpdateStudent(int RollNo, Student stu);
    Task DeleteStudent(int RollNo);
    List<Student> GetAllStudents();
    Task<Student> GetStudent(int RollNo);
    Task<Student> GetStudentsByBatch(int BatchCode);
}
