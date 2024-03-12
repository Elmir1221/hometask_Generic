using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalist_remove
{
    internal class Stringlist
    {
        private string[] intArray;

        public Stringlist()
        {
            intArray = Array.Empty<string>();
        }
        public void Add(string num)
        {
            Array.Resize(ref intArray, intArray.Length + 1);
            intArray[intArray.Length - 1] = num;

        }

        public string[] GetAll()
        {
            return intArray;
        }
    }
}
