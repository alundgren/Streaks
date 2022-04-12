# Streaks

## Overview
Just playing with finding the longest run in sequences of binary events like coin flips.

For example in 1001101110 the longest run is 111 of length 3.

The c# project holds both the unit tests and the c# solutions while the f# project has just the f# solution.

To test the code run

> dotnet test

From the c# project.

## Solution basis
The solutions rest on the assumption that the problem has these invariant.

- s: The sequence
- f(i): For a given index i in the sequence returns (c_i, g_i)
  - c_i: Length of current streak.
  - g_i: Length of longest ever streak.
- f(0): (1, 1)
- f(i+1): s[i] == s[i+1] ? (c_i + 1, g_i) : (1, max(c_i, g_i))

## Caveat emptor
My math days are like 15 years back in time so don't trust this overly much. This seems correct and the testcases work out but still, this could be wrong since it's not based on any research on how this problem is supposed to be solved. If other sources claim differently they are likely right.
