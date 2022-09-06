using System;
using System.Text;
using System.Collections.Generic;

namespace Task_302
{
    class Student
    {
        string firstname, lastname, gender, tel, group;
        DateTime birthday;

        public string FirstName
        {
            set => firstname = value;
            get => firstname;
        }

        public string LastName
        {
            set => lastname = value;
            get => lastname;
        }

        public string Gender
        {
            set => gender = value;
            get => gender;
        }

        public string Tel
        {
            set => tel = value;
            get => tel;
        }

        public DateTime Birthday
        {
            set => birthday = value;
            get => birthday;
        }

        public Student()
        {
            firstname = "";
            lastname = "";
            gender = "";
            tel = "";
            birthday = new DateTime();
        }
        public Student(string firstname, string lastname, DateTime birthday, string gender, string tel, string group)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gender;
            this.tel = tel;
            this.birthday = birthday;
            this.group = group;
        }
        
        public virtual void Print()
        {
            Console.WriteLine(firstname + " " + lastname + " " + birthday.ToShortDateString() + " " + gender + " " + tel + " " + group);
        }
    }

    class Aspiran : Student
    {
        string work_theme;
        public string Work_theme
        {
            set => work_theme = value;
            get => work_theme;
        }
        public Aspiran() : base() { }
        public Aspiran(string firstname, string lastname, DateTime birthday, string gender, string tel, string group) : base(firstname, lastname, birthday, gender, tel, group) { }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Тема роботи: " + work_theme);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string firstname, lastname, gender, tel;
            int age;

            Console.OutputEncoding = Encoding.UTF8;

            Student student = new Student("Саша", "Ковальчук", new DateTime(2000, 10,15), "чоловік", "050-123-45-67", "АВ-21");
            student.Print();

            Aspiran aspiran = new Aspiran("Коля", "Нікітін", new DateTime(1998, 10, 1), "чоловік", "066-222-59-00", "АВ");
            aspiran.Work_theme = "Навчання динамічних нейронних мереж на задачах довгострокового прогнозування";

            aspiran.Print();
        }
    }
}
