# W10 Prove: Individual Assignment
## Instructions
This assignment **must be completed individually** to ensure you are meeting all course outcomes. You should not complete this assignment within a group. If you obtain help from a tutor, the tutor should help you understand principles but should not help you answer these problems. It is an honor code violation to obtain answers for these problems from others including using the internet (i.e. sites that allow students to share their solutions).

As you solve the problems, remember to use the principles learned in the first five lessons of the course:
* Problem Solving Strategy: understand the problem, plan and design the solution, implement the solution, and evaluate the solution.
* Evaluate Performance of Alternative Solutions: use big O to determine the best solution.
* Understanding Code Using Reviews: analyze any code you have been given.
* Finding Defects Using Tests: write tests to determine if your solution is working.
* Articulating Answers for Technical Questions: imagine that you were asked one of these questions during an interview. Remember to ensure that you fully understand the problem and work through different scenarios manually. Consider how the data structure you are using will help you solve the problem. A notebook or a whiteboard can be very useful in this process.

### Problem 1 - Count
Implement the `Count` function in the `BinaryHeap` class to indicate the number of values stored in the Heap.  The `Add` and `BubbleUp` functions are already implemented which allows the test function for Count to run correctly.

### Problem 2 - Peek
Implement the `Peek` function in the `BinaryHeap` class.  Unlike the `Remove` function, the `Peek` function should return the value at the root of the Heap but not remove it.  If the heap is empty, the throw an `InvalidOperationException`.

### Problem 3 - Remove & BubbleDown
Implement the `Remove` function in the `BinaryHeap` class.  This will also require the implementation of the `BubbleDown` recursive function.  Recall that when "bubbling down", you should follow the smallest child. The base case occurs when the parent is less than or equal to the children. 

### Problem 4 - Add to Max Heap
Modify the `BubbleUp` function to support a MaxHeap.  When the `BinaryHeap` object is created, a MaxHeap can be indicated by setting `isMin` to False (by default this attribute is True thus corresponding to a MinHeap).  In this scenario, the rule is that both children have to be less than or equal to the parent.  The tests that were written in the previous problems should still work.

### Problem 5 - Remove from Max Heap
Modify the `BubbleDown` function to support a MaxHeap in the same way as `BubbleUp` was modified. Note that there may be more code changes that what was experienced with `BubbleUp`.  The tests that were written in the previous problems should still work.

## Submission
You need to submit the following for this assignment:
* Make sure all of your changes are committed and pushed to the `main` branch of your **prove-09** repository
* Submit a link to your repository in I-Learn
