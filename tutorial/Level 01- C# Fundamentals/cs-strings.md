C# Strings
Strings are used to store text. In C#, the string type represents a sequence of characters.

1. Declaring Strings
   A string value is written inside double quotation marks.
   string greeting = "Hello";
   string message = "Nice to meet you!";
   A string can contain one word, several words, or a complete sentence.
2. String Length
   Use the Length property to find how many characters a string contains. Spaces and punctuation are counted too.
   string text = "Hello World";

Console.WriteLine(text.Length); // Output: 11 3. Useful String Methods
ToUpper()
Returns a copy of the string with letters converted to uppercase.
string text = "Hello World";

Console.WriteLine(text.ToUpper()); // Output: HELLO WORLD
ToLower()
Returns a copy of the string with letters converted to lowercase.
string text = "Hello World";

Console.WriteLine(text.ToLower()); // Output: hello world
Important: Strings are immutable in C#. These methods return new strings; they do not modify the original string. 4. String Concatenation
Concatenation means joining strings together.
Using the + operator
string firstName = "John ";
string lastName = "Doe";

string fullName = firstName + lastName;

Console.WriteLine(fullName); // Output: John Doe
The space after "John " separates the two names.
Using string.Concat()
string firstName = "John ";
string lastName = "Doe";

string fullName = string.Concat(firstName, lastName);

Console.WriteLine(fullName); // Output: John Doe 5. Adding Numbers and Strings
C# uses + for both numeric addition and string concatenation. The result depends on the types being combined.
Adding numbers
int x = 10;
int y = 20;

int result = x + y;

Console.WriteLine(result); // Output: 30
Joining strings
string x = "10";
string y = "20";

string result = x + y;

Console.WriteLine(result); // Output: 1020
The values "10" and "20" are strings, not integers, so they are joined instead of added. 6. String Interpolation
String interpolation inserts variable values into a string. Put $ before the opening quotation mark and place variable names inside curly braces {}.
string firstName = "John";
string lastName = "Doe";

string fullName = $"My full name is: {firstName} {lastName}";

Console.WriteLine(fullName);
// Output: My full name is: John Doe
Interpolation is often easier to read than joining many strings with +. 7. Accessing Characters in a String
Each character has an index. C# string indexes start at 0.

For "Hello":
Index Character
0 H
1 e
2 l
3 l
4 o

string text = "Hello";

Console.WriteLine(text[0]); // Output: H
Console.WriteLine(text[1]); // Output: e
An index outside the valid range causes an IndexOutOfRangeException. 8. Finding a Character's Position with IndexOf()
The IndexOf() method returns the zero-based position of the first matching character or substring. If it is not found, it returns -1.
string text = "Hello";

Console.WriteLine(text.IndexOf("e")); // Output: 1
Console.WriteLine(text.IndexOf("z")); // Output: -1 9. Extracting Part of a String with Substring()
Substring() returns part of a string.

- Substring(startIndex) returns the characters from that index to the end.
- Substring(startIndex, length) returns the specified number of characters from that index.
  string name = "John Doe";

int position = name.IndexOf("D");
string lastName = name.Substring(position);

Console.WriteLine(lastName); // Output: Doe
Another example:
string text = "Hello World";

string part = text.Substring(0, 5);

Console.WriteLine(part); // Output: Hello 10. Special Characters and Escape Sequences
Some characters have special meanings inside a string. Use a backslash (\) to include certain special characters.
Escape sequence Result Meaning
\' ' Single quote
\" " Double quote
\\ \ Backslash
\n New line Moves text to a new line
\t Tab Adds a horizontal tab
\b Backspace Represents a backspace character

Double quotes inside a string
string text = "She said, \"Hello!\"";

Console.WriteLine(text);
// Output: She said, "Hello!"
Single quote inside a string
string text = "It's alright.";

Console.WriteLine(text);
A single quote does not need escaping inside a normal double-quoted C# string.
Backslash inside a string
string path = "C:\\Users\\Student\\Documents";

Console.WriteLine(path);
// Output: C:\Users\Student\Documents
New line with \n
string text = "First line\nSecond line";

Console.WriteLine(text);
Output:
First line
Second line
Tab with \t
string text = "Name:\tJohn";

Console.WriteLine(text);
// Output: Name: John 11. Complete Practice Program
string firstName = "John";
string lastName = "Doe";

string fullName = $"{firstName} {lastName}";

Console.WriteLine($"Full name: {fullName}");
Console.WriteLine($"Name length: {fullName.Length}");
Console.WriteLine($"Uppercase: {fullName.ToUpper()}");
Console.WriteLine($"Lowercase: {fullName.ToLower()}");
Console.WriteLine($"First character: {fullName[0]}");
Console.WriteLine($"Position of D: {fullName.IndexOf("D")}");
Console.WriteLine($"Last name: {fullName.Substring(fullName.IndexOf("D"))}"); 12. Exercises
Try solving these without looking at the examples.

1. Create a string variable called school and store the name of your school.
2. Print the number of characters in school.
3. Convert the school name to uppercase and lowercase.
4. Create firstName and lastName variables and join them into fullName.
5. Rewrite the full-name output using string interpolation.
6. Given string word = "Programming";, print the first and fourth characters.
7. Find the index of "g" in "Programming".
8. Extract "World" from "Hello World" using Substring().
9. Print She said, "C# is interesting!" using an escaped double quote.
10. Print two lines using \n and align two values using \t.
    Key Points to Remember

- A string stores text inside double quotes.
- Length returns the number of characters in a string.
- ToUpper() and ToLower() return converted strings.
- - and string.Concat() can join strings.
- $"..." enables string interpolation.
- String indexes start at 0.
- IndexOf() finds a position and returns -1 when no match is found.
- Substring() extracts part of a string.
- Escape sequences let you include special characters in strings.
- Strings are immutable: string operations return new strings rather than changing the original.
