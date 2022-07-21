using System;

namespace Lesson2
{
    public class Plants
    {
        // Властивість Age = поле age з методами public get() і private set()
        // викликається в коді через геттер GetAge() і сеттер SetAge() 
        // var somePlant = new Plants();
        // 
        public int Age
        { get; private set; }

        public int height;
        public bool isEdible;
    }   
}