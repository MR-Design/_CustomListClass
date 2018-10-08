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
            CList<int> customList = new CList<int>();
            int value1 = 10;
            int value2 = 20;
            int value3 = 30;

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);

            customList.Remove(value2);
        }
    }
}
