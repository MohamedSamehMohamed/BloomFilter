namespace BloomFilter;

public class Program
{
    public static void Main()
    {
        var dataBase = new DataBaseContainer<string>(64, new HashStringClass());

        var input = new List<string>{ "mohamed", "Ahmed", "Sara" };
        foreach (var name in input)
        {
            dataBase.Add(name);
            Console.WriteLine(dataBase.IsExist(name));
        }
    }
}