using System;
namespace Samples.DataStructures
{
    public class GenericDynamicArray<T>
    {
        private T[] Datas;
        private int Size;
        private int InitialCapacity;

        public GenericDynamicArray(int initialCapacity)
        {
            InitialCapacity = initialCapacity;
            Datas = new T[InitialCapacity];
        }

        public void Add()
        {

        }

        public T Get(int index)
        {
            if (index >= InitialCapacity || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            return Datas[index];
        }

        public void Set(int index, T val)
        {
            if (index >= InitialCapacity || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            Datas[index] = val;
        }

    }
}