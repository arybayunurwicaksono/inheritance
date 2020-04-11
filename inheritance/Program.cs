using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Arbync", 19);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Bambang", 36, "123123", "Physical Distancing");
            teacher.GetNameAndAge();

            Student student = new Student("Ary Ganteng", 16, "19.11.2762", "ary.bayunurw45@gmail.com");
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}
