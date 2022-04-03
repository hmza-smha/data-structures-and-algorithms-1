# Singly Linked List
The ***linked list*** is a linear collection of data elements whose order is not given by their physical placement in memory. Instead, each element points to the next.

## Challenge
Create a **linked list** contains following methods

**1. insert**

Adds a new node with that value to the head of the list with an O(1) Time performance.

**2. includes**

Indicates whether that value exists as a Node’s value somewhere within the list.

**3. to string**

Retusrn a string representing all the values in the Linked List, formatted as:
**"[ a ] -> [ b ] -> [ c ] -> NULL"**

## Approach & Efficiency

**1. insert** ***Big O(1)***

1. Create a new Node *(newNode)*,
2. if the *Head* is null, then assign the *newNode* to the *Head*.
3. if the *Head* is nut null, then assign the *newNode.Next* to *Head*, and *Head* to *newNode*.


**2. includes** ***Big O(n)***

1. Loop into the **linked List** using a *(temp)* Node.
2. If *temp.value* equals the *target*, then EXIT.


**3. to string** ***Big O(n)***

1. Loop into the **linked List** using a *(temp)* Node.
2. Concatenate *temp.value* together


