using System;
int n1 = 0, n2 =0;
string op = "";

Console.WriteLine("Enter First Number : ");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Second Number : ");
n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Operator : ");
op = Console.ReadLine();

switch (op)
    {
        case "+":
            result = a+b;
            break;
        case "-":
            result =a - b;
            break;
        case "/":
            result=a / b;
            break;
        case "*":
            result=a * b;
            break;
        case "%":
            result=a % b;
            break;
        default:
            Console.WriteLine("Invalid Operator!!!");
            break;
    }

