using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
  public  class Student
    {
        private string name; // Прізвище та ім'я
        private int course; // Курс
        private string numberBook; // Номер залікової книжки
        private string phone;

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
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Course
        {
            get { return course; }
            set { course = value; }
        }

        public string NumberBook
        {
            get { return numberBook; }
            set { numberBook = value; }
        }
        public void infoPrint()
        {
           Console.WriteLine($"Name = {name}");
           Console.WriteLine($"Course = {course}");
           Console.WriteLine($"namberBook = {numberBook}");
        }


    }

}
