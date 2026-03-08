using System;
class Student
{
    public string Name;
    public float Marks;
    public Student()
    {
        Name = "Unknown";
        Marks = 0;
    }
    public Student(Student s)
    {
        Name = s.Name;
        Marks = s.Marks;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.Name = "Ali";
        s1.Marks = 85;
        Student s2 = new Student(s1);
        s2.Name = "Ahmed";
        Console.WriteLine("Student 1 Name : " + s1.Name);
        Console.WriteLine("Student 2 Name : " + s2.Name);
    }
}