namespace BloomFilter;

public class HashStringClass : IHashClass<string>
{
    public int Hash(string element, int bufferSize)
    {
        var hashCode = 0;
        foreach (var c in element)
        {
            hashCode = (hashCode * 10 + c) % bufferSize;
        }

        return hashCode;
    }
}