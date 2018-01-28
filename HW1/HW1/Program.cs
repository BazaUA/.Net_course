using System;
using System.Collections.Generic;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("vitaliy", 91, 89, 100);
            Student s2 = new Student("max", 100, 81, 87);
            Student s3 = new Student("olha", 71, 100, 91);
            Student s4 = new Student("gleb", 94, 100, 76);
            Student s5 = new Student("dmytro", 90, 100, 66);
            var students = new List<Student>();
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);
            students.Sort((student1, student2) => student2.getAvg().CompareTo(student1.getAvg()));
            foreach(Student s in students)
            {
                Console.WriteLine(s.ToString()+"\n--------------");
            }
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}
