using ConsoleApp2;
using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace testing
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            shopingList shopingList = new shopingList();
            foreach (var item in shopingList)
            {
                Console.WriteLine(item);
            }
        }
    }
}