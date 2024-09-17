using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class shopingList : IEnumerable // list of shopping
    {
        string[] items = new string[3] { "bread", "beans", "fruits" };
        public IEnumerator GetEnumerator()
        {
            return new shopingListEnumerator(items);
        }
    }
}
