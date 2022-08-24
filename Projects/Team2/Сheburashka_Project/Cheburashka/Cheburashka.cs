using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheburashka
{
    class Cheburashka : IToy, IPerson
    {
        public string Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float Height { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int GetWork(string work, int count)
        {
            throw new NotImplementedException();
        }

        public void Say()
        {
            throw new NotImplementedException();
        }
    }
}
