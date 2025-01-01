# F# Mutable Variable Unexpected Behavior

This example demonstrates unexpected behavior when using mutable variables within an F# function. The `add` function aims to add two mutable variables and update them, but it produces results different from what one might initially expect.

The `bug.fs` file contains the erroneous code, while `bugSolution.fs` provides the corrected version.  The problem lies in the way mutable variables are updated within the function and how their values are passed.