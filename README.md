# C# Roadmap

A structured path for learning C# from basics to advanced development.

---

# 1. Variables

Variables store data.

```csharp
string name = "Bilal";
int age = 20;
```

Think of variables as containers.

---

# 2. Data Types

Different kinds of data.

| Type | Example |
|--------|--------|
| int | 20 |
| double | 1.75 |
| float | 5.6f |
| char | 'A' |
| bool | true |
| string | "Hello" |

Example:

```csharp
int age = 20;
double height = 1.75;
bool student = true;
```

---

# 3. Operators

## Arithmetic

```csharp
+  Addition
-  Subtraction
*  Multiplication
/  Division
%  Modulus
```

Example:

```csharp
int result = 10 + 5;
```

## Comparison

```csharp
==
!=
>
<
>=
<=
```

## Logical

```csharp
&&
||
!
```

---

# 4. Conditions

Used for decision making.

```csharp
if (age >= 18)
{
    Console.WriteLine("Adult");
}
else
{
    Console.WriteLine("Minor");
}
```

---

# 5. Loops

## For Loop

```csharp
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
```

## While Loop

```csharp
int i = 1;

while (i <= 5)
{
    Console.WriteLine(i);
    i++;
}
```

## Foreach Loop

```csharp
string[] names = {"Ali", "Bilal"};

foreach (string name in names)
{
    Console.WriteLine(name);
}
```

---

# 6. Methods

Reusable blocks of code.

```csharp
static int Add(int a, int b)
{
    return a + b;
}
```

Calling:

```csharp
int sum = Add(5, 3);
```

---

# 7. Arrays

Store multiple values.

```csharp
int[] numbers = {1, 2, 3, 4};
```

Access:

```csharp
Console.WriteLine(numbers[0]);
```

---

# 8. Classes

Blueprint for objects.

```csharp
class Car
{
    public string Brand;
}
```

---

# 9. Objects

Instances of classes.

```csharp
Car car1 = new Car();

car1.Brand = "BMW";
```

---

# 10. Constructor

Runs automatically when object is created.

```csharp
class Car
{
    public string Brand;

    public Car(string brand)
    {
        Brand = brand;
    }
}
```

Creating:

```csharp
Car car = new Car("BMW");
```

---

# 11. OOP (4 Pillars)

## Encapsulation

Hide data.

```csharp
private int age;
```

---

## Inheritance

Reuse code.

```csharp
class Animal
{
}

class Dog : Animal
{
}
```

---

## Polymorphism

Same method, different behavior.

```csharp
virtual
override
```

---

## Abstraction

Show essential details and hide implementation.

```csharp
abstract class Animal
{
    public abstract void Sound();
}
```

---

# 12. Collections

## List

```csharp
List<int> numbers = new List<int>();
```

## Dictionary

```csharp
Dictionary<int, string> students;
```

## HashSet

```csharp
HashSet<int> ids;
```

## Queue

FIFO

```csharp
Queue<int> queue;
```

## Stack

LIFO

```csharp
Stack<int> stack;
```

---

# 13. LINQ

Query collections.

```csharp
var even = numbers.Where(n => n % 2 == 0);
```

Sort:

```csharp
OrderBy()
```

Filter:

```csharp
Where()
```

Select:

```csharp
Select()
```

---

# 14. Exception Handling

Prevent crashes.

```csharp
try
{
    int a = 10 / 0;
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Finished");
}
```

---

# 15. Async/Await

Execute tasks asynchronously.

```csharp
async Task GetData()
{
    await Task.Delay(2000);
}
```

Used for:

- APIs
- Database operations
- File operations

---

# 16. File Handling

Read file:

```csharp
File.ReadAllText("test.txt");
```

Write file:

```csharp
File.WriteAllText("test.txt", "Hello");
```

Append:

```csharp
File.AppendAllText();
```

---

# 17. Database (SQL)

Create table:

```sql
CREATE TABLE Users
(
    Id INT PRIMARY KEY,
    Name VARCHAR(100)
);
```

Insert:

```sql
INSERT INTO Users VALUES (1,'Bilal');
```

Select:

```sql
SELECT * FROM Users;
```

Update:

```sql
UPDATE Users
SET Name='Ali'
WHERE Id=1;
```

Delete:

```sql
DELETE FROM Users
WHERE Id=1;
```

---

# 18. ASP.NET Core

Used for:

- Web APIs
- Authentication
- MVC
- Backend Development

Example:

```csharp
[HttpGet]
public IActionResult Get()
{
    return Ok();
}
```

---

# 19. Unity Game Development

Uses C#.

Main concepts:

- GameObject
- Transform
- Components
- Rigidbody
- Collider
- Update()
- Input System

Example:

```csharp
void Update()
{
    transform.Translate(Vector3.forward);
}
```

---

# 20. Design Patterns

Reusable software solutions.

## Singleton

One object only.

```csharp
public static GameManager Instance;
```

---

## Factory

Creates objects.

```csharp
Enemy enemy = EnemyFactory.Create();
```

---

## Observer

Event-driven communication.

```csharp
event Action OnDeath;
```

---

# Learning Order

Variables
↓
Data Types
↓
Operators
↓
Conditions
↓
Loops
↓
Methods
↓
Arrays
↓
Classes
↓
Objects
↓
Constructors
↓
OOP
↓
Collections
↓
LINQ
↓
Exception Handling
↓
Async/Await
↓
File Handling
↓
SQL
↓
ASP.NET Core
↓
Unity Game Development
↓
Design Patterns