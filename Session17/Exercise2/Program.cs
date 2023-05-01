List<Student> students = StudentCollection.GetAllStudents();

foreach (Student student in students)
{
    Console.WriteLine("Name: {0} (SchoolNumber: {1})", student.Name, student.SchoolNumber);
}