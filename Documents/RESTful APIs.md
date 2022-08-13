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

##### HTTP Requests:

- GET:
  - The GET method requests a representation of the specified resource. Requests using GET should only retrieve data.
- HEAD:
  - The HEAD method asks for a response identical to a GET request, but without the response body.
- POST:
  - The POST method submits an entity to the specified resource, often causing a change in state or side effects on the server.
- PUT:
  - The PUT method replaces all current representations of the target resource with the request payload.
- DELETE:
  - The DELETE method deletes the specified resource.

##### HTTP Status Codes:

###### Successful Responses

- 200 OK:
  - The request succeeded. The result meaning of "Success" depends on the HTTP method:
    - GET: The resource has been fetched and transmitted in the message body.
    - HEAD: The representation headers are included in the response without any message body.
    - PUT or POST: The resource describing the result of the action is transmitted in the message body.
    - TRACE: The message body contains the request message as received by the server.
- 201 Created:
  - The request succeeded, and a new resource was created as a result. This is typically the response sent after POST requests or some PUT requests.
- 202 Accepted:
  - The request has been received but not yet acted upon. It is noncommittal since there is no way in HTTP to later send an asynchronous response indicating the outcome of the request. It is intended for cases where another process or server handles the request, or for batch processing.
- 204 No Content:
  - There is no content to send for this request, but the headers may be useful. The user may update its cached headers for this resource with the new headers.

###### Redirection Messages

- 300 Multiple Choices:
  - The request has more than one possible response. The user should choose one of them.
- 301 Moved Permanently:
  - The URL of the requested resource has been changed permanently. The new URL is given in the response.
- 302 Found:
  - This response code means the URI of a requested resource has been changed temporarily. Further changes in the URI might be made in the future. Therefore, this same URI should be used by the client in future requests.
- 303 See other:
  - The server sent this response to direct the client to get the requested resource at another URI with a GET request.

###### Client Error response

- 400 Bad Request:
  - The server cannot or will not process the request due o something that is perceived to be a client error (e.g. Malformed request syntax, invalid request message framing, or deceptive request routing).
- 401 Unauthorised:
  - Although the HTTP standard specifies "Unauthorised", semantically this response means "Unauthenticated". That is, the client must authenticate itself to get the requested response.
- 402 Payment Required:
  - This response code is reserved for future use. The initial aim of this code was to use it for digital payment systems, however, this status code is used very rarely and no standard convention exists.
- 403 Forbidden:
  - The client does not have access rights to the content; that is, it is unauthorised, so the server is refusing to give the requested resource. Unlike code 401, the client's identity is known to the server.
- 404 Not Found:
  - The server can not find the requested resource. In the browser, this means the URL is not recognised. In an API, this can also mean that the endpoint is valid but the resource itself does not exist. Servers may also send this response instead of code 403 to hide the existence of a resource from an unauthorised client.
- 405 Method Not Allowed:
  - This response is sent when the web server, after performing Server-driven Content Negotiations, doesn't find any content that conforms to the criteria given by the user.

###### Server Error Responses

- 500 Internal Server Error:
  - The server has encountered a situation it does not know how to handle.
- 501 Not Implemented:
  - The request method is not supported by the server and cannot be handled. The only methods that servers are required to support (and therefore that must not return this code) are GET and HEAD.
- 502 Bad Gateway:
  - This error response means that the server while working as a gateway to get a response needed to handle the request, got an invalid response
- 503 Service Unavailable:
  - The server is not ready to handle the request. Common causes are a server that is down for maintenance or that is overloaded. A user-friendly page explaining the problem should be sent.
  - This response should be used for temporary conditions and the Retry-After HTTP header should, if possible, contain the estimated time before the recovery of the service. The webmaster must also take care of the caching-related headers that are sent along with the response, as these temporary condition responses should usually not be cached.
- 504 Gateway Timeout:
  - This error response is given when the server is acting as a gateway and cannot get a response in time.
- 505 HTTP Version Not Supported:
  - The HTTP version used in the request is not supported by the server.

### RESTSharp

RESTSharp is an open-source HTTP client library that makes it easy to consume RESTful services. RESTSharp provides an interface to work with RESTful services while abstracting the internal intricacies of working with HTTP requests. RESTSharp supports both synchronous and asynchronous requests.

### Newtonsoft

Newtonsoft JSON namespace provides classes that are used to implement the core services of the framework. It provides methods for converting between .NET types and JSON types.

