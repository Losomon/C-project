
// ========================================
// C# STRINGS - CODE EXAMPLES
// File: 07-strings.cs
// ========================================

// EXAMPLE 1: Creating a string
// A string stores text inside double quotes.
string greeting = "Hello";

// Display the string
Console.WriteLine(greeting);


// EXAMPLE 2: String length
// Length returns the number of characters.
string word = "Hello";

Console.WriteLine(word.Length); // Output: 5


// EXAMPLE 3: Accessing characters
// String indexes begin at 0.
string name = "John";

Console.WriteLine(name[0]); // Output: J
Console.WriteLine(name[1]); // Output: o


// EXAMPLE 4: Uppercase and lowercase
string language = "CSharp Programming";

Console.WriteLine(language.ToUpper()); // Output: CSHARP PROGRAMMING
Console.WriteLine(language.ToLower()); // Output: csharp programming


// EXAMPLE 5: String concatenation
// The + operator joins strings.
string firstName = "Solomon";
string lastName = "Mwangi";

string fullName = firstName + " " + lastName;

Console.WriteLine(fullName); // Output: Solomon Mwangi


// EXAMPLE 6: String interpolation
// Use $ before the string and {} around variables.
string studentName = "Solomon";
int age = 21;

Console.WriteLine($"My name is {studentName} and I am {age} years old.");


// EXAMPLE 7: Special characters
// \n creates a new line.
// \t creates a tab.
// \" inserts a double quotation mark.
Console.WriteLine("Hello\nWorld");
Console.WriteLine("Name:\tSolomon");
Console.WriteLine("He said, \"Hello!\"");


// EXAMPLE 8: Checking whether a string contains text
// Contains() returns true or false.
string message = "Welcome to C#";

Console.WriteLine(message.Contains("C#"));   // Output: True
Console.WriteLine(message.Contains("Java")); // Output: False


// EXAMPLE 9: Replacing text
// Replace() returns a new string with the replacement.
string sentence = "I like Java";

string updatedSentence = sentence.Replace("Java", "C#");

Console.WriteLine(updatedSentence); // Output: I like C#


// EXAMPLE 10: Removing extra whitespace
// Trim() removes whitespace from the beginning and end.
string messyName = "   Solomon   ";

string cleanName = messyName.Trim();

Console.WriteLine(cleanName); // Output: Solomon


// EXAMPLE 11: Real-world profile message
string profileName = "Solomon";
string role = "Software Engineer";
string country = "Kenya";

string profile = $"My name is {profileName}. I am a {role} from {country}.";

Console.WriteLine(profile);


// EXAMPLE 12: Combining string methods
string productName = "   face cream   ";

// Remove surrounding spaces and convert to uppercase
string formattedProduct = productName.Trim().ToUpper();

Console.WriteLine(formattedProduct); // Output: FACE CREAM
