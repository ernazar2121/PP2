
using System;

namespace Ex6
{
    class Student
    {
        public string name;
        public string surname;
        public int yos;

        public Student()
        {

            name = Console.ReadLine();
            surname = Console.ReadLine();
            yos = int.Parse(Console.ReadLine());
        }
        public Student(string name, string surname, int yos)
        {
            this.name = name;
            this.surname = surname;
            this.yos = yos;
        }



        public override string ToString()
        {
            return name + " " + surname + " " + yos;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student Erna = new Student("Ernazar", "Idrissov", 4);
            Console.WriteLine(Erna);
            Console.WriteLine("Erna next yos:" + (Erna.yos + 1));
            Console.ReadKey();

        }
    }
}