// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello!");

// Capture user input
Console.Write("Input the first number: ");
int firstNum = int.Parse(Console.ReadLine());

Console.Write("Input the second number: ");
int secondNum = int.Parse(Console.ReadLine());

// User choice
Console.WriteLine("\nWhat do you want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");
string userChoice = Console.ReadLine().ToLower();


// Methods
#region Methods
int Add(int num1, int num2)
{
    return num1 + num2;
}

int Subtract(int num1, int num2)
{
    return num2 - num1;
}

int Multiply(int num1, int num2)
{
    return num1 * num2;
}
#endregion

// Call a method depending on user input choice.
int result = 0;
switch (userChoice)
{
    case "a":
        result = Add(firstNum, secondNum);
        break;
    case "s":
        result = Subtract(firstNum, secondNum);
        break;
    case "m":
        result = Multiply(firstNum, secondNum);
        break;
    default:
        Console.WriteLine("Invalid entry!");
        break;
}
Console.WriteLine(result);

Console.ReadKey();
