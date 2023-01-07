namespace AlgorythmsExam;

public class HashTableChains<TKey, TValue>
{
    private List<KeyValuePair<TKey, TValue>>[] _cell;
    private int _size;
    public int MaxSize => _size;

    public HashTableChains(int size)
    {
        _size = size;
        _cell = new List<KeyValuePair<TKey, TValue>>[size];
    }

    private int CalculateHash(TKey value)
    {
        var str = value.ToString();
        var hash = 1;
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
}