using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Student
    {
        private static int Id;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Point { get; set; }
        public bool isExist;
        public Student()
        {
            Id++;
        }
        public Student(string name, string surname, int age, int point):this()
        {
            if (name==""|| name==" " || surname=="" || surname==" " || point==0)
            {
                Console.WriteLine("No Student");
                isExist = true;
                return;
            }
            else
            {
                Name = name;
                Surname = surname;
                Age = age;
                Point = point;
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"ID: {Id}  Name: {Name}  Surname: {Surname}  Age: {Age}  Point: {Point}");
        }
    }
}
