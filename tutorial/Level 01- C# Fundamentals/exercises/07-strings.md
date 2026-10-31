# Exercise 07 — Strings

## Core Concepts Tested
- String creation and immutability
- String concatenation vs interpolation
- Escape sequences
- String methods and their behavior
- `StringBuilder` (if applicable)
- String comparison
- Null and empty string handling

---

## Questions

### Q1 — String Concatenation vs Interpolation

Write two versions of the same output:

**Version A — Concatenation:**
```csharp
string name = "John";
int age = 25;
Console.WriteLine("My name is " + name + " and I am " + age + " years old.");
```

**Version B — Interpolation:**
```csharp
string name = "John";
int age = 25;
Console.WriteLine($"My name is {name} and I am {age} years old.");
```

1. What is the output of each?
2. Are they functionally identical? Are there any performance differences?
3. What happens when you concatenate a `string` with an `int` using `+`? How does the compiler handle this?

---

### Q2 — String Immutability

1. Write code that demonstrates string immutability:
   ```csharp
   string s = "Hello";
   s = s + " World";  // Does this modify the original string?
   ```
2. Display the original reference and the new reference (using `ReferenceEquals` if you know it, or just explain).
3. Explain what happens in memory when you "modify" a string.
4. Why is this different from modifying an `int` variable?

**Follow-up:** If strings are immutable, what happens in a loop that concatenates strings 1000 times? What alternative would you use for performance?

---

### Q3 — Escape Sequences

Write a program that outputs text containing the following escape sequences:

1. `\n` — newline
2. `\t` — tab
3. `\\` — backslash
4. `\"` — double quote within a string
5. `\r` — carriage return

Display a formatted address or poem that uses these escapes.

**Extension:** What is a verbatim string literal (`@"..."`)? Write an example that would be much clearer using a verbatim string.

---

### Q4 — String Methods

For each of the following, write code using the appropriate `string` method and display the result:

1. Get the length of `"Hello World"`.
2. Convert `"hello"` to uppercase.
3. Convert `"HELLO"` to lowercase.
4. Check if `"cat"` contains `"at"`.
5. Find the index of the first space in `"Hello World"`.
6. Extract the first 5 characters from `"Hello World"`.
7. Remove the word `"World"` from `"Hello World"`.
8. Replace `"World"` with `"C#"` in `"Hello World"`.
9. Trim whitespace from `"  Hello  "`.
10. Check if a string is empty: `""`.

**Reflection:** Are these methods returning new strings or modifying the original? Why?

---

### Q5 — String Comparison

Write code that compares two strings:

```csharp
string a = "hello";
string b = "Hello";
```

1. Use `==` to compare them. What is the result?
2. Use `string.Equals(a, b)`. What is the result?
3. Use `string.Equals(a, b, StringComparison.OrdinalIgnoreCase)`. What is the result?
4. Use `string.Compare(a, b)`. What does the integer result mean?

**Extension:** What is case sensitivity in string comparison, and why is it important? When would you use ordinal vs culture-aware comparison?

---

### Q6 — String Formatting

Write code that formats the following using **three different methods**:

1. A product receipt:
   - Product name: "Widget"
   - Price: 19.99
   - Quantity: 3
   - Total: 59.97

Use:
- Concatenation with `+`
- String interpolation `$"..."`
- `string.Format()`

**Reflection:** Which method is most readable? Which is most performant?

---

### Q7 — Practical: Text Analyzer

Write a program that:

1. Asks the user to enter a sentence.
2. Displays:
   - The length of the sentence.
   - The number of words (split by spaces).
   - The number of vowels.
   - The sentence reversed.
   - Whether the sentence is a palindrome (ignoring case).

**Extension:** What edge cases should you handle (empty input, null input, multiple spaces)?

---

### Q8 — Null and Empty Strings

Write code that:

1. Declares a `string` variable and assigns it `null`.
2. Tries to call `ToUpper()` on it. What happens?
3. Safely handles the null case.
4. Differentiate between `null` and `string.Empty`:
   - What is `string.IsNullOrEmpty()`?
   - What is `string.IsNullOrWhiteSpace()`?
5. When would you use each?

---

### Q9 — Conceptual: String Interning

Research and explain:
1. What is string interning in C#?
2. Why does the following code behave the way it does?
   ```csharp
   string a = "hello";
   string b = "hello";
   Console.WriteLine(a == b);           // True
   Console.WriteLine(ReferenceEquals(a, b)); // True (for literals)
   ```
3. Does this happen for strings created at runtime (e.g., from `Console.ReadLine()`)? Why or why not?