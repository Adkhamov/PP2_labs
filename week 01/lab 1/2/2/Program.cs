using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.cs
{
    class Student
    {
        public string name;
        public string sname;
        public int age;
        public double gpa;
        public int course;
        public string department;

        public Student()
        {
            name = "Adkhamov";
            sname = "Askhat";
            department = "FIT";
            age = 18;
            course = 1;
            gpa = 4;
        }
        public Student(string n, string s, string d, int a, int c, double g)
        {
            name = n;
            sname = s;
            department = d;
            age = a;
            course = c;
            gpa = g;
        }
        public override string ToString()
        {
            return "name: " + name + "\nsname: " + sname + "\ndepartment: " + department + "\ncourse: " + course + "\nage: " + age + "\nGPA: " + gpa;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write name, surname, department, course, age, gpa, Please.");
            string st = Console.ReadLine();
            string[] st0 = st.Split(' ');
            string n, s, d;
            int a, c;
            double g;
            n = st0[0];
            s = st0[1];
            d = st0[2];
            a = int.Parse(st0[3]);
            c = int.Parse(st0[4]);
            g = int.Parse(st0[5]);
            
            Student st1 = new Student();
            Console.WriteLine("DEFAULD:\n" + st1);
            Student st2 = new Student(n, s, d, c, a, g);
            Console.WriteLine("YOUR:\n" + st2);
            Console.WriteLine("\n Press button");
            Console.ReadKey();
        }
    }
}
