int a, b, c;

Console.WriteLine("QuadraticEquation: ax^2 + bx + c");
Console.WriteLine("Input a:");
while (true)
{
    bool valid = int.TryParse(Console.ReadLine(), out a);
    if (valid)
        break;
    Console.WriteLine("Please, enter a valid integer number (a)");
}

Console.WriteLine("Input b:");
while (true)
{
    bool valid = int.TryParse(Console.ReadLine(), out b);
    if (valid)
        break;
    Console.WriteLine("Please, enter a valid integer number (b)");
}

Console.WriteLine("Input c:");
while (true)
{
    bool valid = int.TryParse(Console.ReadLine(), out c);
    if (valid)
        break;
    Console.WriteLine("Please, enter a valid integer number (c)");
}

double D = Math.Pow(b, 2) - 4 * a * c;

if(D == 0)
{
    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
    Console.WriteLine("x1 = {0}", x1);
}
else if(D > 1)
{
    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
    Console.WriteLine("x1 = {0}", x1);
    Console.WriteLine("x2 = {0}", x2);
}
else
{
    Console.WriteLine("There are no solutions");
}