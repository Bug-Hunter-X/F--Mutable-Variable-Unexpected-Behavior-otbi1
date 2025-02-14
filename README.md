# F# Mutable Variable Unexpected Behavior

This example demonstrates a common pitfall in F# when dealing with mutable variables and function calls. The value of `y` remains unchanged even after the value of `x` is modified, highlighting the immutability of function return values.

## Bug

The `addOne` function calculates `x + 1` and assigns the result to `y`. However, when `x` is modified after calling `addOne`, `y` does not reflect this change.

## Solution

The solution leverages a mutable reference cell to allow modification of the value passed to the function and reflected in the return value. This ensures that any change to the reference cell is seen by the function and subsequent usages.

## How to reproduce

1. Compile and run the `bug.fs` file.
2. Observe that the output shows that y still holds the original value despite the change in x
3. Compile and run the `bugSolution.fs` file. The output now reflects the changes made to the mutable reference cell.