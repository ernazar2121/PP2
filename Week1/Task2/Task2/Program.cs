
using System;

namespace Task2
{
    class Student
    {
        public string name;
        public string id;
        public int yos;
    }
    class Program
    {
        static void Main(string[] args)
        {
                Student s = new Student();
                s.name = Convert.ToString(Console.ReadLine());
                s.id = Convert.ToString(Console.ReadLine());
                s.yos = int.Parse(Console.ReadLine());
                Console.Write(s.name + " " + s.id + " " + "year_of_study:" +" " +s.yos+" ");
            Console.WriteLine("Next_year_of_study" + " " + (s.yos + 1));
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}