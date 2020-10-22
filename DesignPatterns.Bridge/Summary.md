**Summary:**
The bridge pattern is used to separate abstraction from its implementation so that both can be modified independently.

This pattern involves an interface which acts as a bridge between the abstraction class and implementer classes and also makes the functionality of implementer class independent from the abstraction class.

**When to use it?**
Abstractions and implementations should be modified independently.

Changes in the implementation of an abstraction should have no impact on clients.

The Bridge pattern is used when a new version of a software or system is brought out, but the older version of the software still running for its existing client. There is no need to change the client code, but the client needs to choose which version he wants to use.