## Big O Notation



Big O Notation is a way to measure an algorithm's efficiency. It measures the time taken to run your function as the input grows, in other words, how well your function scales. There are two parts to measuring efficiency, time complexity and space complexity. Time complexity is a measure of how long the function takes to run in terms of its computational steps. Space complexity has to do with the amount of memory used by the function. 

Big o Notation is sometimes referred to as the algorithm's upper bound, meaning that it deals with the worst-case scenario. The best-case scenario doesn't tell us anything, it will be finding our item in the first pass. We use the worst-case scenario to remove uncertainty, the algorithm will never perform worse than we expect.

##### Writing Big O Notation

When writing Big O Notation, we look for the fastest-growing term as the input gets larger and larger. We can simplify the equation by dropping constants and any non-dominant terms. For example, O(2N) becomes O(N), and O(N2 + N + 1000) becomes O(N2).

Binary Search is O(log N) which is less complex than Linear Search. There are many more complex algorithms. A common example of a quadratic algorithm, or O(N2) is a nested for loop. In a nested loop, we iterate through the entire data in an outer loop. Then for each element, we iterate through the data in an inner loop. This is N x N times of N2.