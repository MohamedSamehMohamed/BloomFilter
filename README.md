# BloomFilter

BloomFilter is a type of data structure used to efficiently filter out elements that are not present in a set. 

Its main purpose is to reduce the frequency of database queries needed to retrieve data, by quickly checking whether a given element is likely to be in the set or not. 

By minimizing the number of unnecessary queries, BloomFilter can significantly improve the performance and scalability of applications that rely on large data sets.

## Idea 
The basic concept behind this approach is to generate a hash value for each data item that is added to the database, and store this value in memory. 

When a query is made about a particular data item, the hash value is checked to see if it has been previously marked as present in the database. 

If the hash value is marked, it is highly likely that the data is already in the database, so there is no need to query the database again. 

This technique can be an efficient way to reduce the number of database queries and speed up data retrieval.
