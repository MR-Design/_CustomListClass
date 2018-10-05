using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CList <T>
    {
        T[] Input;
        private int count;
        private int capacity = 4;

        public T this[int i]
        {
            get { return Input[i]; }
            set { Input[i] = value; }
        }
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                //count = value;
            }
        }

        public void CustomList()
        {
            Input = new T[capacity];
        }

        public void Add_OLD(T value)
        {
            //temp array
            //loop
            //count++

            //if space


            //else 
            //make space then add
            T[] temp = new T[Input.Length + 1];

            for (int i = 0; i < count; i++)
            {
                temp[i] = Input[i];
            }

            temp[count] = value;
            count++;
            Input = temp;
        }

        ///////////////////ADD////////////////////////
        public void Add(T value)
        {

            if (count == capacity)
            {
                T[] temp = new T[capacity * 2];
                for (int i = 0; i < count; i++)
                {
                    temp[i] = Input[i];
                }

                temp[count] = value;
                count++;
                Input = temp;
            }
            else
            {


                Input[count] = value;
                count++;

            }


        }

        public void Remove(T valueToRemove)
        {

        }

    }
}
}
