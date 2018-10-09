using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CList<int> List1 = new CList<int>() { 10, 20, 30 };
            CList<int> List2 = new CList<int>() { 30, 20, 60 };
            CList<int> expected = new CList<int>() { 10 };

            CList<int> actual;

            actual = List1 - List2;
            int Count = 2;
            int expectedResult = Count;

            // act
        }
    }
}
