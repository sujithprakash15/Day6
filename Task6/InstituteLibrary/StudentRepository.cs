
namespace InstituteLibrary;

public class StudentRepository : IStudentRepository
{
    List<Student> student = new List<Student>();
    public void AddStudent(Student stu)
    {
        student.Add(stu);
    }

    public async Task DeleteStudent(int RollNo)
    {
        Student new4 = await GetStudent(RollNo);
        student.Remove(new4);
    }

    public List<Student> GetAllStudents()
    {
        return student;
    }

    public async Task<Student> GetStudent(int RollNo)
    {
        Student stu = null;
        foreach (Student stu1 in student)
        {
            if (stu1.RollNo == RollNo)
            {
                stu = stu1;
                break;
            }
        }
        return stu;
    }

    public async Task<Student> GetStudentsByBatch(int BatchCode)
    {
        Student stu1 = null;
        foreach (Student new6 in student)
        {
            if (new6.BatchCode == BatchCode)
            {
                stu1 = new6;
                break;
            }
        }
        return stu1;
    }

    public async Task UpdateStudent(int RollNo, Student stu)
    {
        Student new1 = await GetStudent(RollNo);
        if (new1 != null)
        {
            new1.BatchCode = stu.BatchCode;
            new1.StudentName = stu.StudentName;
            new1.StudentAddress = stu.StudentAddress;
        }

    }
}
