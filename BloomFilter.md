## Bloom Filter class 

This code implements a Bloom Filter, a probabilistic data structure that can efficiently check whether an element is a member of a set. 

Usage
To use the BloomFilter class, first create an instance by specifying the buffer size and an implementation of the IHashClass interface, which is used to generate hash codes for elements of type T.


```
using BloomFilter;

var filter = new BloomFilter<string>(1000, new StringHash());

filter.Add("example");
```

To check whether an element may exist in the filter, call the MayExist method:

```
var mayExist = filter.MayExist("example");
```

Note that the MayExist method returns a probabilistic result. 
A false positive result (i.e., reporting that an element exists in the filter when it does not) is possible, but a false negative result (i.e., reporting that an element does not exist in the filter when it does) is not.

Constructor
The BloomFilter constructor takes two arguments:

bufferSize (int): the size of the filter buffer (i.e., the number of bits used to represent the filter).

hashClass (IHashClass<T>): an implementation of the IHashClass interface, which defines the method used to generate hash codes for elements of type T.

Public Methods
  The BloomFilter class provides two public methods:

void Add(T element): adds an element to the filter.
  
bool MayExist(T element): checks whether an element may exist in the filter.

  Private Fields
  
The BloomFilter class has three private fields:

_isExist (List<bool>): a list of boolean values representing the filter buffer.
  
_bufferSize (int): the size of the filter buffer.
  
_hashClass (IHashClass<T>): the implementation of the IHashClass interface used to generate hash codes.
