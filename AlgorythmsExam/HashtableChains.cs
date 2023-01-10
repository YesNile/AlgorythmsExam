public class HashTableChains<TKey, TValue>
{
    private List<KeyValuePair<TKey, TValue>>[] _cell;
    private int _size;
    public int MaxSize => _size;

    public TValue this[TKey key] => Search(key);

    public int LargestChain => _cell.Max(x => x?.Count ?? 0);
    public int ShortestChain => _cell.Min(x => x?.Count ?? 0);

    public HashTableChains(int size)
    {
        _size = size;
        _cell = new List<KeyValuePair<TKey, TValue>>[size];
    }

    private int CalculateHash(TKey value)
    {
        var hash = 1;
        var str = value.ToString();
        for (int i = 0; i < str.Length; i++)
        {
            hash += str[i] + 'a' - 1;
        }

        return Math.Abs(hash % _size);
    }

    public int Add(TKey key, TValue value)
    {
        var hash = CalculateHash(key);
        _cell[hash] ??= new List<KeyValuePair<TKey, TValue>>();
        _cell[hash].Add(new KeyValuePair<TKey, TValue>(key, value));

        return hash;
    }

    public TValue Search(TKey key)
    {
        var hash = CalculateHash(key);
        return _cell[hash].First(x => x.Key.Equals(key)).Value;
    }

    public bool Remove(TKey key)
    {
        var hash = CalculateHash(key);
        var cell = _cell[hash].First(x => x.Key.Equals(key));
        _cell[hash].Remove(cell);

        return true;
    }
}