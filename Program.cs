using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group();
            group.AddStudent(new Student("elnare", "semedova", 19, 1000));
            group.AddStudent(new Student("elnare", "semedova", 19, 1));
            group.AddStudent(new Student("elnare", "semedova", 19, 2));
            group.Sort();


        }
    }
}