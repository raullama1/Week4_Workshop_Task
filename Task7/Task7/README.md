# Task 7: Research Activity

## Part 1: Constructors in Software Development

### What is a Constructor?
A constructor is a special method called by runtime when class or struct is created. It initializes the object's properties and sets up any necessary data.

### Benefits of Constructors
1. Object Initialization: Constructors automatically initialize object properties when a class or struct is instantiated.
2. Code Reliability: Ensures that objects are valid and reduces errors caused by uninitialized data.
3. Maintainability: Centralizes initialization logic in one place, avoiding         repetitive code across the program.


### Real-World Use Cases
1. Bank Account Management: Ensures each account has a valid number and initial balance.
2. E-commerce Product Objects: Products are initialized with proper name and price.
3. Game Characters: Every game character starts with default health and level.

## Resources:  
- [Microsoft Docs: Constructors](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors)
- [Microsoft Docs: Constructors Benefits](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/using-constructors)    

## Part 2: OOP Principle – Encapsulation

### What is Encapsulation?
Encapsulation is a core principle of object-oriented programming (OOP) that combines data (fields) and methods that work on that data into a single unit. It restricts direct access to some parts of an object, ensuring controlled interaction and protecting data from unintended changes.

### Classes and Objects
- Class: Blueprint for creating objects. Contains properties and methods.
- Object: Instance of a class with assigned values.

### Examples
1. Bank Account

    private double balance;
    public void Deposit(double amount) { ... }
    public double GetBalance() { ... }

2. Student Grades

    private int marks;
    public void SetMarks(int m) { ... }
    public int GetMarks() { ... }

## Resources:

- [GeeksforGeeks: Encapsulation](https://www.geeksforgeeks.org/c-sharp/encapsulation-in-c-sharp/) 
- [Microsoft Docs: Classes and Objects](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/classes)
