/*
 * Research for the following scenarios and give appropriate reason.
 * a. int a = 3, b; a = b = 6+7; 
 * b. 0 <5 == 2+ 0 >= 5; // consider true evaluates to 1 and 0 to false
 * c. x && y || z++; vs. z++ || x && y; for the values of x = 0, y = 1, z = 5; // C/C++ not C#, class discussion
 * d. x && y || z++; vs. z++ || x && y; for the values of x = true, y = 10, z = 5; // C/C++ not C#, class discussion
 */

// Please suggest a better answer or correct if its not valid. //

/*
 Let's analyze each expression:

### a. `int a = 3, b; a = b = 6 + 7;`

This expression involves assignment operators. Here's the breakdown:

- `6 + 7` is evaluated first, resulting in `13`.
- Then, `b` is assigned the value of `13`.
- Finally, `a` is assigned the value of `b`, which is `13`.

So, after this expression, both `a` and `b` will be `13`.

### b. `0 < 5 == 2 + 0 >= 5;`

This expression involves comparison and logical operators. Let's break it down:

- `0 < 5` is `true` (because 0 is less than 5).
- `2 + 0` is `2`.
- `true == 2` is `false` because, in C/C++, true is usually represented as `1`, and `2` is not equal to `1`.
- `2 >= 5` is `false` (because 2 is not greater than or equal to 5).

So, the whole expression is `false`.

### c. `x && y || z++;` vs. `z++ || x && y;` for the values of `x = 0, y = 1, z = 5;`

Let's evaluate each expression separately:

- For `x && y || z++;`:
  - `x && y` is `0 && 1`, which is `0` (false).
  - Then, `0 || z++` is `0 || 5`, which is `1` (true). After this, `z` is incremented.

- For `z++ || x && y`:
  - `z++` is `5`, and then `z` is incremented.
  - `x && y` is `0 && 1`, which is `0`.
  - Finally, `5 || 0` is `1` (true).

So, for the given values, the first expression is `true` (1), and the second expression is also `true` (1).

### d. `x && y || z++;` vs. `z++ || x && y;` for the values of `x = true, y = 10, z = 5;`

Let's evaluate each expression separately:

- For `x && y || z++;`:
  - `true && 10` is `true` (non-zero).
  - Then, `true || z++` is `true`, and `z` is not incremented.

- For `z++ || x && y`:
  - `z++` is `5`, and then `z` is incremented.
  - `true && 10` is `true`.
  - Finally, `5 || true` is `1` (true).

So, for the given values, both expressions are `true`.
 */