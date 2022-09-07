using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
  public  class Aspirant : Student
    {
        public string scientificTopic;// Тема роботи
        public int workPersent; // відсоток готовності роботи

        public Aspirant (string name, int course, string numberBook) : base(name, course, numberBook)
        { }
        public Aspirant(string name, int course, string numberBook, string scientificTopic) : base(name, course, numberBook)
        { }

        public new void infoPrint() 
        {
            base.infoPrint(); 
            Console.WriteLine($"scientificTopic = {scientificTopic}");
            Console.WriteLine($"workPersent = {workPersent} %");
           
        }
    }
}
