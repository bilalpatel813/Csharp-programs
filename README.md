# 🚀 C# Complete Developer Guide

> A comprehensive reference covering every core concept a C# developer needs to know — from variables to design patterns.

---

## 📋 Table of Contents

1. [Variables](#1-variables)
2. [Data Types](#2-data-types)
3. [Operators](#3-operators)
4. [Conditions](#4-conditions)
5. [Loops](#5-loops)
6. [Methods](#6-methods)
7. [Arrays](#7-arrays)
8. [Classes](#8-classes)
9. [Objects](#9-objects)
10. [Constructors](#10-constructors)
11. [OOP — 4 Pillars](#11-oop--4-pillars)
12. [Collections](#12-collections)
13. [LINQ](#13-linq)
14. [Exception Handling](#14-exception-handling)
15. [Async / Await](#15-async--await)
16. [File Handling](#16-file-handling)
17. [Database (SQL)](#17-database-sql)
18. [ASP.NET Core](#18-aspnet-core)
19. [Unity Game Development](#19-unity-game-development)
20. [Design Patterns](#20-design-patterns)

---

## 1. Variables

A **variable** is a named container that stores a value in memory.

```csharp
// Declaration and assignment
int age = 25;
string name = "Alice";

// var — compiler infers the type
var score = 100;        // inferred as int
var greeting = "Hi";   // inferred as string

// const — value can never change
const double PI = 3.14159;

// Nullable variable — can hold null
int? nullableAge = null;
```

> **Key rule:** C# is *statically typed* — once a variable's type is declared, it cannot change.

---

## 2. Data Types

### Value Types — stored directly on the stack

| Type      | Size     | Example Value       |
|-----------|----------|---------------------|
| `int`     | 32-bit   | `42`                |
| `long`    | 64-bit   | `9_000_000_000L`    |
| `float`   | 32-bit   | `3.14f`             |
| `double`  | 64-bit   | `3.14159`           |
| `decimal` | 128-bit  | `19.99m`            |
| `bool`    | 1-bit    | `true` / `false`    |
| `char`    | 16-bit   | `'A'`               |
| `byte`    | 8-bit    | `255`               |

### Reference Types — stored on the heap, variable holds a reference

```csharp
string  name    = "Alice";          // immutable text
int[]   numbers = { 1, 2, 3 };     // array
object  obj     = new object();     // base of all types
```

### Type Conversion

```csharp
// Implicit (safe, no data loss)
int x = 10;
double y = x;           // int → double is safe

// Explicit cast (may lose data)
double pi = 3.99;
int truncated = (int)pi; // → 3

// Parse string → number
int parsed = int.Parse("42");
bool ok = int.TryParse("abc", out int result); // safe parse

// Convert class
string s = Convert.ToString(123);
int n    = Convert.ToInt32("99");
```

---

## 3. Operators

### Arithmetic

```csharp
int a = 10, b = 3;
int sum  = a + b;   // 13
int diff = a - b;   // 7
int prod = a * b;   // 30
int div  = a / b;   // 3  (integer division)
int mod  = a % b;   // 1  (remainder)
```

### Comparison

```csharp
a == b   // equal
a != b   // not equal
a >  b   // greater than
a <  b   // less than
a >= b   // greater than or equal
a <= b   // less than or equal
```

### Logical

```csharp
bool t = true, f = false;
t && f   // AND  → false
t || f   // OR   → true
!t       // NOT  → false
```

### Assignment Shortcuts

```csharp
int n = 10;
n += 5;   // n = 15
n -= 3;   // n = 12
n *= 2;   // n = 24
n /= 4;   // n = 6
n++;      // n = 7  (post-increment)
++n;      // n = 8  (pre-increment)
```

### Ternary Operator

```csharp
int age = 20;
string status = age >= 18 ? "Adult" : "Minor";
```

### Null-Coalescing

```csharp
string? name = null;
string display = name ?? "Anonymous";           // "Anonymous"
name ??= "Default";                            // assign only if null
string upper = name?.ToUpper() ?? "UNKNOWN";   // safe member access
```

---

## 4. Conditions

### if / else if / else

```csharp
int score = 75;

if (score >= 90)
{
    Console.WriteLine("A");
}
else if (score >= 70)
{
    Console.WriteLine("B");   // ← prints this
}
else
{
    Console.WriteLine("F");
}
```

### switch Statement

```csharp
string day = "Monday";

switch (day)
{
    case "Monday":
        Console.WriteLine("Start of week");
        break;
    case "Friday":
        Console.WriteLine("End of week");
        break;
    default:
        Console.WriteLine("Midweek");
        break;
}
```

### switch Expression (C# 8+)

```csharp
string result = score switch
{
    >= 90 => "A",
    >= 70 => "B",
    >= 50 => "C",
    _     => "F"    // _ is the default
};
```

### Pattern Matching

```csharp
object shape = 3.14;

string description = shape switch
{
    int i    => $"Integer: {i}",
    double d => $"Double: {d}",
    string s => $"String: {s}",
    _        => "Unknown"
};
```

---

## 5. Loops

### for Loop — when you know the number of iterations

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i); // 0, 1, 2, 3, 4
}
```

### while Loop — repeats while condition is true

```csharp
int count = 0;
while (count < 3)
{
    Console.WriteLine(count);
    count++;
}
```

### do-while Loop — always executes at least once

```csharp
int n = 0;
do
{
    Console.WriteLine(n);
    n++;
} while (n < 3);
```

### foreach Loop — iterate over a collection

```csharp
string[] fruits = { "Apple", "Banana", "Cherry" };

foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}
```

### Loop Control Keywords

```csharp
for (int i = 0; i < 10; i++)
{
    if (i == 3) continue;  // skip 3
    if (i == 7) break;     // stop at 7
    Console.WriteLine(i);
}
```

---

## 6. Methods

A **method** is a reusable block of code that performs a task.

```csharp
// Syntax: accessModifier returnType MethodName(parameters)
public int Add(int a, int b)
{
    return a + b;
}

// void — returns nothing
public void Greet(string name)
{
    Console.WriteLine($"Hello, {name}!");
}

// Call the methods
int result = Add(3, 4);  // 7
Greet("Alice");           // Hello, Alice!
```

### Optional & Named Parameters

```csharp
public void PrintInfo(string name, int age = 0)  // default value
{
    Console.WriteLine($"{name}, Age: {age}");
}

PrintInfo("Bob");             // Bob, Age: 0
PrintInfo(age: 30, name: "Carol"); // named args, any order
```

### ref and out Parameters

```csharp
// ref — pass variable by reference (must be initialized)
void Double(ref int x) => x *= 2;
int val = 5;
Double(ref val); // val is now 10

// out — method must assign a value (no need to initialize)
void GetValues(out int a, out int b) { a = 1; b = 2; }
GetValues(out int x, out int y);
```

### Expression-Bodied Methods (C# 6+)

```csharp
public int Square(int n) => n * n;
public string Hello() => "Hello, World!";
```

### Local Functions

```csharp
public int Calculate(int x)
{
    return Helper(x) + 1;

    int Helper(int n) => n * 2;   // defined inside the method
}
```

---

## 7. Arrays

An **array** stores multiple values of the same type in a fixed-size block.

```csharp
// Declare and initialize
int[] numbers = new int[5];           // 5 zeros
int[] filled  = { 10, 20, 30, 40 };  // initialized
int[] explicit = new int[] { 1, 2, 3 };

// Access by index (0-based)
Console.WriteLine(filled[0]);  // 10
filled[1] = 99;                // modify

// Length
Console.WriteLine(filled.Length);  // 4

// Iterate
foreach (int n in filled)
    Console.WriteLine(n);
```

### Multi-Dimensional Arrays

```csharp
// 2D array — like a grid / table
int[,] grid = new int[3, 3];
grid[0, 0] = 1;
grid[1, 2] = 5;

// Jagged array — array of arrays (each row can differ in size)
int[][] jagged = new int[3][];
jagged[0] = new int[] { 1, 2 };
jagged[1] = new int[] { 3, 4, 5 };
```

### Useful Array Methods

```csharp
int[] nums = { 5, 2, 8, 1, 9 };

Array.Sort(nums);                    // { 1, 2, 5, 8, 9 }
Array.Reverse(nums);                 // { 9, 8, 5, 2, 1 }
int idx = Array.IndexOf(nums, 5);   // find index of 5
int[] copy = (int[])nums.Clone();   // shallow copy
```

---

## 8. Classes

A **class** is a blueprint that defines the structure (fields, properties, methods) of an object.

```csharp
public class Car
{
    // Fields — raw data storage
    private string _brand;
    private int    _year;

    // Properties — controlled access to fields
    public string Brand
    {
        get => _brand;
        set => _brand = value;
    }

    // Auto-property (compiler generates the backing field)
    public int Year { get; set; }

    // Method
    public void Start()
    {
        Console.WriteLine($"{Brand} is starting...");
    }

    // Static method — belongs to the class, not an instance
    public static string GetCategory() => "Vehicle";
}
```

### Static vs Instance Members

```csharp
// Instance: each object has its own copy
Car myCar = new Car();
myCar.Brand = "Toyota";

// Static: shared across all instances
string category = Car.GetCategory();   // called on the class
```

---

## 9. Objects

An **object** is an instance of a class — the actual "thing" created from the blueprint.

```csharp
// Create objects using the new keyword
Car car1 = new Car();
car1.Brand = "Toyota";
car1.Year  = 2022;
car1.Start();  // Toyota is starting...

Car car2 = new Car();
car2.Brand = "Honda";
// car1 and car2 are independent objects

// Object initializer syntax
Car car3 = new Car { Brand = "BMW", Year = 2024 };

// Target-typed new (C# 9+)
Car car4 = new() { Brand = "Tesla", Year = 2023 };
```

### Object Comparison

```csharp
// Reference types: == checks reference by default
Car a = new Car { Brand = "X" };
Car b = new Car { Brand = "X" };
bool same = (a == b);  // false — different objects in memory

// Value types: == checks value
int x = 5, y = 5;
bool equal = (x == y); // true
```

---

## 10. Constructors

A **constructor** is a special method that runs automatically when an object is created. It initializes the object's state.

```csharp
public class Person
{
    public string Name { get; }
    public int    Age  { get; }

    // Default constructor (no parameters)
    public Person()
    {
        Name = "Unknown";
        Age  = 0;
    }

    // Parameterized constructor
    public Person(string name, int age)
    {
        Name = name;
        Age  = age;
    }

    // Constructor chaining with : this(...)
    public Person(string name) : this(name, 18) { }
}

// Usage
var p1 = new Person();               // Unknown, 0
var p2 = new Person("Alice", 30);    // Alice, 30
var p3 = new Person("Bob");          // Bob, 18
```

### Static Constructor

Runs once when the class is first used. Good for initializing static data.

```csharp
public class Config
{
    public static string AppName { get; }

    static Config()
    {
        AppName = "MyApp";  // runs only once
    }
}
```

---

## 11. OOP — 4 Pillars

Object-Oriented Programming is built on four core principles.

---

### 1. Encapsulation — hide internal details, expose only what's needed

```csharp
public class BankAccount
{
    private decimal _balance;  // hidden from outside

    public decimal Balance => _balance;  // read-only access

    public void Deposit(decimal amount)
    {
        if (amount > 0) _balance += amount;  // controlled change
    }

    public bool Withdraw(decimal amount)
    {
        if (amount > _balance) return false;
        _balance -= amount;
        return true;
    }
}
```

---

### 2. Inheritance — a child class inherits from a parent class

```csharp
// Base (parent) class
public class Animal
{
    public string Name { get; set; }

    public virtual void Speak()  // virtual = can be overridden
    {
        Console.WriteLine("...");
    }
}

// Derived (child) class
public class Dog : Animal
{
    public override void Speak()  // override the parent
    {
        Console.WriteLine("Woof!");
    }
}

public class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Meow!");
    }
}

// base keyword — call parent's method
public class Puppy : Dog
{
    public override void Speak()
    {
        base.Speak();                   // calls Dog.Speak → "Woof!"
        Console.WriteLine("...yip!");
    }
}
```

---

### 3. Polymorphism — same interface, different behavior

```csharp
// Runtime polymorphism via virtual/override
Animal[] animals = { new Dog(), new Cat(), new Dog() };

foreach (Animal a in animals)
{
    a.Speak();  // each object decides its own behavior
}
// Output: Woof! / Meow! / Woof!

// Compile-time polymorphism via method overloading
public class Printer
{
    public void Print(int n)     => Console.WriteLine($"Int: {n}");
    public void Print(string s)  => Console.WriteLine($"String: {s}");
    public void Print(double d)  => Console.WriteLine($"Double: {d}");
}
```

---

### 4. Abstraction — define *what* without specifying *how*

```csharp
// Abstract class — cannot be instantiated, may have abstract members
public abstract class Shape
{
    public abstract double Area();          // no body — must be implemented

    public void Display()                   // concrete method all shapes share
    {
        Console.WriteLine($"Area: {Area()}");
    }
}

// Interface — a pure contract, no implementation
public interface IDrawable
{
    void Draw();                            // all implementors must define this
}

// Concrete class fulfils both contracts
public class Circle : Shape, IDrawable
{
    public double Radius { get; set; }

    public override double Area() => Math.PI * Radius * Radius;

    public void Draw() => Console.WriteLine("Drawing a circle");
}
```

> **Rule of thumb:**  
> Use an **abstract class** when sharing common code.  
> Use an **interface** when defining a capability contract that unrelated classes can share.

---

## 12. Collections

Collections are resizable, feature-rich alternatives to arrays.

### List\<T\> — ordered, resizable list

```csharp
var fruits = new List<string> { "Apple", "Banana" };

fruits.Add("Cherry");          // add one
fruits.AddRange(new[] { "Date", "Elder" });  // add many
fruits.Remove("Banana");       // remove by value
fruits.RemoveAt(0);            // remove by index

Console.WriteLine(fruits.Count);       // count
Console.WriteLine(fruits.Contains("Cherry")); // true
```

### Dictionary\<TKey, TValue\> — key/value pairs

```csharp
var ages = new Dictionary<string, int>
{
    { "Alice", 30 },
    { "Bob",   25 }
};

ages["Carol"] = 28;            // add or update

if (ages.TryGetValue("Alice", out int age))
    Console.WriteLine(age);    // 30

foreach (var kvp in ages)
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
```

### HashSet\<T\> — unordered, no duplicates

```csharp
var set = new HashSet<int> { 1, 2, 3, 3, 2 };
// set contains: { 1, 2, 3 }

set.Add(4);
set.Remove(1);
bool has = set.Contains(2);   // true

// Set operations
var a = new HashSet<int> { 1, 2, 3 };
var b = new HashSet<int> { 2, 3, 4 };
a.IntersectWith(b);   // { 2, 3 }
a.UnionWith(b);       // { 1, 2, 3, 4 }
```

### Queue\<T\> and Stack\<T\>

```csharp
// Queue — First In, First Out (FIFO)
var queue = new Queue<string>();
queue.Enqueue("First");
queue.Enqueue("Second");
string next = queue.Dequeue();  // "First"

// Stack — Last In, First Out (LIFO)
var stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
int top = stack.Pop();   // 2
int peek = stack.Peek(); // 1 (don't remove)
```

---

## 13. LINQ

**Language Integrated Query** lets you query collections using a fluent, readable syntax directly in C#.

```csharp
var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Where — filter
var evens = numbers.Where(n => n % 2 == 0);
// { 2, 4, 6, 8, 10 }

// Select — transform / project
var squares = numbers.Select(n => n * n);
// { 1, 4, 9, 16, 25, ... }

// OrderBy / OrderByDescending
var sorted = numbers.OrderByDescending(n => n);

// First, Last, Single
int first  = numbers.First(n => n > 5);   // 6
int last   = numbers.Last(n => n < 5);    // 4

// Any / All / Count
bool anyBig  = numbers.Any(n => n > 9);   // true
bool allPos  = numbers.All(n => n > 0);   // true
int  count   = numbers.Count(n => n % 2 == 0);  // 5

// Sum, Average, Min, Max
double avg = numbers.Average();
int    sum = numbers.Sum();

// Chaining multiple operations
var result = numbers
    .Where(n => n % 2 == 0)
    .Select(n => n * 10)
    .OrderByDescending(n => n)
    .ToList();
// { 100, 80, 60, 40, 20 }
```

### LINQ with Objects

```csharp
var people = new List<Person>
{
    new Person { Name = "Alice", Age = 30 },
    new Person { Name = "Bob",   Age = 25 },
    new Person { Name = "Carol", Age = 35 },
};

var names = people
    .Where(p => p.Age > 27)
    .OrderBy(p => p.Name)
    .Select(p => p.Name)
    .ToList();
// { "Alice", "Carol" }

// GroupBy
var grouped = people.GroupBy(p => p.Age > 30 ? "Senior" : "Junior");
```

### Query Syntax (SQL-like)

```csharp
var query = from p in people
            where p.Age > 27
            orderby p.Name
            select p.Name;
```

---

## 14. Exception Handling

Exceptions are runtime errors. Handling them prevents crashes and allows graceful recovery.

```csharp
try
{
    int[] arr = { 1, 2, 3 };
    Console.WriteLine(arr[10]);   // throws IndexOutOfRangeException
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine($"Index error: {ex.Message}");
}
catch (Exception ex)            // catch any other exception
{
    Console.WriteLine($"General error: {ex.Message}");
}
finally
{
    // Always runs — good for cleanup (close file, DB connection, etc.)
    Console.WriteLine("Done.");
}
```

### Throwing Exceptions

```csharp
public void SetAge(int age)
{
    if (age < 0 || age > 150)
        throw new ArgumentOutOfRangeException(nameof(age), "Age must be 0–150.");
}
```

### Custom Exceptions

```csharp
public class InsufficientFundsException : Exception
{
    public decimal Amount { get; }

    public InsufficientFundsException(decimal amount)
        : base($"Insufficient funds. Needed: {amount}")
    {
        Amount = amount;
    }
}

// Usage
throw new InsufficientFundsException(500m);
```

### Common Built-in Exceptions

| Exception                      | Cause                              |
|--------------------------------|------------------------------------|
| `NullReferenceException`       | Access on a null object            |
| `ArgumentNullException`        | Required argument was null         |
| `ArgumentOutOfRangeException`  | Value outside allowed range        |
| `InvalidOperationException`    | Method call invalid for current state |
| `IndexOutOfRangeException`     | Array index out of bounds          |
| `DivideByZeroException`        | Division by zero (integers)        |
| `FileNotFoundException`        | File not found                     |
| `FormatException`              | Parsing a bad string format        |

---

## 15. Async / Await

Asynchronous programming lets your app do other work while waiting for slow operations (network, disk, database) without blocking the thread.

```csharp
using System.Net.Http;

// async methods return Task, Task<T>, or void (only for events)
public async Task<string> FetchDataAsync(string url)
{
    using var client = new HttpClient();

    // await pauses this method and frees the thread
    string content = await client.GetStringAsync(url);

    return content;
}

// Calling an async method
public async Task RunAsync()
{
    string data = await FetchDataAsync("https://example.com/api");
    Console.WriteLine(data);
}
```

### Task.WhenAll — run multiple tasks concurrently

```csharp
public async Task FetchAllAsync()
{
    var task1 = FetchDataAsync("https://api.example.com/users");
    var task2 = FetchDataAsync("https://api.example.com/orders");

    // Both requests fire simultaneously
    string[] results = await Task.WhenAll(task1, task2);
    Console.WriteLine(results[0]);
    Console.WriteLine(results[1]);
}
```

### CancellationToken — allow cancelling async work

```csharp
public async Task LongWorkAsync(CancellationToken token)
{
    for (int i = 0; i < 100; i++)
    {
        token.ThrowIfCancellationRequested();  // check for cancel
        await Task.Delay(100, token);
    }
}

// Usage
var cts = new CancellationTokenSource();
cts.CancelAfter(TimeSpan.FromSeconds(5));  // cancel after 5s
await LongWorkAsync(cts.Token);
```

> **Golden rules:**  
> ✅ Always `await` async methods.  
> ✅ Name async methods with the `Async` suffix.  
> ❌ Avoid `async void` (except event handlers).  
> ❌ Avoid `.Result` or `.Wait()` — they can deadlock.

---

## 16. File Handling

```csharp
using System.IO;

// --- Write ---
// Write all text (overwrites)
File.WriteAllText("hello.txt", "Hello, World!");

// Append text
File.AppendAllText("hello.txt", "\nAnother line");

// Write multiple lines
File.WriteAllLines("list.txt", new[] { "Line 1", "Line 2", "Line 3" });

// --- Read ---
string content    = File.ReadAllText("hello.txt");
string[] lines    = File.ReadAllLines("hello.txt");

// --- Check & Delete ---
if (File.Exists("hello.txt"))
    File.Delete("hello.txt");
```

### StreamWriter / StreamReader — for large files

```csharp
// Write line by line (efficient for large data)
using (var writer = new StreamWriter("log.txt", append: true))
{
    writer.WriteLine($"[{DateTime.Now}] Application started");
    writer.WriteLine("Another log entry");
}   // automatically closed

// Read line by line
using (var reader = new StreamReader("log.txt"))
{
    string? line;
    while ((line = reader.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}
```

### Working with Paths and Directories

```csharp
// Path helpers
string full = Path.GetFullPath("data.txt");          // absolute path
string name = Path.GetFileNameWithoutExtension("app.exe"); // "app"
string ext  = Path.GetExtension("image.png");        // ".png"
string dir  = Path.GetDirectoryName("C:/app/data.txt"); // "C:/app"
string combined = Path.Combine("folder", "sub", "file.txt");

// Directory operations
Directory.CreateDirectory("logs");
string[] files = Directory.GetFiles("logs", "*.txt");
Directory.Delete("logs", recursive: true);
```

---

## 17. Database (SQL)

C# connects to SQL databases using **ADO.NET** (low-level) or **Entity Framework Core** (ORM).

### ADO.NET — direct SQL

```csharp
using System.Data.SqlClient;

string connStr = "Server=localhost;Database=MyDb;Integrated Security=true;";

using var conn = new SqlConnection(connStr);
conn.Open();

// --- Query ---
using var cmd = new SqlCommand("SELECT Id, Name FROM Users WHERE Age > @Age", conn);
cmd.Parameters.AddWithValue("@Age", 18);    // prevents SQL injection

using var reader = cmd.ExecuteReader();
while (reader.Read())
{
    int    id   = reader.GetInt32(0);
    string name = reader.GetString(1);
    Console.WriteLine($"{id}: {name}");
}

// --- Insert ---
using var insert = new SqlCommand(
    "INSERT INTO Users (Name, Age) VALUES (@Name, @Age)", conn);
insert.Parameters.AddWithValue("@Name", "Alice");
insert.Parameters.AddWithValue("@Age", 30);
int rows = insert.ExecuteNonQuery();   // returns number of affected rows
```

### Entity Framework Core — ORM approach

```csharp
// 1. Install: dotnet add package Microsoft.EntityFrameworkCore.SqlServer

// 2. Define entity
public class User
{
    public int    Id   { get; set; }
    public string Name { get; set; } = "";
    public int    Age  { get; set; }
}

// 3. Define DbContext
public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=localhost;Database=MyDb;...");
}

// 4. Use it
using var db = new AppDbContext();

// Add
db.Users.Add(new User { Name = "Bob", Age = 25 });
db.SaveChanges();

// Query with LINQ
var adults = db.Users
    .Where(u => u.Age >= 18)
    .OrderBy(u => u.Name)
    .ToList();

// Update
var user = db.Users.Find(1);
user!.Age = 31;
db.SaveChanges();

// Delete
db.Users.Remove(user!);
db.SaveChanges();
```

---

## 18. ASP.NET Core

ASP.NET Core is Microsoft's cross-platform framework for building web APIs and web apps.

### Minimal API (simple & modern)

```csharp
// Program.cs
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Define endpoints
app.MapGet("/", () => "Hello, World!");

app.MapGet("/users/{id}", (int id) => new { Id = id, Name = "Alice" });

app.MapPost("/users", (UserDto dto) =>
{
    // process dto...
    return Results.Created($"/users/1", dto);
});

app.Run();

record UserDto(string Name, int Age);
```

### Controller-Based API

```csharp
// Controllers/UsersController.cs
[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly AppDbContext _db;

    // Dependency Injection — ASP.NET provides the db
    public UsersController(AppDbContext db) => _db = db;

    [HttpGet]
    public IActionResult GetAll() => Ok(_db.Users.ToList());

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var user = _db.Users.Find(id);
        return user is null ? NotFound() : Ok(user);
    }

    [HttpPost]
    public IActionResult Create(User user)
    {
        _db.Users.Add(user);
        _db.SaveChanges();
        return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, User updated)
    {
        var user = _db.Users.Find(id);
        if (user is null) return NotFound();
        user.Name = updated.Name;
        user.Age  = updated.Age;
        _db.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var user = _db.Users.Find(id);
        if (user is null) return NotFound();
        _db.Users.Remove(user);
        _db.SaveChanges();
        return NoContent();
    }
}
```

### Dependency Injection

```csharp
// Register services in Program.cs
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddSingleton<IConfig, AppConfig>();
builder.Services.AddTransient<IEmailSender, SmtpEmailSender>();

// Inject into constructor
public class UserService
{
    private readonly AppDbContext _db;
    public UserService(AppDbContext db) => _db = db;
}
```

### Middleware

```csharp
// Built-in middleware
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.UseStaticFiles();

// Custom middleware
app.Use(async (context, next) =>
{
    Console.WriteLine($"Request: {context.Request.Path}");
    await next();                                    // call next middleware
    Console.WriteLine($"Response: {context.Response.StatusCode}");
});
```

---

## 19. Unity Game Development

Unity uses C# as its scripting language. Scripts attach to GameObjects to give them behaviour.

### MonoBehaviour — the base class for all Unity scripts

```csharp
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Exposed in the Inspector
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 8f;

    private Rigidbody2D _rb;

    // Called once on the first frame
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Called every frame (~60x per second)
    void Update()
    {
        float h = Input.GetAxis("Horizontal");   // -1 to 1
        _rb.velocity = new Vector2(h * speed, _rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
```

### Common Unity Event Methods

```csharp
void Awake()            { /* before Start, even if disabled */ }
void Start()            { /* first frame, object is active */ }
void Update()           { /* every frame */ }
void FixedUpdate()      { /* fixed physics timestep (0.02s) */ }
void LateUpdate()       { /* after all Updates (e.g., camera follow) */ }
void OnDestroy()        { /* when object is destroyed */ }
void OnEnable()         { /* when object becomes active */ }
void OnDisable()        { /* when object becomes inactive */ }
```

### Collision & Triggers

```csharp
// 3D physics
void OnCollisionEnter(Collision col)
{
    if (col.gameObject.CompareTag("Enemy"))
        TakeDamage(10);
}

void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Coin"))
    {
        score++;
        Destroy(other.gameObject);
    }
}

// 2D physics
void OnCollisionEnter2D(Collision2D col) { }
void OnTriggerEnter2D(Collider2D other)  { }
```

### Useful Unity APIs

```csharp
// Instantiate and destroy
GameObject enemy = Instantiate(enemyPrefab, position, rotation);
Destroy(enemy, 3f);   // destroy after 3 seconds

// Find objects
GameObject player = GameObject.FindWithTag("Player");
var allEnemies = FindObjectsOfType<Enemy>();

// Coroutines — pause and resume execution
IEnumerator SpawnWave()
{
    yield return new WaitForSeconds(2f);
    Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
    yield return new WaitForSeconds(1f);
    Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
}

StartCoroutine(SpawnWave());

// SceneManagement
using UnityEngine.SceneManagement;
SceneManager.LoadScene("GameScene");
SceneManager.LoadScene(0); // by build index
```

---

## 20. Design Patterns

Design patterns are proven, reusable solutions to common software problems.

---

### Creational Patterns — object creation

**Singleton** — ensure only one instance exists

```csharp
public class GameManager
{
    private static GameManager? _instance;

    private GameManager() { }   // private constructor

    public static GameManager Instance =>
        _instance ??= new GameManager();

    public int Score { get; set; }
}

// Usage
GameManager.Instance.Score = 100;
```

**Factory Method** — let subclasses decide which object to create

```csharp
public abstract class Notification
{
    public abstract void Send(string message);

    // Factory method
    public static Notification Create(string type) => type switch
    {
        "email" => new EmailNotification(),
        "sms"   => new SmsNotification(),
        _       => throw new ArgumentException($"Unknown type: {type}")
    };
}

public class EmailNotification : Notification
{
    public override void Send(string message)
        => Console.WriteLine($"Email: {message}");
}

// Usage
var n = Notification.Create("email");
n.Send("Hello!");
```

**Builder** — construct complex objects step by step

```csharp
public class QueryBuilder
{
    private string _table  = "";
    private string _where  = "";
    private int    _limit  = 100;

    public QueryBuilder From(string table) { _table = table; return this; }
    public QueryBuilder Where(string cond) { _where = cond;  return this; }
    public QueryBuilder Limit(int limit)   { _limit = limit; return this; }

    public string Build()
    {
        string sql = $"SELECT * FROM {_table}";
        if (!string.IsNullOrEmpty(_where)) sql += $" WHERE {_where}";
        return sql + $" LIMIT {_limit}";
    }
}

// Usage — fluent chaining
string query = new QueryBuilder()
    .From("Users")
    .Where("Age > 18")
    .Limit(50)
    .Build();
```

---

### Structural Patterns — object composition

**Repository** — abstract data access behind an interface

```csharp
public interface IUserRepository
{
    User? GetById(int id);
    IEnumerable<User> GetAll();
    void Add(User user);
    void Delete(int id);
}

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _db;
    public UserRepository(AppDbContext db) => _db = db;

    public User? GetById(int id)          => _db.Users.Find(id);
    public IEnumerable<User> GetAll()     => _db.Users.ToList();
    public void Add(User user)            { _db.Users.Add(user); _db.SaveChanges(); }
    public void Delete(int id)
    {
        var u = _db.Users.Find(id);
        if (u != null) { _db.Users.Remove(u); _db.SaveChanges(); }
    }
}
```

**Decorator** — add behaviour to an object without altering its class

```csharp
public interface ILogger
{
    void Log(string message);
}

public class ConsoleLogger : ILogger
{
    public void Log(string message)
        => Console.WriteLine(message);
}

public class TimestampLogger : ILogger
{
    private readonly ILogger _inner;
    public TimestampLogger(ILogger inner) => _inner = inner;

    public void Log(string message)
        => _inner.Log($"[{DateTime.Now:HH:mm:ss}] {message}");
}

// Usage
ILogger logger = new TimestampLogger(new ConsoleLogger());
logger.Log("App started");  // [14:30:01] App started
```

---

### Behavioural Patterns — communication between objects

**Observer** — notify subscribers when something changes (event-driven)

```csharp
// Built-in C# events implement the Observer pattern
public class StockMarket
{
    public event Action<string, decimal>? PriceChanged;

    public void UpdatePrice(string stock, decimal price)
    {
        Console.WriteLine($"{stock} price: {price}");
        PriceChanged?.Invoke(stock, price);   // notify all subscribers
    }
}

var market = new StockMarket();
market.PriceChanged += (stock, price)
    => Console.WriteLine($"ALERT: {stock} is now {price}");

market.UpdatePrice("AAPL", 189.99m);
```

**Strategy** — swap algorithms at runtime

```csharp
public interface ISortStrategy
{
    void Sort(List<int> data);
}

public class BubbleSort : ISortStrategy
{
    public void Sort(List<int> data) { /* bubble sort logic */ }
}

public class QuickSort : ISortStrategy
{
    public void Sort(List<int> data) { /* quicksort logic */ }
}

public class Sorter
{
    private ISortStrategy _strategy;

    public Sorter(ISortStrategy strategy) => _strategy = strategy;

    public void SetStrategy(ISortStrategy strategy) => _strategy = strategy;

    public void Sort(List<int> data) => _strategy.Sort(data);
}

// Usage
var sorter = new Sorter(new BubbleSort());
sorter.Sort(myList);

sorter.SetStrategy(new QuickSort());  // swap strategy at runtime
sorter.Sort(myList);
```

**Command** — encapsulate actions as objects (supports undo/redo)

```csharp
public interface ICommand
{
    void Execute();
    void Undo();
}

public class MoveCommand : ICommand
{
    private readonly Player _player;
    private readonly Vector2 _delta;
    private Vector2 _previous;

    public MoveCommand(Player player, Vector2 delta)
    {
        _player = player;
        _delta  = delta;
    }

    public void Execute()
    {
        _previous = _player.Position;
        _player.Position += _delta;
    }

    public void Undo()
    {
        _player.Position = _previous;
    }
}
```

---

## Quick Reference Card

| Concept           | Key Keyword / Class                                |
|-------------------|----------------------------------------------------|
| Variable          | `var`, `const`, `int`, `string`                    |
| Null safety       | `?`, `??`, `??=`, `?.`                             |
| Loop              | `for`, `foreach`, `while`, `do-while`              |
| OOP               | `class`, `abstract`, `interface`, `override`       |
| Collections       | `List<T>`, `Dictionary<K,V>`, `HashSet<T>`         |
| LINQ              | `.Where()`, `.Select()`, `.OrderBy()`, `.ToList()` |
| Exceptions        | `try`, `catch`, `finally`, `throw`                 |
| Async             | `async`, `await`, `Task`, `Task<T>`                |
| File I/O          | `File`, `StreamReader`, `StreamWriter`, `Path`     |
| Web API           | `[ApiController]`, `[HttpGet]`, `IActionResult`    |
| Unity             | `MonoBehaviour`, `Update()`, `Instantiate()`       |
| Design Patterns   | Singleton, Factory, Repository, Observer, Strategy |

---

*Happy coding! 🎯*