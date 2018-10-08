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
        ////// NEED To Inderstand This !!!///////
      //// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/yield
        //public int CompareTo(T other)
        //{
        //    throw new NotImplementedException();
        //}
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
               // return (IEnumerator) GetEnumerator();
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
                T[] temp = new T[Capacity * 2];
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



        //public int IndexOf(T value)
        //{
        //    int itemIndex = -1;
        //    for (int i = 0; i < Count; i++)
        //    {
        //        if ( Input[i] == value)
        //        {
        //            itemIndex = i;
        //            break;
        //        }
        //    }
        //    return itemIndex;
        //}

        public void Remove(T value)
        {
            T[] temp = new T[Capacity];
            for (int i = 0; i < count; i++)
            {
                if (Input[i].Equals(value))
                {
                    temp[i] = temp[i + 1];
                    count--;
                    return;
                }
                else
                {
                    Input = temp;
                }
             }
            Input = temp;
        }


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


        // overload operator +
      
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

        // overload operator -

        

        public static CList<T> operator -(CList<T> x, CList<T> y)
        {
            CList<T> Fraction = new CList<T>();
            for (int i = 0; i <= x.Count - 1; i++)
            {
                for (int j = 0; i <= y.Count - 1; j++)
                    if (i == j)
                    {    Fraction.Remove(x[i]);
                         return Fraction;
                    }
            }

            return Fraction;
        }

        public static CList<T> operator *(CList<T> x, CList<T> y)
        {
            CList<T> Fraction = new CList<T>();


            return Fraction;
        }
            //  public void Zip(T value)
            //  {              
            //  }



            //public void CustomList()
            //{
            //    Input = new T[Capacity];
            //}
            //public void Add_OLD(T value)
            //{
            //    //temp array
            //    //loop
            //    //count++

            //    //if space


            //    //else 
            //    //make space then add
            //    T[] temp = new T[Input.Length + 1];

            //    for (int i = 0; i < count; i++)
            //    {
            //        temp[i] = Input[i];
            //    }

            //    temp[count] = value;
            //    count++;
            //    Input = temp;
            //}

            // Must also implement IEnumerable.GetEnumerator, but implement as a private method.
            // Must also implement IEnumerable.GetEnumerator, but implement as a private method.
            //private IEnumerator GetEnumerator1()
            //{
            //    return this.GetEnumerator();
            //}
            //IEnumerator IEnumerable.GetEnumerator()
            //{
            //    return GetEnumerator1();
            //}

        }
}

