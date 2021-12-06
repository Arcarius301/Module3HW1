using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW1
{
    public class CustomList<T> : IEnumerable
    {
        private T[] _array = new T[4];
        private int _count = 0;

        public int Count()
        {
            return _count;
        }

        public void Add(T item)
        {
            if (_count == _array.Length)
            {
                Array.Resize(ref _array, _array.Length * 2);
            }

            _array[_count] = item;
            _count++;
        }

        public void AddRange(T[] items)
        {
            while (true)
            {
                if (_count + items.Length > _array.Length)
                {
                    Array.Resize(ref _array, _array.Length * 2);
                }

                if (_count + items.Length <= _array.Length)
                {
                    Array.Copy(items, _array, items.Length);
                    _count += items.Length;
                    break;
                }
            }
        }

        public bool Remove(T item)
        {
            if (_count == 0)
            {
                return false;
            }

            for (var i = 0; i < _count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(item, _array[i]))
                {
                    _array[i] = default(T);
                    if (!(_array.Length == _count))
                    {
                        Array.Copy(_array, i + 1, _array, i, _count - i - 1);
                    }

                    _count--;
                    return true;
                }
            }

            return false;
        }

        public void RemoveAt(int index)
        {
            _array[index] = default(T);
            if (!(_array.Length == _count))
            {
                Array.Copy(_array, index + 1, _array, index, _count - index - 1);
            }

            _count--;
        }

        public void Sort()
        {
            T[] array = new T[_count];
            for (var i = 0; i < _count; i++)
            {
                array[i] = _array[i];
            }

            Array.Sort(array);
            Array.Copy(array, _array, _count);
        }

        public void Sort(IComparer comparer)
        {
            T[] array = new T[_count];
            for (var i = 0; i < _count; i++)
            {
                array[i] = _array[i];
            }

            Array.Sort(array, comparer);
            Array.Copy(array, _array, _count);
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _count; i++)
            {
                yield return _array[i];
            }
        }
    }
}
