using System.Diagnostics.CodeAnalysis;

Console.Write("First number: ");
double num1 = double.Parse(Console.ReadLine()!);

Console.Write("Second number: ");
double num2 = double.Parse(Console.ReadLine()!);

double sum = num1 + num2;
double difference = num1 - num2;
double product = num1 * num2;
double quotient = num1 / num2;

Console.WriteLine($"{num1} + {num2} = {sum}");
Console.WriteLine($"{num1} - {num2} = {difference}");
Console.WriteLine($"{num1} * {num2} = {product}");
Console.WriteLine($"{num1} / {num2} = {quotient}");


