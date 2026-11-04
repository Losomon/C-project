# C# Strings

---

## 1. What Is a String?

A `string` is used to store text. It contains a collection of characters surrounded by double quotes (`"`).

```csharp
string greeting = "Hello";
```

Strings can contain:

- Letters
- Numbers
- Spaces
- Symbols
- Sentences

```csharp
string name = "Solomon";
string message = "Welcome to C# programming!";
```

---

## 2. Creating a String

### Syntax

```csharp
string variableName = "text";
```

### Example

```csharp
// Create a string variable and assign text to it
string name = "John";

// Display the string
Console.WriteLine(name);
```

**Output:**

```text
John
```

---

## 3. String Length

The `Length` property returns the number of characters in a string, including spaces.

```csharp
string text = "Hello";

// Get the number of characters
int length = text.Length;

Console.WriteLine(length);
```

**Output:**

```text
5
```

---

## 4. Accessing Characters

You can access a character in a string using its index.

Indexes start at `0`.

```csharp
string name = "John";

// Access the first character
Console.WriteLine(name[0]);

// Access the second character
Console.WriteLine(name[1]);
```

**Output:**

```text
J
o
```

---

## 5. Changing to Uppercase and Lowercase

Use `ToUpper()` to convert a string to uppercase.

Use `ToLower()` to convert a string to lowercase.

```csharp
string name = "Solomon";

// Convert the string to uppercase
Console.WriteLine(name.ToUpper());

// Convert the string to lowercase
Console.WriteLine(name.ToLower());
```

**Output:**

```text
SOLOMON
solomon
```

These methods return a new string. They do not modify the original string.

---

## 6. String Concatenation

Concatenation means joining strings together.

Use the `+` operator to join strings.

```csharp
string firstName = "Solomon";
string lastName = "Mwangi";

// Join the two strings with a space
string fullName = firstName + " " + lastName;

Console.WriteLine(fullName);
```

**Output:**

```text
Solomon Mwangi
```

---

## 7. String Interpolation

String interpolation allows you to insert variables directly into a string.

Place `$` before the opening quotation mark and put variables inside `{}`.

```csharp
string name = "Solomon";
int age = 21;

// Insert variables into the message
Console.WriteLine($"My name is {name} and I am {age} years old.");
```

**Output:**

```text
My name is Solomon and I am 21 years old.
```

String interpolation is often easier to read than concatenation.

---

## 8. Special Characters

Some characters have special meanings inside strings.

| Character | Meaning               |
| --------- | --------------------- |
| `\"`      | Double quotation mark |
| `\'`      | Single quotation mark |
| `\\`      | Backslash             |
| `\n`      | New line              |
| `\t`      | Tab                   |

### Example

```csharp
// Include quotation marks inside a string
Console.WriteLine("He said, \"Hello!\"");

// Print text on separate lines
Console.WriteLine("Hello\nWorld");

// Add a tab between words
Console.WriteLine("Name:\tSolomon");
```

**Output:**

```text
He said, "Hello!"
Hello
World
Name:    Solomon
```

---

## 9. Checking Whether a String Contains Text

The `Contains()` method checks whether a string contains a specified sequence of characters.

It returns a Boolean value: `true` or `false`.

```csharp
string message = "Welcome to C#";

// Check whether the string contains C#
Console.WriteLine(message.Contains("C#"));

// Check whether the string contains Java
Console.WriteLine(message.Contains("Java"));
```

**Output:**

```text
True
False
```

---

## 10. Replacing Text

The `Replace()` method replaces one part of a string with another.

```csharp
string message = "I like Java";

// Replace Java with C#
string updatedMessage = message.Replace("Java", "C#");

Console.WriteLine(updatedMessage);
```

**Output:**

```text
I like C#
```

---

## 11. Removing Extra Whitespace

The `Trim()` method removes whitespace from the beginning and end of a string.

```csharp
string name = "   Solomon   ";

// Remove whitespace from both ends
string cleanedName = name.Trim();

Console.WriteLine(cleanedName);
```

**Output:**

```text
Solomon
```

`Trim()` does not remove spaces between words.

---

## 12. Real-World Application

Strings are commonly used for:

- Usernames and names
- Email addresses
- Product names
- Search queries
- Messages and notifications
- Address and location information

### Example: Creating a User Profile Message

```csharp
string firstName = "Solomon";
string role = "Software Engineer";
string country = "Kenya";

// Create a profile message using string interpolation
string profile = $"My name is {firstName}. I am a {role} from {country}.";

// Display the profile
Console.WriteLine(profile);
```

**Output:**

```text
My name is Solomon. I am a Software Engineer from Kenya.
```

---

## 13. Exercises

Try solving these without looking at the solutions.

### Exercise 1: Create a String

Create a string variable called `school` and assign your school name to it. Print it.

### Exercise 2: String Length

Create a string containing your first name. Print the number of characters.

### Exercise 3: Uppercase and Lowercase

Create a string containing `"CSharp Programming"`. Print it in uppercase and lowercase.

### Exercise 4: Concatenation

Create `firstName` and `lastName` variables. Join them into a full name with a space between them.

### Exercise 5: String Interpolation

Create variables for your name, age, and course. Print them in one sentence using string interpolation.

### Exercise 6: Replace Text

Create the string `"I am learning Java"`. Replace `"Java"` with `"C#"` and print the result.

### Exercise 7: Check Text

Create the string `"Welcome to programming"`. Check whether it contains `"programming"`.

### Exercise 8: Clean User Input

Create a string containing spaces before and after a name. Use `Trim()` and print the cleaned name.

---

## 14. Summary

| Concept       | Description                                   |
| ------------- | --------------------------------------------- |
| `string`      | Stores text                                   |
| `.Length`     | Returns the number of characters              |
| `[index]`     | Accesses a character                          |
| `.ToUpper()`  | Converts text to uppercase                    |
| `.ToLower()`  | Converts text to lowercase                    |
| `+`           | Joins strings                                 |
| `$"..."`      | Inserts variables into strings                |
| `.Contains()` | Checks whether text exists                    |
| `.Replace()`  | Replaces part of a string                     |
| `.Trim()`     | Removes whitespace from the beginning and end |

**Next topic:** C# Booleans
