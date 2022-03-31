using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Group : Student
    {
        public string name { get; set; }

        private  string GroupNo { get; }
        private static int No = 201;
        public Student[] studentArr;
        public Group()
        {
        }
        public Group(string name, string surname, int age, int point) :base(name, surname, age, point)
        {
            No++;
            GroupNo = $"BP{No}";
        }
        public void AddStudent(Student newstudent)
        {
            Array.Resize(ref studentArr, studentArr.Length+1);
            studentArr[studentArr.Length - 1] = newstudent;
            Console.WriteLine(studentArr);
        }
        public Student[] GetAllStudents()
        {
            return studentArr;
        }
        public StringBuilder Sort()
        {
            StringBuilder sortedStudents = new StringBuilder();
            for (int i = 0; i < studentArr.Length; i++)
            {
                if (studentArr[i].Point > studentArr[i+1].Point)
                {
                    sortedStudents.Append(i);
                }
            }
            return sortedStudents;
        }

    }
}
