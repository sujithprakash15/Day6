
namespace InstituteLibrary;

public class StudentRepository : IStudentRepository
{
    List<Student> student = new List<Student>();
    public void AddStudent(Student stu)
    {
        student.Add(stu);
    }

    public void DeleteStudent(int RollNo)
    {
        throw new NotImplementedException();
    }

    public List<Student> GetAllStudents()
    {
        return student;
    }

    public Student GetStudent(int RollNo)
    {
        Student stu = null;
        foreach(Student stu1 in student)
        {
            if(stu1.RollNo == RollNo)
            {
                stu=stu1;
                break;
            }
        }
        return stu;
    }

    public Student GetStudentsByBatch(int BatchCode)
    {
        throw new NotImplementedException();
    }

    public void UpdateStudent(int RollNo, Student stu)
    {
        Student new1 = GetStudent(RollNo);
        
    }
}
