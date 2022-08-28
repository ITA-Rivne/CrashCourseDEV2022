using System;
using System.Text;
using System.Collections.Generic;

namespace Task_301
{
    class Person
    {
        string firstname, lastname, gender, tel;
        int age;
        
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

        public int Age
        {
            set => age = value;
            get => age;
        }

        public Person()
        {
            firstname = "";
            lastname = "";
            gender = "";
            tel = "";
            age = 0;
        }
        public Person(string firstname, string lastname, int age, string gender, string tel)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gender;
            this.tel = tel;
            this.age = age;
        }
        public void SetFirstName(string firstname)
        {
            this.firstname = firstname;
        }

        public void SetLastName(string lastname)
        {
            this.lastname = lastname;
        }

        public void SetGender()
        {
            this.gender = gender;
        }
        public void SetTel()
        {
            this.tel = tel;
        }

        public void SetAge()
        {
            this.age = age;
        }
        public void Print()
        {
            Console.WriteLine(firstname + " " + lastname + " " + age + " " + gender + " " + tel);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string firstname, lastname, gender, tel;
            int age;

            Console.OutputEncoding = Encoding.UTF8; 

            Person person = new Person("Саша", "Ковальчук", 25, "чоловік", "050-123-45-67");
            person.Print();

            List<Person> persons = new List<Person>();

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Введіть ім'я ");
                firstname = Console.ReadLine();
                Console.WriteLine("Введіть прізвище ");
                lastname = Console.ReadLine();
                Console.WriteLine("Введіть скільки повних років ");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введіть стать");
                gender = Console.ReadLine();
                Console.WriteLine("Введіть номер телефону");
                tel = Console.ReadLine();

                persons.Add(new Person(firstname, lastname, age, gender, tel));
            }

            foreach(Person p in persons)
            {
                p.Print();
            }
        }
    }
}
