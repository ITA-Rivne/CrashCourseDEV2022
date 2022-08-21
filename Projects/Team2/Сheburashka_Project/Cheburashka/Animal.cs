using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheburashka
{
    class Animal : IPerson
    {
        private string _name;
        public int weight;
        public static Random random = new Random();

        public Animal(string name, int weight)
        {
            this._name = name;
            this.weight = weight;
        }
        public Animal(string name)
        {
            this._name = name;
            this.weight = random.Next(1, 10);
        }


        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public void GetWork(string work, int count)
        {
            throw new NotImplementedException();
        }

        public string Say()
        {
            throw new NotImplementedException();
        }
    }
}
