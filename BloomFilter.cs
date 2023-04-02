namespace BloomFilter;

public class BloomFilter<T>
{
    private readonly List<bool> _isExist;
    private readonly int _bufferSize;
    private readonly IHashClass<T> _hashClass; 
    public BloomFilter(int bufferSize, IHashClass<T> hashClass)
    {
        _isExist = new List<bool>(new bool[bufferSize]);
        _bufferSize = bufferSize;
        _hashClass = hashClass;
    }
    public void Add(T element)
    {
        var hashCode = _hashClass.Hash(element, _bufferSize);
        _isExist[hashCode] = true;
    }

    public bool MayExist(T element)
    {
        var hashCode = _hashClass.Hash(element, _bufferSize);
        return _isExist[hashCode];
    }
}