using System;

class Program
{
    // Універсальний метод обміну значень
    static void Swap<T>(ref T lhs, ref T rhs)
    {
        T temp = lhs;
        lhs = rhs;
        rhs = temp;
    }

    static void Main(string[] args)
    {
        // Приклад обміну типу double
        double num1 = 1.23, num2 = 4.56;
        Console.WriteLine($"Before Swap: num1={num1}, num2={num2}");
        Swap(ref num1, ref num2);
        Console.WriteLine($"After Swap: num1={num1}, num2={num2}");

        // Приклад обміну типу string
        string str1 = "Hello", str2 = "World";
        Console.WriteLine($"\nBefore Swap: str1={str1}, str2={str2}");
        Swap(ref str1, ref str2);
        Console.WriteLine($"After Swap: str1={str1}, str2={str2}");

        Console.ReadKey();
    }
}

