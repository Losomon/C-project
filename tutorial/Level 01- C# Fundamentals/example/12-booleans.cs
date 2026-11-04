
// ========================================
// C# BOOLEANS - CODE EXAMPLES
// File: 08-booleans.cs
// ========================================


// EXAMPLE 1: Creating Boolean variables
// A bool stores either true or false.
bool isStudent = true;
bool hasGraduated = false;

Console.WriteLine(isStudent);     // Output: True
Console.WriteLine(hasGraduated);  // Output: False


// EXAMPLE 2: Comparison operators
// Comparisons produce Boolean results.
int x = 10;
int y = 5;

Console.WriteLine(x == y); // Output: False
Console.WriteLine(x != y); // Output: True
Console.WriteLine(x > y);  // Output: True
Console.WriteLine(x < y);  // Output: False
Console.WriteLine(x >= y); // Output: True
Console.WriteLine(x <= y); // Output: False


// EXAMPLE 3: Store a comparison in a Boolean variable
int age = 20;

// Check whether the person is at least 18
bool isAdult = age >= 18;

Console.WriteLine(isAdult); // Output: True


// EXAMPLE 4: Using a Boolean in an if...else statement
bool isRaining = true;

if (isRaining)
{
    Console.WriteLine("Take an umbrella.");
}
else
{
    Console.WriteLine("No umbrella needed.");
}


// EXAMPLE 5: AND operator (&&)
// Both conditions must be true.
bool hasUsername = true;
bool hasPassword = true;

bool canLogin = hasUsername && hasPassword;

Console.WriteLine(canLogin); // Output: True


// EXAMPLE 6: OR operator (||)
// At least one condition must be true.
bool isWeekend = false;
bool isHoliday = true;

bool canRelax = isWeekend || isHoliday;

Console.WriteLine(canRelax); // Output: True


// EXAMPLE 7: NOT operator (!)
// NOT reverses a Boolean value.
bool isAvailable = false;

Console.WriteLine(!isAvailable); // Output: True


// EXAMPLE 8: Combining logical operators
int userAge = 22;
bool hasID = true;

// The user must be at least 18 AND have an ID
bool canEnter = userAge >= 18 && hasID;

Console.WriteLine(canEnter); // Output: True


// EXAMPLE 9: Product availability
string productName = "Face Cream";
bool isInStock = true;

if (isInStock)
{
    Console.WriteLine($"{productName} is available.");
}
else
{
    Console.WriteLine($"{productName} is out of stock.");
}


// EXAMPLE 10: Login status
bool isLoggedIn = false;

if (isLoggedIn)
{
    Console.WriteLine("Welcome back!");
}
else
{
    Console.WriteLine("Please log in.");
}


// EXAMPLE 11: Form validation
string email = "user@example.com";
string password = "secret123";

// Simple learning example: check that both fields contain text
bool isFormValid = email != "" && password != "";

Console.WriteLine(isFormValid); // Output: True
