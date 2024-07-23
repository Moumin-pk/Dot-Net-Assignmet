// See https://aka.ms/new-console-template for more information
using static System.Formats.Asn1.AsnWriter;

Console.WriteLine("Hello, World!");

// Exercise # 1

// using nested for loops print these patterns
// *
// **
// ***

for (int i = 0; i <= 3; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}


Console.WriteLine("Eample # 2");
// Exercise # 2

// 321
// 32
// 1


for (int m = 3; m >= 0; m--)
{
    for (int n = m; n >= 1; n--)
    {
        Console.Write(n);
    }
    Console.WriteLine();
}


// Example # 3

/*
Store these marks in a list and display average of student, max marks, minumum
marks : 0, 98, 67, 9, 45, 44, 23, 2
Don't use built in methods
*/

int[] marks = { 0, 98, 67, 9, 45, 44, 23, 2 };
int max = marks[0];
int min = marks[0];
int sum = 0;

// Maximum value:
for (int i = 0; i < marks.Length; i++)
{
    if (marks[i] > max)
    {
        max = marks[i];
    }

}
Console.WriteLine("your max marks is : " + max);


// Minimum Value
for (int i = 0; i < marks.Length; i++)
{
    if (marks[i] < min)
    {
        min = marks[i];
    }
}
Console.WriteLine("your min marks is : " + min);



// Average Value
for (int i = 0; i < marks.Length; i++)
{
    sum = sum + marks[i];
}
Console.WriteLine("Average marks : " + sum / marks.Length);

