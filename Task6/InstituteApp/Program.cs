using InstituteLibrary;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static ICourseRepository courseinf = new CourseRepository();
    static IBatchRepository batchinf = new BatchRepository();
    static IStudentRepository studentinf = new StudentRepository();
    static async Task Main()
    {
        while (true)
        {
            Console.WriteLine("------------");
            Console.WriteLine("----MENU----");
            Console.WriteLine("------------");
            Console.WriteLine("Enter your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                while (true)
                {
                    Console.WriteLine("1. Add Course\n2. View Courses\n13. View Course\n4. Update Course\n5. Delete Course\n6. Quit");
                    Console.WriteLine("Enter your Choice For Course: ");
                    int choicecourse = Convert.ToInt32(Console.ReadLine());
                    switch (choicecourse)
                    {
                        case 1: AddCourse(); break;
                        case 2: ViewCourses(); break;
                        case 3: await ViewCourse(); break;
                        case 4: await UpdateCourse(); break;
                        case 5: await DeleteCourse(); break;
                        case 6: goto MainMenu;
                    }
                }
            MainMenu:
                ;
            }
            else if (choice == 2)
            {
                while (true)
                {
                    Console.WriteLine("1. Add Batch\n2. View Batch\n3. View Batches\n4. Update Batch\n5. Delete Batch\n6. Quit");
                    Console.WriteLine("Enter your Choice For Batch: ");
                    int choicebatch = Convert.ToInt32(Console.ReadLine());
                    switch (choicebatch)
                    {
                        case 1: AddBatch(); break;
                        case 2: await ViewBatch(); break;
                        case 3: ViewBatches(); break;
                        case 4: await UpdateBatch(); break;
                        case 5: await DeleteBatch(); break;
                        case 6: goto MainMenu;
                    }
                }
            MainMenu:
                ;
            }
            else if (choice == 3)
            {
                while (true)
                {
                    Console.WriteLine("1. Add Student\n2. View Student\n3. View Students\n4. Update Student\n5. Delete Student\n6. Quit");
                    Console.WriteLine("Enter your Choice For Student: ");
                    int choicebatch = Convert.ToInt32(Console.ReadLine());
                    switch (choicebatch)
                    {
                        case 1: AddStudent(); break;
                        case 2: await ViewStudent(); break;
                        case 3: ViewStudents(); break;
                        case 4: await UpdateStudent(); break;
                        case 5: await DeleteStudent(); break;
                        case 6: goto MainMenu;
                    }
                }
            MainMenu:
                ;
            }

        }
    }

    //Student Down

    private static async Task DeleteStudent()
    {
        Console.WriteLine("Enter Student RollNo: ");
        int new3 = Convert.ToInt32(Console.ReadLine());
        try
        {
            Student value1 = await studentinf.GetStudent(new3);
            Console.WriteLine($"Roll No: {value1.RollNo}, Batch Code: {value1.BatchCode}, Student Address: {value1.StudentAddress}, Student Name: {value1.StudentName}");
            await studentinf.DeleteStudent(new3);
        }
        catch (InstituteException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Deleted Successfully");

    }

    private static async Task UpdateStudent()
    {
        Console.WriteLine("Enter Student RollNo: ");
        int new3 = Convert.ToInt32(Console.ReadLine());
        try
        {
            Student value1 = await studentinf.GetStudent(new3);
            Console.WriteLine($"Roll No: {value1.RollNo}, Batch Code: {value1.BatchCode}, Student Address: {value1.StudentAddress}, Student Name: {value1.StudentName}");
            Console.WriteLine("Enter RollNo: ");
            value1.RollNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter StartDate: ");
            value1.StudentAddress = Console.ReadLine();

            Console.WriteLine("Enter EndDate: ");
            value1.StudentName = Console.ReadLine();

           await studentinf.UpdateStudent(new3, value1);
        }
        catch (InstituteException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Student Details Updated");

    }

    private static async Task ViewStudents()
    {
        List<Student> stud = studentinf.GetAllStudents();
        foreach (Student stu in stud)
        {
            Console.WriteLine($"Roll No: {stu.RollNo}, Batch Code: {stu.BatchCode}, Student Address: {stu.StudentAddress}, Student Name: {stu.StudentName}");
        }
    }

    private static async Task ViewStudent()
    {
        Console.WriteLine("Enter Student RollNo: ");
        int new3 = Convert.ToInt32(Console.ReadLine());
        Student value1 = await studentinf.GetStudent(new3);
        Console.WriteLine($"Roll No: {value1.RollNo}, Batch Code: {value1.BatchCode}, Student Address: {value1.StudentAddress}, Student Name: {value1.StudentName}");
        Console.WriteLine("Student Displayed");
    }

    private static async Task AddStudent()
    {
        Student new1 = new Student();
        Console.WriteLine("Enter Batch Code: ");
        new1.BatchCode = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter RollNo: ");
        new1.RollNo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter StartDate: ");
        new1.StudentAddress = Console.ReadLine();

        Console.WriteLine("Enter EndDate: ");
        new1.StudentName = Console.ReadLine();

        studentinf.AddStudent(new1);

        Console.WriteLine("Student Added");

    }


    //Batch Down

    private static async Task DeleteBatch()
    {
        Console.WriteLine("Enter Batch ID: ");
        int new3 = Convert.ToInt32(Console.ReadLine());
        try
        {
            Batch value1 = await batchinf.GetBatch(new3);
            Console.WriteLine($"Course ID: {value1.CourseCode}, Batch Code: {value1.BatchCode}, Course StartDate: {value1.StartDate}, Course EndStart: {value1.EndDate}");

            await batchinf.DeleteBatch(new3);
        }
        catch (InstituteException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Batch Deleted");
    }

    private static async Task UpdateBatch()
    {
        Console.WriteLine("Enter Batch ID: ");
        int new3 = Convert.ToInt32(Console.ReadLine());
        try
        {
            Batch value1 = await batchinf.GetBatch(new3);
            Console.WriteLine($"Course ID: {value1.CourseCode}, Batch Code: {value1.BatchCode}, Course StartDate: {value1.StartDate}, Course EndStart: {value1.EndDate}");


            Console.WriteLine("Enter Course ID: ");
            value1.CourseCode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter StartDate: ");
            value1.StartDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter EndDate: ");
            value1.EndDate = Convert.ToDateTime(Console.ReadLine());

            await batchinf.UpdateBatch(new3, value1);
        }
        catch (InstituteException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Batch Updated");


    }

    private static async Task ViewBatches()
    {
        List<Batch> new1 = batchinf.GetAllBatches();
        foreach (Batch value1 in new1)
        {
            Console.WriteLine($"Course ID: {value1.CourseCode}, Batch Code: {value1.BatchCode}, Course StartDate: {value1.StartDate}, Course EndStart: {value1.EndDate}");
        }

        Console.WriteLine("Batches Displayed");
    }

    private static async Task ViewBatch()
    {
        Console.WriteLine("Enter Batch ID: ");
        int new3 = Convert.ToInt32(Console.ReadLine());
        Batch value1 = await batchinf.GetBatch(new3);
        Console.WriteLine($"Course ID: {value1.CourseCode}, Batch Code: {value1.BatchCode}, Course StartDate: {value1.StartDate}, Course EndStart: {value1.EndDate}");
        Console.WriteLine("Batch Displayed");
    }

    private static async Task AddBatch()
    {
        Batch new1 = new Batch();
        Console.WriteLine("Enter Batch ID: ");
        new1.BatchCode = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Course ID: ");
        new1.CourseCode = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter StartDate: ");
        new1.StartDate = Convert.ToDateTime(Console.ReadLine());

        Console.WriteLine("Enter EndDate: ");
        new1.EndDate = Convert.ToDateTime(Console.ReadLine());

        batchinf.AddBatch(new1);

        Console.WriteLine("Batch Added");


    }


    //Courses Down


    private static async Task DeleteCourse()
    {
        Console.WriteLine("Enter Course Id: ");
        int courid = Convert.ToInt32(Console.ReadLine());
        try
        {
            Course course1 = await courseinf.GetCourse(courid);
            Console.WriteLine($"Course ID: {course1.CourseCode}, Course Title: {course1.CourseTitle}, Course Duration: {course1.CourseDuration}, Course Fee: {course1.CourseFee}");

            await courseinf.DeleteCourse(courid);
        }
        catch (InstituteException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Course Deleted");

    }

    private static async Task UpdateCourse()
    {
        Console.WriteLine("Enter Course Id: ");
        int courid = Convert.ToInt32(Console.ReadLine());
        try
        {
            Course course1 = await courseinf.GetCourse(courid);
            Console.WriteLine($"Course ID: {course1.CourseCode}, Course Title: {course1.CourseTitle}, Course Duration: {course1.CourseDuration}, Course Fee: {course1.CourseFee}");

            Console.WriteLine("Enter Course Title: ");
            course1.CourseTitle = Console.ReadLine();

            Console.WriteLine("Enter Course Duration: ");
            course1.CourseDuration = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Course CourseFee: ");
            course1.CourseFee = Convert.ToInt32(Console.ReadLine());

            await courseinf.UpdateCourse(courid, course1);
        }
        catch (InstituteException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Course Updated");
    }

    private static async Task ViewCourse()
    {
        Console.WriteLine("Enter Course Id: ");
        int courid = Convert.ToInt32(Console.ReadLine());
        Course course1 = await courseinf.GetCourse(courid);
        Console.WriteLine($"Course ID: {course1.CourseCode}, Course Title: {course1.CourseTitle}, Course Duration: {course1.CourseDuration}, Course Fee: {course1.CourseFee}");
    }

    private static async Task ViewCourses()
    {
        List<Course> new1 = courseinf.GetAllCourse();
        foreach (Course value1 in new1)
        {
            Console.WriteLine($"Course ID: {value1.CourseCode}, Course Title: {value1.CourseTitle}, Course Duration: {value1.CourseDuration}, Course Fee: {value1.CourseFee}");
        }

        Console.WriteLine("Courses Displayed");
    }

    private static void AddCourse()
    {
        Course cour = new Course();
        Console.WriteLine("Enter Course Id: ");
        cour.CourseCode = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Course Title: ");
        cour.CourseTitle = Console.ReadLine();

        Console.WriteLine("Enter Course Duration: ");
        cour.CourseDuration = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Course CourseFee: ");
        cour.CourseFee = Convert.ToInt32(Console.ReadLine());

        courseinf.AddCourse(cour);

        Console.WriteLine("Course Added");


    }
}
