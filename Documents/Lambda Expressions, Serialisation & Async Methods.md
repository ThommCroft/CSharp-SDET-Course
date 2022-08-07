## Lambda Expressions, Serialisation & Async Methods



### Lambda Expressions

The Lambda operator => separates the input parameters on the left side from the Lambda body on the right side. Input parameters of a Lambda Expression are strongly typed at compile time. When the compiler can infer the types of input parameters. If you need to specify the type of input parameters, you must do that for each parameter. The Lambda operator is referred to as "go to".

Example:	int product = numbers.Aggregate(1, (int interim, int next) => interim * next);

##### Language Integrated Query (LINQ):

LINQ is a consistent model for working with data across various data sources and formats. In a LINQ query, you are always working with objects and you use the same basic coding patterns to query and transform the data in XML documents, SQL databases, ADO.NET Datasets, .NET collections, and any other format.

All LINQ operations consist of three distinct actions:

- Obtain the data source
- Create the query
- Execute the query

Example: var numQuery = FROM num IN numbers WHERE (num % 2) == 0 SELECT num;

LINQ uses method calls to invoke the query operations, examples are listed below:

- Where:
  - Selects values, depending on their ability to be cast to a specified type.
- Distinct:
  - Removes duplicate values from a collection.
- Select:
  - Projects values that are based on a transform function.
- Join:
  - Joins two sequences based on key selector functions and extracts pairs of values.
- GroupBy:
  - Groups elements that share a common attribute.
- OrderBy:
  - Sorts values in ascending order.
- OrderByDecending:
  - Sorts values in descending order.
- Min:
  - Determines the minimum value in a collection.
- Max:
  - Determines the maximum value in a collection.
- Average:
  - Calculates the average value of a collection of values.

### Serialisation

Serialisation is the process of converting an object into a stream of bytes to store the object or transmit it to memory, a database, or a file. Its main purpose is to save the state of an object to be able to recreate it when needed. The reverse process is called deserialisation. The object is serialised to a stream that carries the data. The stream may also have information about the object's type, such as its version, culture, and assembly name.

##### Binary Serialisation:

Binary serialisation uses binary encoding to produce compact serialisation for uses such as storage or socket-based network streams. In binary serialisation, all members including read-only, are serialised and performance is enhanced. Binary serialisation can be dangerous due to security issues.

##### XML Serialisation:

XML serialisation serialises an object's public fields and properties, or the parameters and return values of methods, into an XML stream that conforms to a specific XML schema definition language (XSD) document. XML serialisation results in strongly typed classes with public properties and fields that are converted to XML.

##### JSON Serialisation:

JSON serialisation serialises the public properties of an object into a string, byte array, or stream that conforms to the RFC 8259 JSON specification. To control the way JsonSerialiser serialises or decimalises an instance of a class:

- Use a JsonSerialiserOptions object
- Apply attributes from System.Text.Json.Serialisation namespace to classes or properties
- Implement custom converters

##### Nullable value Types:

A nullable value type T? represents all values of its underlying value type T and an additional null value. For example, you can assign any of the following three values to a bool? variable: true, false, or null. An underlying value type T cannot be a nullable value type itself. A nullable type is typically used when you need to represent an undefined value of a value type.

### Async Methods

An asynchronous method call is a method used in .NET programming that returns to the caller immediately before the completion of its processing and without blocking the calling thread. When an application calls an asynchronous method, it can simultaneously execute along with the execution of the asynchronous method that performs its task. An asynchronous method runs in a thread separate from the main application thread. The process results are fetched through another call on another thread.

Asynchronous methods help optimise the execution of resources resulting in a scalable application. These are used to execute time-consuming tasks such as opening large files, connecting to remote computers, querying a database, calling Web services, and ASP.NET Web forms.

##### Task:

The Task class represents a single operation that does not return a value and usually executes asynchronously. Task objects are one of the central components of the task-based asynchronous pattern. The work performed by a Task object typically executes asynchronously on a thread pool thread rather than synchronously on the main application thread, you can use the Status property, as well as the IsCanceled, IsCompleted, and IsFaulted properties, to determine the state of a task. Most commonly, a Lambda Expression is used to specify the work that the task is to perform.

##### Await:

The Await operator suspends evaluation of the enclosing async method until the asynchronous operation is completed. When the asynchronous operation completes, the await operator returns the result of the operation immediately without suspension of the enclosing method. The await operator does not block the thread that evaluates the async method. When the await operator suspends the enclosing async method, the control returns to the caller of the method.

Example: Task<int> downloading = DownloadDocsMainPageAsync();

​					int bytesLoaded = await downloading;