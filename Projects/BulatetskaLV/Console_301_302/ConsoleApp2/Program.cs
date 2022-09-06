using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("Semenyuk Stepan", 2, "11111111");

            st.infoPrint();

            Aspirant a=new Aspirant("Semenyuk Olena", 1, "1222222", "Database");
            a.infoPrint();
            Console.ReadLine();

            Person p= new Person("Olena", 10, "female", 121);
            p.Print();
            Console.ReadLine();
        }
    }
}
