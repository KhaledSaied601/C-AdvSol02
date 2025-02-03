using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_AdvAss02
{
    internal class FixedSizeList<T>
    {
        public int Size { get;  }

        List<T> list;
        public FixedSizeList(int size)
        {
            Size = size;
            list = new List<T>(Size);
            
        }

        public void Add(T item) 
        {


            if (list.Count < Size) list.Add(item);
            else throw new ArgumentException("Out of index");

        }
        public T GetValue(int index)
        {

            if (index >= 0 && index < Size) return list[index];
            else throw new ArgumentException("Out of Index");
            
        }


    }
}
