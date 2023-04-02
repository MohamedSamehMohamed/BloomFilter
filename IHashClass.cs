namespace BloomFilter;

public interface IHashClass<T>
{
    public int Hash(T element, int bufferSize);
}