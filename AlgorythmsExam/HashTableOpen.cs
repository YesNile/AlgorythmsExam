public class HashTableOpen<TKey, TValue>
    {
        private KeyValuePair<TKey, TValue>[] _cell;
        private int _size;

        public HashTableOpen(int size)
        {
            _size = size;
            _cell = new KeyValuePair<TKey, TValue>[size];
        }
        
        private int CalculateHash(TKey value, int iterate)
        {
            var hash = value.ToString()[0] - 'a' + iterate;
            return Math.Abs(hash % _size);
        }

        public int Add(TKey key, TValue value)
        {
            int iterate = 0;
            while (iterate < _size)
            {
                var hash = CalculateHash(key, iterate);
                iterate++;
                if (!_cell[hash].Equals(default(KeyValuePair<TKey, TValue>)))
                {
                    continue;
                }

                _cell[hash] = new KeyValuePair<TKey, TValue>(key, value);

                return hash;
            }
            
            return -1;
        }

        public TValue Search(TKey key)
        {
            int iterate = 0;
            while (iterate < _size)
            {
                var hash = CalculateHash(key, iterate);
                iterate++;
                if (!_cell[hash].Equals(default(KeyValuePair<TKey, TValue>)))
                {
                    continue;
                }

                return _cell[hash].Value;
            }
            
            return default;
        }

        public bool Remove(TKey key)
        {
            int iterate = 0;
            while (iterate < _size)
            {
                var hash = CalculateHash(key, iterate);
                iterate++;
                if (!_cell[hash].Equals(default(KeyValuePair<TKey, TValue>)))
                {
                    continue;
                }

                _cell[hash] = default;

                return true;
            }
            
            return false;
        }

        public int MaxClusterLength
        {
            get
            {
                var max = -1;
                var currLen = 0;
                foreach (var item in _cell)
                {
                    if (item.Equals(default(KeyValuePair<TKey, TValue>)))
                    {
                        currLen++;
                    }
                    else
                    {
                        if (max < currLen)
                        {
                            max = currLen;
                        }

                        currLen = 0;
                    }
                }

                return max;
            }
        }
    }