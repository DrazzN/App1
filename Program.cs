using System;
int n1 = 0, n2 = 0;
string op = "";
int result = 0;

Console.WriteLine("Enter First Number : ");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Second Number : ");
n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Operator : ");
op = Console.ReadLine();

switch (op)
{
    case "+":
        result = n1 + n2;
        break;
    case "-":
        result = n1 - n2;
        break;
    case "/":
        result = n1 / n2;
        break;
    case "*":
        result = n1 * n2;
        break;
    case "%":
        result = n1 % n2;
        break;
    default:
        Console.WriteLine("Invalid Operator!!!");
        break;
}
Console.WriteLine("Result : " + result);

