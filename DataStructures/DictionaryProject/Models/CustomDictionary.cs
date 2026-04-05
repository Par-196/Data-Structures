using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryProject.Models
{
    public class CustomDictionary<TKey, TValue> : IEnumerable
    {
        private List<KeyValuePair<TKey, TValue>> _list { get; set; }

        private int _Count;

        public CustomDictionary()
        {
            _list = new List<KeyValuePair<TKey, TValue>>();
        }

        public void Add(TKey key, TValue value)
        {
            foreach (var item in _list)
            {
                if (EqualityComparer<TKey>.Default.Equals(item.Key, key))
                {
                    Console.WriteLine("Key already exists");
                    return;
                }
            }
            _list.Add(new KeyValuePair<TKey, TValue>(key, value));
            _Count++;
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool ContainsKey(TKey key)
        {
            foreach (var item in _list)
            {
                if (EqualityComparer<TKey>.Default.Equals(key, item.Key))
                { 
                    return true;
                }
            }
            return false;
        }

        public bool ContainsValue(TValue value)
        {
            foreach (var item in _list)
            {
                if (EqualityComparer<TValue>.Default.Equals(value, item.Value))
                {
                    return true;
                }
            }
            return false;
        }

        public bool Remove(TKey key)
        {
            foreach (var item in _list)
            {
                if (EqualityComparer<TKey>.Default.Equals(key, item.Key))
                { 
                    _list.Remove(item);
                    _Count--;
                    return true;
                }
            }
            return false;
        }

        public bool Remove(TKey key, out TValue value)
        {
            foreach (var item in _list)
            {
                if (EqualityComparer<TKey>.Default.Equals(key, item.Key))
                {
                    _list.Remove(item);
                    _Count--;
                    value = item.Value;
                    return true;
                }
            }
            value = default(TValue);
            return false;
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            foreach (var item in _list)
            {
                if (EqualityComparer<TKey>.Default.Equals(key, item.Key))
                {
                    value = item.Value;
                    return true;
                }
            }
            value = default(TValue);
            return false;
        }

        public bool TryAdd(TKey key, TValue value)
        {
            foreach (var item in _list)
            {
                if (EqualityComparer<TKey>.Default.Equals(item.Key, key))
                {
                    Console.WriteLine("Key already exists");
                    return false;
                }
            }
            _list.Add(new KeyValuePair<TKey, TValue>(key, value));
            _Count++; 
            return true;
        }

        public void PrintDictionary()
        {
            foreach (var item in _list)
            {
                Console.WriteLine($"Key - {item.Key}, Value - {item.Value}");
            }
        }

        public int Count()
        {
            return _Count;
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            foreach (var item in _list)
            {
                yield return item;
                //_list.GetEnumerator();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
