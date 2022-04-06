# Stacks and Queues

**Stack** ***(First In Last Out, Last In First Out)***

Stacks in Data Structures is a linear type of data structure that allows insertion and deletion operations from one end of it, that is top.

**Queue** ***(First In First Out, Last In Last Out)***

A Queue is a linear structure which follows a particular order in which the operations are performed. 

## Challenge
Using a Linked List as the underlying data storage mechanism, implement both a Stack and a Queue

### Stack
- Create a Stack class that has a top property. It creates an empty Stack when instantiated.
- The class should contain the following methods:
    - push(value)
        1. adds a new node with that value to the top of the stack with an O(1) Time performance.
    - pop
        1. Returns: the value from node from the top of the stack & Removes it.
        2. Should raise exception when called on empty stack
    - peek
        1. Returns: Value of the node located at the top of the stack
        2. Should raise exception when called on empty stack
    - is empty
        1. Returns: Boolean indicating whether or not the stack is empty.

### Queue
- Create a Queue class that has a front property. It creates an empty Queue when instantiated.
- This object should be aware of a default empty value assigned to front when the queue is created.
- The class should contain the following methods:
    - enqueue
        1. adds a new node with that value to the back of the queue with an O(1) Time performance.
    - dequeue
        1. Returns: the value from node from the front of the queue & Removes it
        2. Should raise exception when called on empty queue
    - peek
        1. Returns: Value of the node located at the front of the queue
        2. Should raise exception when called on empty stack
    - is empty
        1. Returns: Boolean indicating whether or not the queue is empty

## Approach & Efficiency

### Stack 

**Push O(1)**

```
ALOGORITHM push(value)
// INPUT <-- value to add, wrapped in Node internally
// OUTPUT <-- none
   node = new Node(value)
   node.next <-- Top
   top <-- Node
```

**Pop O(1)**
```
ALGORITHM pop()
// INPUT <-- No input
// OUTPUT <-- value of top Node in stack
// EXCEPTION if stack is empty

   Node temp <-- top
   top <-- top.next
   temp.next <-- null
   return temp.value
```

**Peek O(1)** 

```
ALGORITHM peek()
// INPUT <-- none
// OUTPUT <-- value of top Node in stack
// EXCEPTION if stack is empty

   return top.value
```

**IsEmpty O(1)**

```
ALGORITHM isEmpty()
// INPUT <-- none
// OUTPUT <-- boolean

return top = NULL
```

### Queue

**Enqueue O(1)**

```
ALGORITHM enqueue(value)
// INPUT <-- value to add to queue (will be wrapped in Node internally)
// OUTPUT <-- none
   node = new Node(value)
   rear.next <-- node
   rear <-- node
```

**Dequeue O(1)**

```
ALGORITHM dequeue()
// INPUT <-- none
// OUTPUT <-- value of the removed Node
// EXCEPTION if queue is empty

   Node temp <-- front
   front <-- front.next
   temp.next <-- null

   return temp.value
```

**Peek O(1)**

```
ALGORITHM peek()
// INPUT <-- none
// OUTPUT <-- value of the front Node in Queue
// EXCEPTION if Queue is empty

   return front.value
```

***IsEmpty O(1)***

```
ALGORITHM isEmpty()
// INPUT <-- none
// OUTPUT <-- boolean

return front = NULL
```