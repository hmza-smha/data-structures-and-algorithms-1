# Challenge Summary
Implement a class called ```AnimalShelter``` which holds only ```dogs``` and cats.
The ```AnimalShelter``` operates using a FIFO approach.

## Approach & Efficiency

### enqueue
- Arguments: ```animal```
    - ```animal``` can be either a ```dog``` or a ```cat``` object.

### dequeue
- Arguments: pref
    - pref can be either "dog" or "cat"

- Return: either a ```dog``` or a ```cat```, based on preference.

    - If pref is not "dog" or "cat" then return null.

## Solution
```c#
public class AnimalShelter
    {
        public Queue<Cat> Cats = new();
        public Queue<Dog> Dogs = new();

        public void Enqueue(Animal animal)
        {
            if (animal is Cat)
            {
                Cats.Enqueue(new Cat());
            }
            else if (animal is Dog)
            {
                Dogs.Enqueue(new Dog());
            }
        }

        public Animal Dequeue(string pref)
        {
            if (pref == "cat")
            {
                return Cats.Dequeue();
            }
            else if (pref == "dog")
            {
                return Dogs.Dequeue();
            }
            else
            {
                return null;
            }
        }
    }
```

```c#
public class Animal {}
```


```c#
public class Cat : Animal {}
```

```c#
public class Dog : Animal {}
```