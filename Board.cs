using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class MyList<T>
    {
        const int DEFAULT_SIZE = 1;
        T[] items = new T[DEFAULT_SIZE];

        public int Count = 0;
        public int Capacity { get { return items.Length; } }

        // O(1)
        public void Add(T item)
        {
            if (Count >= Capacity)
            {
                T[] newArray = new T[Count * 2];
                for (int i = 0; i < Count; ++i)
                {
                    newArray[i] = items[i];
                }
                items = newArray;
            }

            items[Count] = item;
            ++Count;
        }

        // O(1)
        public T this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }
        }

        // O(N)
        public void RemoveAt(int index)
        {
            for (int i = index; i < Count - 1; ++i)
            {
                items[i] = items[i + 1];
            }
            items[Count - 1] = default;
            --Count;
        }
    }

    class Board
    {
        public int[] _data = new int[25];
        public MyList<int> _data2 = new MyList<int>();
        public LinkedList<int> _data3 = new LinkedList<int>();

        public void Initialize()
        {
            _data2.Add(101);
            _data2.Add(102);
            _data2.Add(103);
            _data2.Add(104);
            _data2.Add(105);

            int temp = _data2[2];

            _data2.RemoveAt(2);
        }
    }
}
 