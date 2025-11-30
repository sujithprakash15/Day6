using InstituteLibrary;
using System.Collections.Generic;

class Program
{
    static ICourseRepository courseinf = new CourseRepository();
    static IBatchRepository batchinf = new BatchRepository();
    static IStudentRepository studentinf = new StudentRepository();
    static void Main()
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
                        case 3: ViewCourse(); break;
                        case 4: UpdateCourse(); break;
                        case 5: DeleteCourse(); break;
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
                        case 2: ViewBatch(); break;
                        case 3: ViewBatches(); break;
                        case 4: UpdateBatch(); break;
                        case 5: DeleteBatch(); break;
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
                        case 2: ViewStudent(); break;
                        case 3: ViewStudents(); break;
                        case 4: UpdateStudent(); break;
                        case 5: DeleteStudent(); break;
                        case 6: goto MainMenu;
                    }
                }
            MainMenu:
                ;
            }

        }
    }

    //Student Down

    private static void DeleteStudent()
    {
        Console.WriteLine("Enter Student RollNo: ");
        int new3 = Convert.ToInt32(Console.ReadLine());
        try
        {
            Student value1 = studentinf.GetStudent(new3);
            Console.WriteLine($"Roll No: {value1.RollNo}, Batch Code: {value1.BatchCode}, Student Address: {value1.StudentAddress}, Student Name: {value1.StudentName}");
            studentinf.DeleteStudent(new3);
        }
        catch (InstituteException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Deleted Successfully");

    }

    private static void UpdateStudent()
    {
        Console.WriteLine("Enter Student RollNo: ");
        int new3 = Convert.ToInt32(Console.ReadLine());
        try
        {
            Student value1 = studentinf.GetStudent(new3);
            Console.WriteLine($"Roll No: {value1.RollNo}, Batch Code: {value1.BatchCode}, Student Address: {value1.StudentAddress}, Student Name: {value1.StudentName}");
            Console.WriteLine("Enter RollNo: ");
            value1.RollNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter StartDate: ");
            value1.StudentAddress = Console.ReadLine();

            Console.WriteLine("Enter EndDate: ");
            value1.StudentName = Console.ReadLine();

            studentinf.UpdateStudent(new3, value1);
        }
        catch (InstituteException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Student Details Updated");

    }

    private static void ViewStudents()
    {
        List<Student> stud = studentinf.GetAllStudents();
        foreach (Student stu in stud)
        {
            Console.WriteLine($"Roll No: {stu.RollNo}, Batch Code: {stu.BatchCode}, Student Address: {stu.StudentAddress}, Student Name: {stu.StudentName}");
        }
    }

    private static void ViewStudent()
    {
        Console.WriteLine("Enter Student RollNo: ");
        int new3 = Convert.ToInt32(Console.ReadLine());
        Student value1 = studentinf.GetStudent(new3);
        Console.WriteLine($"Roll No: {value1.RollNo}, Batch Code: {value1.BatchCode}, Student Address: {value1.StudentAddress}, Student Name: {value1.StudentName}");
        Console.WriteLine("Student Displayed");
    }

    private static void AddStudent()
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

    private static void DeleteBatch()
    {
        Console.WriteLine("Enter Batch ID: ");
        int new3 = Convert.ToInt32(Console.ReadLine());
        try
        {
            Batch value1 = batchinf.GetBatch(new3);
            Console.WriteLine($"Course ID: {value1.CourseCode}, Batch Code: {value1.BatchCode}, Course StartDate: {value1.StartDate}, Course EndStart: {value1.EndDate}");

            batchinf.DeleteBatch(new3);
        }
        catch (InstituteException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Batch Deleted");
    }

    private static void UpdateBatch()
    {
        Console.WriteLine("Enter Batch ID: ");
        int new3 = Convert.ToInt32(Console.ReadLine());
        try
        {
            Batch value1 = batchinf.GetBatch(new3);
            Console.WriteLine($"Course ID: {value1.CourseCode}, Batch Code: {value1.BatchCode}, Course StartDate: {value1.StartDate}, Course EndStart: {value1.EndDate}");


            Console.WriteLine("Enter Course ID: ");
            value1.CourseCode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter StartDate: ");
            value1.StartDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter EndDate: ");
            value1.EndDate = Convert.ToDateTime(Console.ReadLine());

            batchinf.UpdateBatch(new3, value1);
        }
        catch (InstituteException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Batch Updated");


    }

    private static void ViewBatches()
    {
        List<Batch> new1 = batchinf.GetAllBatches();
        foreach (Batch value1 in new1)
        {
            Console.WriteLine($"Course ID: {value1.CourseCode}, Batch Code: {value1.BatchCode}, Course StartDate: {value1.StartDate}, Course EndStart: {value1.EndDate}");
        }

        Console.WriteLine("Batches Displayed");
    }

    private static void ViewBatch()
    {
        Console.WriteLine("Enter Batch ID: ");
        int new3 = Convert.ToInt32(Console.ReadLine());
        Batch value1 = batchinf.GetBatch(new3);
        Console.WriteLine($"Course ID: {value1.CourseCode}, Batch Code: {value1.BatchCode}, Course StartDate: {value1.StartDate}, Course EndStart: {value1.EndDate}");
        Console.WriteLine("Batch Displayed");
    }

    private static void AddBatch()
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


    private static void DeleteCourse()
    {
        Console.WriteLine("Enter Course Id: ");
        int courid = Convert.ToInt32(Console.ReadLine());
        try
        {
            Course course1 = courseinf.GetCourse(courid);
            Console.WriteLine($"Course ID: {course1.CourseCode}, Course Title: {course1.CourseTitle}, Course Duration: {course1.CourseDuration}, Course Fee: {course1.CourseFee}");

            courseinf.DeleteCourse(courid);
        }
        catch (InstituteException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Course Deleted");

    }

    private static void UpdateCourse()
    {
        Console.WriteLine("Enter Course Id: ");
        int courid = Convert.ToInt32(Console.ReadLine());
        try
        {
            Course course1 = courseinf.GetCourse(courid);
            Console.WriteLine($"Course ID: {course1.CourseCode}, Course Title: {course1.CourseTitle}, Course Duration: {course1.CourseDuration}, Course Fee: {course1.CourseFee}");

            Console.WriteLine("Enter Course Title: ");
            course1.CourseTitle = Console.ReadLine();

            Console.WriteLine("Enter Course Duration: ");
            course1.CourseDuration = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Course CourseFee: ");
            course1.CourseFee = Convert.ToInt32(Console.ReadLine());

            courseinf.UpdateCourse(courid, course1);
        }
        catch (InstituteException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Course Updated");
    }

    private static void ViewCourse()
    {
        Console.WriteLine("Enter Course Id: ");
        int courid = Convert.ToInt32(Console.ReadLine());
        Course course1 = courseinf.GetCourse(courid);
        Console.WriteLine($"Course ID: {course1.CourseCode}, Course Title: {course1.CourseTitle}, Course Duration: {course1.CourseDuration}, Course Fee: {course1.CourseFee}");
    }

    private static void ViewCourses()
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
