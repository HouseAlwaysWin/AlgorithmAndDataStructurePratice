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

        public void Add(T data)
        {
            if (Size == InitialCapacity)
            {
                Resize();
            }
            Datas[Size] = data;
            Size++;
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

        public void Insert(int index, T data)
        {
            if (Size == InitialCapacity)
            {
                Resize();
            }

            for (int i = Size; i > index; i--)
            {
                Datas[i] = Datas[i - 1];
            }
            Datas[index] = data;
            Size++;
        }

        public void Delete(int index)
        {
            if (index >= InitialCapacity || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = index; i < Size; i++)
            {
                Datas[i] = Datas[i + 1];
            }
            Size--;

            if (index == Size)
            {
                Datas[index] = default(T);
            }
        }

        public bool IsEmpty()
        {
            return Size == 0;
        }

        public bool Contains(T data)
        {
            for (int i = 0; i < Size; i++)
            {
                if (Datas[i].Equals(data))
                {
                    return true;
                }
            }

            return false;
        }

        public int GetSize()
        {
            return Size;
        }



        private void Resize()
        {
            T[] newArray = new T[InitialCapacity * 2];

            for (int i = 0; i < Size; i++)
            {
                newArray[i] = Datas[i];
            }

            Datas = newArray;
            InitialCapacity = InitialCapacity * 2;
        }

    }
}