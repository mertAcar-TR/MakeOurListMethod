using System;
using System.Text;

namespace MakeOurListMethod
{
    class MyList<T>
    {
        T[] items; // T can be everything like int,string,etc.
        public MyList()
        {
            items = new T[0];
            //Everytime MyList<T> have been made new(),an new T array with 1 item is created.
        }
        public void Add(T addedItem)
        {
            T[] tempArray = items; //We don't wanna lose old references.
            items = new T[items.Length + 1];//+1 because we'll add new items.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
                //Give back what's mine :)
            }
            items[items.Length - 1] = addedItem; //-1 because,array's starts with 0(for index)
        }
        public int LenghtOfArray { get {return items.Length; }  } //We don't need set.
        public T[] ListItems { get { return items; } }
    }
}
