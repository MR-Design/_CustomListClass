using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomList
{
    public class CList <T>: IEnumerable<T>//, IComparable<T>
    {
      //// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/yield

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return this[i];
               // yield return Input;
            }
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                 yield return this[i];
                //Input[i] = [i];
            }
        }

        T[] Input;
        private int count;
        public int Capacity { get; set; }

        public CList()
        {
            Capacity = 4;
            Input = new T[Capacity];
        }
        
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
        }
        public void Add(T value)
        {
            if (count >= Capacity)
            {
                T[] temp = new T[Capacity *= 2];
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

        public void Remove(T value)
        {
            T[] temp = new T[Capacity];
            for (int i = 0; i < count; i++)
            {
                if (Input[i].Equals(value))
                {
                    temp[i] = temp[i + 1];
                    count--;                                      
                }
             }
            Input = temp;
        }

        // OR 
        //public void Remove(T value)
        //{
        //    T[] temp = new T[Capacity];
        //    for (int i = 0; i < count; i++)
        //    {
        //        if (!Input[i].Equals(value))
        //        {
        //            temp[i] = Input[i];

        //            count--;

        //        }
        //    }
        //    Input = temp;
        //}

        //I want to be able to override the ToString method that converts the contents of the custom list to a string.
        public override String ToString()
        {
            String NewStrValue = String.Empty;
            foreach (T Input in this)
            {
                if (String.IsNullOrEmpty(NewStrValue))
                    NewStrValue += Input.ToString();
                else
                    NewStrValue += String.Format(", {0}", Input);
            }
            return NewStrValue;
        }   
        public static CList<T>  operator + (CList<T> x, CList<T> y)
        {
            CList<T> Fraction = new CList<T>();
            for (int i = 0; i <= x.Count-1; i++)
            {
                Fraction.Add(x[i]);
           
            }
            for (int i = 0; i <= y.Count - 1; i++)
            {
                Fraction.Add(y[i]);
               
            }
            return  Fraction;
        }

        public static CList<T> operator -(CList<T> x, CList<T> y)
        {
            CList<T> Fraction = new CList<T>();

            for (int i = 0; i <= x.Count - 1; i++)
            {
                for (int j = 0; j <= y.Count - 1; j++)
                    if (!x[i].Equals(y[j]))
                    {
                        Fraction.Add(x[i]);
                    }
            }        
            return Fraction;
        }
        public void Zip(T value)
        {
        }       
    }
}

