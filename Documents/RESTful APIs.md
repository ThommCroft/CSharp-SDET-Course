## RESTful APIs

### REST

Representational State Transfer (REST), is an architectural style for providing standards between computer systems and the Web, making it easier for systems to communicate with each other. REST-compliant systems, often called RESTful systems, are characterised by how they are stateless and separate the concerns of client and server.

### REST Architectural Constraints

##### Uniform Interface:

You must decide on the APIs interface for resources inside the system which are exposed to API consumers and follow them. A resource in the system should have only one logical URI, and that should provide a way to fetch related or additional data. It is better to synonymise a resource with a web page.

Any single resource should not be too large and contain each and everything in its representation. Whenever relevant, a resource should contain links (HATEOAS) pointing to relative URIs to fetch related information. The resource representations across the system should follow specific guidelines such as naming conventions, link formats, or data formats (XML and/ or JSON).

All resources should be accessible through a common approach such as HTTP GET and similarly modified using a consistent approach.

##### Client-server:

This constraint essentially means that client applications and server applications must be able to evolve separately without any dependency on each other. A client should know only resource URIs. This is standard practice in Web development.

##### Stateless:

Make all client-server interactions stateless. The server will not store anything about the HTTP request the client has made. It will treat every request as new with no session and no history.

##### Cacheable:

The caching of data and responses is of utmost importance wherever they are applicable/ possible. Caching brings performance improvements for the client-side and better scope for scalability for a server due to the load being reduced. In REST, caching shall be applied to resources when applicable, and these resources must declare themselves cacheable. Caching can be implemented on the server or client-side.

##### Layered System:

REST allows you to use a layered system architecture where you deploy the APIs on one server, and store the data on another, with authentication requests on a third.

##### Code on Demand (Optional):

Most of the time you will be sending the static representations of resources in the form of XML or JSON. When you need to, you are free to return executable code to support a part of the application, e.g. clients may call your API to get a UI widget rendering code.

### HTTP Headers

HTTP headers let the client and the server pass additional information with an HTTP request or response. An HTTP header consists of its case-insensitive name followed by a colon, then by its value. Whitespace before the value is ignored.

### RESTSharp

RESTSharp is an open-source HTTP client library that makes it easy to consume RESTful services. RESTSharp provides an interface to work with RESTful services while abstracting the internal intricacies of working with HTTP requests. RESTSharp supports both synchronous and asynchronous requests.

### Newtonsoft

Newtonsoft JSON namespace provides classes that are used to implement the core services of the framework. It provides methods for converting between .NEW types and JSON types.

