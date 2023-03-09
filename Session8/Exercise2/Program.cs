using System;

public class Person
{

    public int age;
    public void SetAge(int n)
    {
        age = n;
    }
    public void Greet()
    {
        Console.WriteLine("Person: Hello!");
    }
}

public class Student : Person
{
    public void GoToClasses()
    {
        Console.WriteLine("Student: I'm going to class.");
    }

    public void ShowAge()
    {
        Console.WriteLine("Student: My age is " + age + " years old");
    }
}

public class Teacher : Person
{
    public void Explain()
    {
        Console.WriteLine("Teacher: Explanation begins.");
    }
}

public class StudentAndTeacherTest
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.Greet();

        Student student = new Student();
        student.SetAge(21);
        student.Greet();
        student.ShowAge();
        student.GoToClasses();

        Teacher teacher = new Teacher();
        teacher.SetAge(30);
        teacher.Greet();
        teacher.Explain();
    }
}
