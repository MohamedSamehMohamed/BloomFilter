# BloomFilter Database Container

This is a simple implementation of a database container that uses a Bloom filter to reduce the number of database queries required to check whether an element exists in the container.

The DataBaseContainer class is defined in the BloomFilter namespace and supports adding elements to the container and checking whether an element exists in the container.

Usage
To use the DataBaseContainer class, you first need to create an instance of the class, specifying the buffer size and hash class to use for the Bloom filter:
```
using BloomFilter;

// Create a new database container with a buffer size of 1000 and the StringHash implementation
var container = new DataBaseContainer<string>(1000, new StringHash());
```
You can then add elements to the container using the Add method:
```
// Add an element to the container
container.Add("example");
```
To check whether an element exists in the container, use the IsExist method:

```
// Check whether an element exists in the container
bool exists = container.IsExist("example");
```
The IsExist method returns a boolean value indicating whether the specified element exists in the container.

Implementation Details
The DataBaseContainer class stores elements in a simple list and uses a Bloom filter to reduce the number of queries required to check whether an element exists in the list.

When an element is added to the container using the Add method, it is added to the list and its hash is added to the Bloom filter.

When the IsExist method is called with an element, the Bloom filter is first checked to see if the element may exist in the list. 

If the Bloom filter indicates that the element is not in the list, the IsExist method returns false immediately. 

If the Bloom filter indicates that the element may be in the list, the IsExist method searches the list for the element and returns true if it is found.

The Bloom filter implementation used by the DataBaseContainer class is the BloomFilter class from the BloomFilter namespace, which is also included in this repository. 

The Bloom filter implementation requires an implementation of the IHashClass interface, which is used to calculate the hash of elements added to the filter.
