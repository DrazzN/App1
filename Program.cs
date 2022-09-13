using System;
int n1 = 0, n2 = 0;
string op = "";
int result = 0;

void Operation(int a, int b, string h)
{
    switch (h)
    {
        case "+":
            result = a + b;
            break;
        case "-":
            result = a - b;
            break;
        case "/":
            result = a / b;
            break;
        case "*":
            result = a * b;
            break;
        case "%":
            result = a % b;
            break;
        default:
            Console.WriteLine("Invalid Operator!!!");
            break;
    }
    Console.WriteLine("Result : " + result);
}

Console.WriteLine("Enter First Number : ");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Second Number : ");
n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Operator : ");
op = Console.ReadLine();
Operation(n1,n2,op);
