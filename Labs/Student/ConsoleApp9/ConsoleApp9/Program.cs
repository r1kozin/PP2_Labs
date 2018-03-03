using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Student
    {
        public string name;
        public int age;
        public float gpa;

        public Student() 
        {
            name = "Rustam";
            age = 18;
            gpa = 4;
        }

        public Student(string n, int a, float g) 
        {
            name = n;
            age = a;
            gpa = g;
        }

        public override string ToString() 
        {
            return name + " " + age + " " + gpa;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(); 
            s.name = "aaa"; 
            Console.WriteLine(s);


            Student s2 = new Student("bbb", 18, 3); 
            Console.ReadKey();
        }
    }
}
}
