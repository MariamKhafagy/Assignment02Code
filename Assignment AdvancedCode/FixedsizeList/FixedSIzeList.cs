using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_AdvancedCode.FixedsizeList
{
    #region Q.3
    //public class FixedSIzeList<T>
    //{
    //    private T[] items;
    //    private int count;
    //    private int capacity;

    //    public FixedSIzeList(int capacity)
    //    {
    //        if (capacity <= 0)
    //            throw new ArgumentException("Capacity Must be Greater than Zero");

    //        this.capacity=capacity;
    //        items=new T[capacity];
    //        count=0;

    //    }

    //    public void Add(T item)
    //    {
    //        if (count >= capacity)
    //            throw new InvalidOperationException($"List is full . Maximim Capacity is {capacity}");

    //        items[count++] = item;  
    //        count++;
    //    }
    //    public T Get(int index)
    //    {
    //        if (index < 0 || index >= count)
    //            throw new IndexOutOfRangeException($"Index {index} is out of Range ");
    //        return items[index];
    //    }

    //    public int Count => count;
    //    public int Capacity => capacity;    


    //}
    #endregion

}
