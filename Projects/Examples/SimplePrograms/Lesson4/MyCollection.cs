using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson4
{

    class MyCollection : IEnumerable, IEnumerator
    {
        string[] strArray = { "Hello world!", "Hello world!1", "Hello world!2", "Hello world!3" };
        int index = -1;

        //Реалізація інтерфейсу IEnumerable
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        //Реалізація інтерфейсу IEnumerator
        public bool MoveNext()
        {
            if (index == strArray.Length - 1)
            {
                Reset();
                return false;
            }

            index++;
            return true;
        }

        public void Reset()
        {
            index = -1;
        }

        public object Current
        {
            get
            {
                return strArray[index];
            }
        }
    }
}