using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTypesHomework
{
    class MyList<T>
    {
        public T[] _arr = new T[0];
        public T this[int index]
        {
            get { return _arr[index]; }

            set { _arr[index] = value; }
        }
        public int Capacity { get; set; }
        public int Count { get { return _arr.Length; } }

        public void AddItem(T input)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = input;
        }
        public void AddItems(params T[] items)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr = items;
        }
        public void RemoveLast()
        {
            Array.Resize(ref _arr, _arr.Length - 1);
        }
        public void Remove(T input)
        {
            //foreach (var item in _arr)
            //{
            //    if (item.Equals(input))
            //    {
            //    }
            //}
        }
        public void Clear()
        {
            _arr = new T[0];
        }
        //public bool exist()
        //{
        //}
        public void Reverse()
        {
            for (int i = _arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(_arr[i]);
            }
        }
        public void IndexOf(T elem)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i].Equals(elem))
                {
                    Console.WriteLine(i);
                }
            }
        }
        public void LastIndexOf()
        {
            Console.WriteLine(_arr.Length - 1);
        }
        public void Print()
        {
            foreach (var item in _arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
