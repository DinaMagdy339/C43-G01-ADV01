using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign01advan
{
    internal class FixedSizeList<T> : List<T>
    {
        #region Attribute
        public int Capacity { get; }
        private readonly T[] values;
        private int count; 
        #endregion

        #region constructor
        public FixedSizeList(int capacity)
        {
            Capacity = capacity;
            values = new T[capacity];
            count = 0;
        }

        #endregion

        #region Add function
        public void Add(T value)
        {
            if (count >= Capacity)
            {
                Console.WriteLine("The list is full");
            }
            values[count] = value;
            count++;
        } 
        #endregion

        #region Get function
        public T Get(int index)
        {
            if (index < 0 || index >= count)
            {
                Console.WriteLine("Index is out of range.");
            }
            return values[index];
        } 
        #endregion

    }

}
