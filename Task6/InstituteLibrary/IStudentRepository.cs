namespace InstituteLibrary;

public interface IStudentRepository
{
   void AddStudent(Student stu);
   void UpdateStudent(int RollNo,Student stu);
   void DeleteStudent(int RollNo);
   List<Student> GetAllStudents();
   Student GetStudent(int RollNo);
   Student GetStudentsByBatch(int BatchCode);
}
