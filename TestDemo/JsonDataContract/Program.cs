using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;

namespace JsonDataContract
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentClasses c = new StudentClasses();
            c.className = "语文";
            c.classTeacher = "gq";

            Student s = new Student();
            s.age = 16;
            s.name = "qq";
            s.score = 100;
            s.stuClasses = new List<StudentClasses>();
            s.stuClasses.Add(c);


            JsonSer<Student> js = new JsonSer<Student>();
            string ss = js.SerJson(s);
            Console.WriteLine(ss);


             Student p2 = (Student)js.DeSerJson(ss);
           
            Console.WriteLine(p2.name+p2.age+p2.score);
            Console.WriteLine(p2.stuClasses[0].className + p2.stuClasses[0].classTeacher);

            Console.Read();


        }
    }
}
