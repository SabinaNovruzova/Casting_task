using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student();
            Person stu2 = new Student();
            Person teach1 = new Teacher();
            stu2.Name = "Sebine";
            stu2.Surname = "Novruzova";
            stu2.Age = 21;
            teach1.ShowInfo();
        }
        abstract class Person
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }
            public int Id { get; set; }
            public Person()
            {
                Id++;
            }
            public abstract void ShowInfo();
        }
        class Student:Person
        {
            public int Point { get; set; }
            public Student()
            {
                Id++;
            }
            public Student(int Point)
            {
                this.Point = Point;
            }
            public static bool operator >(Student s1,Student s2)
            {
                return s1.Point > s2.Point;
            }
            public static bool operator <(Student s1, Student s2)
            {
                return s1.Point < s2.Point;
            }
            public override void ShowInfo()
            {
                Console.WriteLine($"Id:{Id} Name:{Name} Surname:{Surname} Age:{Age}");
            }
        }
        class Teacher:Person
        {
            public int Salary { get; set; }
            public static bool operator >(Teacher t1, Teacher t2)
        {
            return t1.Salary > t2.Salary;
        }
        public static bool operator <(Teacher t1, Teacher t2)
        {
            return t1.Salary < t2.Salary;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Id:{Id} Name:{Name} Surname:{Surname} Age:{Age}");
        }
        }
    }
}
