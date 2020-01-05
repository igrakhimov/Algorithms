using System;
using System.Collections;

namespace Algorithms
{
    public class Collection : CollectionBase
    {
        public void Add(Object item)
        {
            InnerList.Add(item);
        }

        public void Remove(Object item)
        {
            InnerList.Remove(item);
        }

        public new void Clear()
        {
            InnerList.Clear();
        }

        public new int Count()
        {
            return InnerList.Count;
        }
    }

}
