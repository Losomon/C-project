# C# Variables

<details>
<summary><strong>Lesson Information</strong></summary>

- **Level:** 01 — Programming Fundamentals
- **Topic:** 01 — Variables
- **Language:** C#
- **Difficulty:** Beginner
- **Learning Resource:** [W3Schools — C# Variables](https://www.w3schools.com/cs/cs_variables.php)

</details>

---

## 1. Introduction to Variables

Variables are containers used to store data values in a computer program.

Think of a variable as a labelled container where information is kept so that the program can use it later.

For example:

- A variable can store someone's name.
- A variable can store someone's age.
- A variable can store the price of a product.
- A variable can store whether a student is registered.

In C#, every variable must have a data type that determines what kind of information it can store.

### Example

```csharp
string name = "John";
int age = 25;

Console.WriteLine(name);
Console.WriteLine(age);
```

**Output:**

```text
John
25
```

In this example:

- `name` stores the text `"John"`.
- `age` stores the whole number `25`.

---

## 2. Types of Variables

C# provides different types of variables for storing different kinds of information.

| Data Type | Description               | Example           |
| --------- | ------------------------- | ----------------- |
| `int`     | Stores whole numbers      | `123`, `-123`     |
| `double`  | Stores decimal numbers    | `19.99`, `-19.99` |
| `char`    | Stores a single character | `'A'`, `'b'`      |
| `string`  | Stores text               | `"Hello World"`   |
| `bool`    | Stores true or false      | `true`, `false`   |

### Example

```csharp
// Stores a whole number.
int myNum = 5;

// Stores a decimal number.
double myDoubleNum = 5.99D;

// Stores a single character.
char myLetter = 'D';

// Stores a true or false value.
bool myBool = true;

// Stores text.
string myText = "Hello";

// Display the variables.
Console.WriteLine(myNum);
Console.WriteLine(myDoubleNum);
Console.WriteLine(myLetter);
Console.WriteLine(myBool);
Console.WriteLine(myText);
```

**Output:**

```text
5
5.99
D
True
Hello
```

**Note:** The `D` suffix in `5.99D` explicitly identifies the number as a `double`. It is optional in this example because decimal-point numeric literals are `double` by default.

More about these types will be covered in **Topic 02 — Data Types**.

---

## 3. Declaring (Creating) Variables

Declaring a variable means creating it so that the program can use it.

To declare a variable in C#, specify its data type, its name, and optionally its initial value.

### Syntax

```csharp
type variableName = value;
```

### Explanation

| Part           | Meaning                        |
| -------------- | ------------------------------ |
| `type`         | The kind of data to store      |
| `variableName` | The name given to the variable |
| `=`            | Assigns a value                |
| `value`        | The information being stored   |
| `;`            | Ends the statement             |

### Example 1: Creating a string variable

```csharp
// Create a string variable called name.
string name = "John";

// Display the value.
Console.WriteLine(name);
```

**Output:**

```text
John
```

### Example 2: Creating an integer variable

```csharp
// Create an integer variable called myNum.
int myNum = 15;

// Display the value.
Console.WriteLine(myNum);
```

**Output:**

```text
15
```

---

## 4. Declaring Variables Without Assigning Values

C# also allows you to declare a variable without immediately assigning a value.

You can assign the value later, provided you assign it before using it.

### Example

```csharp
// Declare an integer variable.
int myNum;

// Assign a value later.
myNum = 15;

// Display the value.
Console.WriteLine(myNum);
```

**Output:**

```text
15
```

**Important:** A local variable must be definitely assigned before it is read. Trying to display `myNum` before assigning a value causes a compiler error.

---

## 5. Changing Variable Values

Variables can be updated after they have been created.

When you assign a new value to an existing variable, the previous value is replaced.

### Example

```csharp
// Create a variable and store 15.
int myNum = 15;

// Change the existing value to 20.
myNum = 20;

// Display the updated value.
Console.WriteLine(myNum);
```

**Output:**

```text
20
```

Notice that we did not write `int` again.

We only wrote:

```csharp
myNum = 20;
```

This is because the variable was already declared.

### Practical Example

```csharp
// Store the initial bank balance.
int balance = 500;

// Display the initial balance.
Console.WriteLine("Initial balance: " + balance);

// Add money to the balance.
balance = 700;

// Display the updated balance.
Console.WriteLine("Updated balance: " + balance);
```

**Output:**

```text
Initial balance: 500
Updated balance: 700
```

---

## 6. Multiple Variables

You can declare multiple variables of the same data type in a single statement.

### Example

```csharp
// Declare three integer variables.
int x = 5, y = 10, z = 15;

// Display their values.
Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);
```

**Output:**

```text
5
10
15
```

You can also declare each variable separately:

```csharp
int x = 5;
int y = 10;
int z = 15;
```

For beginners, separate declarations can make code easier to understand.

---

## 7. Practical Application: Student Information System

Let's apply what we have learned by creating a simple student information program.

### Code

```csharp
// Store student information.
string studentName = "John";
int studentAge = 21;
string course = "Computer Science";
string university = "Kirinyaga University";
bool isEnrolled = true;

// Display student information.
Console.WriteLine("STUDENT INFORMATION");
Console.WriteLine("-------------------");

Console.WriteLine("Name: " + studentName);
Console.WriteLine("Age: " + studentAge);
Console.WriteLine("Course: " + course);
Console.WriteLine("University: " + university);
Console.WriteLine("Enrolled: " + isEnrolled);
```

### Expected Output

```text
STUDENT INFORMATION
-------------------
Name: John
Age: 21
Course: Computer Science
University: Kirinyaga University
Enrolled: True
```

### What did we learn?

This program demonstrates how variables can store different pieces of information and how those values can be displayed when needed.

The same concept is used in:

- Student management systems.
- Banking applications.
- E-commerce websites.
- Inventory management systems.
- Hospital management systems.

---

## 8. Key Takeaways

By completing this lesson, you should understand:

- What variables are.
- Why programs need variables.
- How to declare and initialize variables.
- The difference between declaring and assigning.
- How to update existing variable values.
- How to declare multiple variables.
- How to display stored information.

---

## 9. Exercises

Try completing these exercises without copying the examples.

### Exercise 01 — Personal Information

Create variables to store:

1. Your full name.
2. Your age.
3. Your course.
4. Your university.
5. Your favourite programming language.

Display all five values.

### Exercise 02 — Bank Balance

Create an integer variable:

```csharp
int balance = 500;
```

Your program should:

1. Display the original balance.
2. Add 200 to the balance.
3. Display the updated balance.
4. Subtract 100.
5. Display the final balance.

**Expected Output:**

```text
Original balance: 500
Updated balance: 700
Final balance: 600
```

### Exercise 03 — Product Information

Create variables for:

- Product name.
- Product price.
- Product quantity.

Calculate the total price and display a simple product receipt.

### Exercise 04 — Variable Updates

Create an integer variable called `score` and assign it the value `50`.

Then:

1. Display the original score.
2. Change the score to `80`.
3. Display the updated score.
4. Add `10` to the score.
5. Display the final score.

---

## 10. Assessment

Before proceeding to the next topic, make sure you can answer:

1. What is a variable?
2. What is the purpose of a data type?
3. What is the difference between declaring and assigning a variable?
4. How do you change an existing variable's value?
5. What is the difference between `char` and `string`?
6. Why must a local variable be assigned before it is used?

---

---

## 11. C# Constants

### What is a constant?

A constant is a variable whose value cannot be changed after it has been declared and initialized.

In C#, we use the `const` keyword to create a constant.

**Syntax:**

```csharp
const dataType CONSTANT_NAME = value;
```

### Example

```csharp
// Declare a constant integer.
const int myNum = 15;

// Display the constant value.
Console.WriteLine(myNum);
```

**Output:**

```text
15
```

### Trying to change a constant

Once a constant has been assigned a value, you cannot change it.

```csharp
const int myNum = 15;

// This causes a compilation error.
myNum = 20;
```

The compiler will reject this assignment because `myNum` is a constant.

### Practical Example: Product Price

Imagine a shopping application where a product has a fixed base price.

```csharp
// Declare a constant product price.
const double productPrice = 1500.00;

// Display the product price.
Console.WriteLine("Product Price: " + productPrice);
```

**Output:**

```text
Product Price: 1500
```

### When should you use constants?

Use constants when a value should not change during program execution.

Examples include:

- Mathematical values such as PI.
- Fixed conversion factors.
- Application-wide fixed limits.
- Values that are intentionally defined at compile time.

**Important:** A `const` value must be initialized when declared. If you need a value that is assigned once at runtime, C# also provides `readonly`, which we can study later.

---

## 12. C# Display Variables

### What does displaying a variable mean?

Displaying a variable means showing the value stored inside it.

In C#, we commonly use:

```csharp
Console.WriteLine();
```

We can combine text and variables using the `+` operator.

### Example 1: Combining text and a variable

```csharp
// Create a string variable.
string name = "John";

// Display text together with the variable.
Console.WriteLine("Hello " + name);
```

**Output:**

```text
Hello John
```

Here, the `+` operator joins the text `"Hello "` with the value stored in `name`.

This operation is called string concatenation.

### Example 2: Combining two string variables

```csharp
// Create two string variables.
string firstName = "John ";
string lastName = "Doe";

// Combine both variables.
string fullName = firstName + lastName;

// Display the full name.
Console.WriteLine(fullName);
```

**Output:**

```text
John Doe
```

### Example 3: Adding numeric variables

The `+` operator can also perform mathematical addition when used with numbers.

```csharp
// Create two integer variables.
int x = 5;
int y = 6;

// Add both values and display the result.
Console.WriteLine(x + y);
```

**Output:**

```text
11
```

### Understanding the difference

The `+` operator behaves differently depending on the values being combined.

| Example           | Operation                  | Result     |
| ----------------- | -------------------------- | ---------- |
| `"John " + "Doe"` | Joins text                 | `John Doe` |
| `5 + 6`           | Adds numbers               | `11`       |
| `"Age: " + 20`    | Combines text and a number | `Age: 20`  |

**Remember:** When you use `+` with strings, it joins them. When you use it with numeric values, it performs addition.

---

## 13. C# Multiple Variables

C# allows you to declare multiple variables of the same data type in one statement.

This can make your code shorter.

### Example 1: Declaring multiple variables

```csharp
// Declare three integer variables in one statement.
int x = 5, y = 6, z = 50;

// Add all three values.
Console.WriteLine(x + y + z);
```

**Output:**

```text
61
```

### Example 2: Assigning the same value to multiple variables

You can also assign one value to multiple variables.

```csharp
// Declare three integer variables.
int x, y, z;

// Assign 50 to all three variables.
x = y = z = 50;

// Add all three values.
Console.WriteLine(x + y + z);
```

**Output:**

```text
150
```

### Example 3: Practical application

Imagine calculating the total quantity of products in a small shop.

```csharp
// Store product quantities.
int laptops = 5, phones = 10, tablets = 8;

// Calculate the total quantity.
int totalProducts = laptops + phones + tablets;

// Display the result.
Console.WriteLine("Total Products: " + totalProducts);
```

**Output:**

```text
Total Products: 23
```

**Good practice:** Although multiple declarations are allowed, use separate declarations when the variables have different meanings or when doing so improves readability.

---

## 14. C# Identifiers

### What is an identifier?

An identifier is the name used to identify a variable, method, class, or other programming element.

For example:

```csharp
int studentAge = 20;
```

In this statement, `studentAge` is the identifier.

Identifiers help programmers understand what information is being stored or what a particular part of the program does.

### Variable naming rules

C# has rules that must be followed when naming variables.

| Rule                                          | Explanation                                                    |
| --------------------------------------------- | -------------------------------------------------------------- |
| Letters are allowed                           | `student`                                                      |
| Numbers are allowed after the first character | `student1`                                                     |
| Underscores are allowed                       | `student_age`                                                  |
| Cannot start with a number                    | `1student` is invalid                                          |
| Cannot contain spaces                         | `student age` is invalid                                       |
| Names are case-sensitive                      | `myVar` and `myvar` are different                              |
| Reserved keywords cannot be used directly     | `int`, `class`, and `return` cannot be ordinary variable names |

### Example 1: Good naming

```csharp
// Descriptive variable names.
int studentAge = 20;
double productPrice = 500.00;
string customerName = "John";
```

These names explain what each variable represents.

### Example 2: Poor naming

```csharp
// Names that are difficult to understand.
int x = 20;
double p = 500.00;
string n = "John";
```

Although these names are valid, another programmer may struggle to understand their purpose.

### Example 3: Case sensitivity

```csharp
// These are two different variables.
int age = 20;
int Age = 30;

// Display both values.
Console.WriteLine(age);
Console.WriteLine(Age);
```

**Output:**

```text
20
30
```

C# distinguishes between uppercase and lowercase letters.

### C# naming convention

A common C# convention for local variables is **camelCase**.

Examples:

```csharp
string firstName = "John";
int studentAge = 21;
double totalPrice = 2500.00;
bool isRegistered = true;
```

The first word begins with a lowercase letter, and each following word starts with an uppercase letter.

Use descriptive names that explain the purpose of the variable.

---

## 15. Summary — What We Have Learned

| Concept            | Meaning                                     |
| ------------------ | ------------------------------------------- |
| Variables          | Store data values                           |
| Constants          | Store values that cannot be reassigned      |
| Display Variables  | Show variable values using console output   |
| Multiple Variables | Declare or assign several variables         |
| Identifiers        | Names used to identify programming elements |

### Important C# Keywords and Symbols

| Keyword / Symbol | Purpose                            |
| ---------------- | ---------------------------------- |
| `int`            | Declares an integer variable       |
| `string`         | Declares a text variable           |
| `double`         | Declares a decimal number variable |
| `const`          | Declares a constant                |
| `=`              | Assigns a value                    |
| `+`              | Adds numbers or joins strings      |
| `;`              | Ends a statement                   |

---

## 16. Additional Exercises

### Exercise 05 — Constants

1. Create a constant called `country` and assign it `"Kenya"`.
2. Display its value.
3. Try changing its value and observe the compiler error.
4. Explain why the compiler rejects the change.

### Exercise 06 — Display Variables

Create two string variables:

- `firstName`
- `lastName`

Combine them into a third variable called `fullName`.

Display:

```text
Full Name: Your Full Name
```

### Exercise 07 — Multiple Variables

Create three integer variables:

- `firstNumber = 10`
- `secondNumber = 20`
- `thirdNumber = 30`

Calculate and display their total.

### Exercise 08 — Identifiers

Identify which of these variable names are valid:

```csharp
studentName
2student
student_age
student age
totalPrice
myVar
myvar
class
```

Explain why the invalid names are not allowed.

---

## 17. Lesson Completion Checklist

- [ ] Understand variables.
- [ ] Understand variable data types at an introductory level.
- [ ] Declare and initialize variables.
- [ ] Declare variables without immediately assigning values.
- [ ] Update existing variables.
- [ ] Understand constants.
- [ ] Display and combine variables.
- [ ] Declare multiple variables.
- [ ] Understand identifier naming rules.
- [ ] Complete all practical exercises.
- [ ] Pass the lesson assessment.

---

## Next Topic

**Topic 02 — C# Data Types**

We will explore the different data types in C#, their differences, their uses, and how to choose the correct type when developing applications.

## [Continue to C# Data Types](cs-data-types.md)

_Learn the concept. Understand the syntax. Write the code. Practice until you can build it independently._
