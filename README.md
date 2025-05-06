## Description

This is a basic C# console application that demonstrates how to work with arrays.

## Features

- Declares and initializes an array of integers.
- Prints each element in the array using a `foreach` loop.
- Calculates and displays the sum of all array elements.

## Code Example

```csharp
int[] numbers = { 1, 2, 3, 4, 5 };

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

int sum = 0;
foreach (int number in numbers)
{
    sum += number;
}
Console.WriteLine($"Sum of array elements: {sum}");
```
## How to Run

Make sure you have the .NET SDK installed.

Clone or download this repository.

Open a terminal in the project directory.

Run the application:
dotnet run
