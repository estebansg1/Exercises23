public static class StudentCollection
{
    public static List<Student> GetAllStudents()
    {
        List<Student> students = new List<Student>();

        students.Add(new Student { Name = "Jhon", SchoolNumber = 1001 });
        students.Add(new Student { Name = "Bob", SchoolNumber = 1002 });
        students.Add(new Student { Name = "Alice", SchoolNumber = 1003 });

        return students;
    }
} 