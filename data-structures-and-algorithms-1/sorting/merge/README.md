# Merge Sort

### Pseudo Code

```
ALGORITHM Mergesort(arr)
    DECLARE n <-- arr.length

    if n > 1
      DECLARE mid <-- n/2
      DECLARE left <-- arr[0...mid]
      DECLARE right <-- arr[mid...n]

      // sort the left side
      Mergesort(left)

      // sort the right side
      Mergesort(right)

      // merge the sorted left and right sides together
      Merge(left, right, arr)

ALGORITHM Merge(left, right, arr)
    DECLARE i <-- 0
    DECLARE j <-- 0
    DECLARE k <-- 0

    while i < left.length && j < right.length
        if left[i] <= right[j]
            arr[k] <-- left[i]
            i <-- i + 1
        else
            arr[k] <-- right[j]
            j <-- j + 1

        k <-- k + 1

    if i = left.length
       set remaining entries in arr to remaining values in right
    else
       set remaining entries in arr to remaining values in left
```

## Trace

**Rules:**
- If you merge two sorted list, then you will got a one sorted list.
- In Merge Sort one element is considered as a sorted list.

**input:** ```[8, 4, 23, 42, 16, 15]```

<br>

### Pass 1:

split the array in two halfs,

left -> ```[8, 4, 23]```
right -> ```[42, 16, 15]```

<br>

### Pass 2:

split the ```left``` array in tow halfs

left -> ```[8, 4]```
right -> ```[23]```

<br>

### Pass 3:

split the left again 

left_1 ```[8]```
right_1 ```[4]```

Since you got a sorted two lists *(One element in each list)*, Now Merge them.

=> ```[4, 8]```

back to right ```[23]``` which is a sorted list, Now merge ```[4, 8]``` with ```[23]```.

=> left: ```[4, 8, 23]```

<br>

### pass 4:

Since you have a sorted **left** list ```[4, 8, 23]```, repeate the steps for the **right** list ```[42, 16, 15]```, you will got  ```[15, 16, 42]```.

Now you have Two sorted halfs:
- left: ```[4, 8, 23]```
- right: ```[15, 16, 42]```

By Merge ```left``` & ```right```:

=> ```[4, 8, 15, 16, 23, 42]```


## Approach & Efficiency

```O(n*Log n):```

The time complexity of MergeSort is O(n*Log n) in all the 3 cases (worst, average and best). As the mergesort always divides the array into two halves and takes linear time to merge two halves.

## Solution
<!-- Show how to run your code, and examples of it in action -->