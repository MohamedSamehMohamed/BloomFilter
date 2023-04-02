namespace BloomFilter;

public class DataBaseContainer<T>
{
    private readonly List<T> _container;
    private readonly BloomFilter<T> _bloomFilter;
    public DataBaseContainer(int bufferSize, IHashClass<T> hashClass)
    {
        _container = new List<T>();
        _bloomFilter = new BloomFilter<T>(bufferSize, hashClass);
    }
    public void Add(T element)
    {
        _container.Add(element);
        _bloomFilter.Add(element);
    }
    
    private T _find(T element)
    {
        return _container.FirstOrDefault(element);
    }

    public bool IsExist(T element)
    {
        if (_bloomFilter.MayExist(element) == false)
            return false;
        return _find(element) != null;
    }
}