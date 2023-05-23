using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class SortList<T> : List<T>
    {
        public new void Add(T item)
        {
            int index = BinarySearch(item);
            if (index < 0)
                index = ~index;
            base.Insert(index, item);
        }

        private int BinarySearch(T item)
        {
            return BinarySearch(0, Count, item, Comparer<T>.Default);
        }
    }

}
