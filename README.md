# C# Input and Type Conversion

## Why do we use `ToInt32()`, `ToDouble()`, and `ToSingle()`?

`Console.ReadLine()` always returns a **string**.

```csharp
string input = Console.ReadLine();
```

If the user enters:

```
20
```

C# still sees it as:

```csharp
"20"
```

To use it as a number, we must convert the string to the required data type.

---

## Common Conversions

| Data Type | C# Alias | Actual .NET Type | Conversion Method |
|------------|----------|------------------|-------------------|
| Integer | int | Int32 | Convert.ToInt32() |
| Long Integer | long | Int64 | Convert.ToInt64() |
| Short Integer | short | Int16 | Convert.ToInt16() |
| Decimal Number | double | Double | Convert.ToDouble() |
| Decimal Number | float | Single | Convert.ToSingle() |
| High Precision Decimal | decimal | Decimal | Convert.ToDecimal() |
| True / False | bool | Boolean | Convert.ToBoolean() |
| Character | char | Char | Convert.ToChar() |
| Byte | byte | Byte | Convert.ToByte() |

---

## Why `ToInt32()` and not `ToInt()`?

`int` is only a nickname (alias).

```csharp
int age = 20;
```

Actually, `int` means:

```csharp
System.Int32
```

Similarly:

```csharp
long    → System.Int64
short   → System.Int16
float   → System.Single
double  → System.Double
bool    → System.Boolean
char    → System.Char
```

Therefore:

```csharp
Convert.ToInt32()
Convert.ToInt64()
Convert.ToDouble()
Convert.ToSingle()
```

are named after the real .NET types.

---

## Taking Multiple Inputs

```csharp
using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Height: ");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.Write("Student (true/false): ");
        bool isStudent = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("\nUser Information");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Height: " + height);
        Console.WriteLine("Student: " + isStudent);
    }
}
```

---

## Parse Methods

Another way to convert values:

```csharp
int age = int.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());
float weight = float.Parse(Console.ReadLine());
bool isStudent = bool.Parse(Console.ReadLine());
```

### Example

Input:

```
20
```

Flow:

```
Console.ReadLine()
        ↓
      "20" (string)
        ↓
 int.Parse("20")
        ↓
        20 (int)
```

---

## Safer Conversion with `TryParse()`

Using `Parse()` on invalid input causes an error.

```csharp
int age;

if (int.TryParse(Console.ReadLine(), out age))
{
    Console.WriteLine("Age: " + age);
}
else
{
    Console.WriteLine("Invalid input.");
}
```

### Flow

```
User Input
    ↓
"abc"
    ↓
TryParse()
    ↓
false
    ↓
No crash
```

---

## Important Rule

**`Console.ReadLine()` always returns a string.**

To work with other data types, convert the string:

```csharp
int number = Convert.ToInt32(Console.ReadLine());
double value = Convert.ToDouble(Console.ReadLine());
float weight = Convert.ToSingle(Console.ReadLine());
bool isAdmin = Convert.ToBoolean(Console.ReadLine());
```

---

## Type Aliases

| Alias | Actual Type |
|---------|-------------|
| int | Int32 |
| long | Int64 |
| short | Int16 |
| float | Single |
| double | Double |
| decimal | Decimal |
| bool | Boolean |
| char | Char |
| string | String |

---

## Key Idea

```
User Input
    ↓
Console.ReadLine()
    ↓
String
    ↓
Conversion
    ↓
Required Data Type
```

Everything entered by the user starts as a **string**. Conversion changes that string into the type your program needs.
