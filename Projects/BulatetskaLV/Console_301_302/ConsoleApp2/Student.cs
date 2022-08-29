using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
  public  class Student
    {
        public string name; // Прізвище та ім'я
        public int course; // Курс
        public string numberBook; // Номер залікової книжки
        public string phone;

        public Student(string name, int course, string numberBook)
        {
            this.name = name;
            this.course = course;
            this.numberBook = numberBook;
        }
        public Student(string name, int course, string numberBook, string phone)
        {
            this.name = name;
            this.course = course;
            this.numberBook = numberBook;
            this.phone = phone;
        }
        public Student(string name, string numberBook)
        {
            this.name = name;
            this.course = 1;
            this.numberBook = numberBook;
        }

        public void infoPrint()
        {
           Console.WriteLine($"Name = {name}");
            Console.WriteLine($"Course = {course}");
            Console.WriteLine($"namberBook = {numberBook}");
        }


    }

}
