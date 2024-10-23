using System;

Console.WriteLine("Methods\n");

#region Methods
Console.Write("Enter mark 1: ");
double mark1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter mark 2: ");
double mark2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter mark 3: ");
double mark3 = Convert.ToDouble(Console.ReadLine());


double CalculateSum(double x, double y, double z)
{
    return x + y + z;
}

Console.WriteLine(CalculateSum(mark1, mark2, mark3));
#endregion

Console.ReadKey();