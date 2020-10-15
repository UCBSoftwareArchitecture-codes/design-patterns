**Summary:**
This pattern is used when there is one too many relationships between objects such as if one object is modified, its dependent objects are to be notified automatically.

**When to use it?**
Changes in the state of an object need to be notified to a set of dependent objects, not all of them.
Notification capability is required.
The object sending the notification does not need to know about the receivers objects.