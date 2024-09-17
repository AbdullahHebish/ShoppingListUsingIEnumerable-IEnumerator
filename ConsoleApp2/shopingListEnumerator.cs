using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class shopingListEnumerator : IEnumerator//person who go shopping
    {   
        private string[]_list;
        private int _position=-1;
        public shopingListEnumerator(string[] list)
        {
            _list = list;
        }
        public object Current
        {
            get
            {
              return _list[_position];
            }
        }

        public bool MoveNext()
        {
            _position++;
            if (_position < _list.Length)
            {
                return true;
            }
            else { return false; }
        }

        public void Reset()
        {
            _position = -1;
        }
    }
}
