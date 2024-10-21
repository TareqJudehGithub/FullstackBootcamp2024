// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("C# Basics");
#region Input Output
//Console.Write("Enter first name: ");

//string fName = Console.ReadLine();

//Console.Write("Enter middle name: ");
//string mName = Console.ReadLine();

//Console.Write("Enter last name: ");
//string lName = Console.ReadLine();

//// Check Age if Int
//Console.Write("Enter age: ");
//bool isInt = int.TryParse(Console.ReadLine(), out int age);

//if (isInt)
//{
//    var result = $"Hello, {fName} {mName} {lName}! Your age is {age}";
//    Console.WriteLine(result);

//}
//else
//{
//    Console.WriteLine("Invalid entry! Age must be an integer.");
//}
#endregion

// Calculate user average score

Console.Write("Enter mark 1: ");
double mark1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter mark 2: ");
double mark2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter mark 3: ");
double mark3 = Convert.ToDouble(Console.ReadLine());

double totalMarks = mark1 + mark2 + mark3;

double avgScore = totalMarks / 3;

Console.WriteLine($"\nYour score = {Math.Round(avgScore, 2)}");

#region Conditionals
Console.Write("Your score level is: ");
if (avgScore > 90 && avgScore <= 100)
{
    Console.WriteLine("Excellent");
}
else if (avgScore > 80 && avgScore <= 90)
{
    Console.WriteLine("V.good");
}
else if (avgScore > 70 && avgScore <= 80)
{
    Console.WriteLine("Good");
}
else if (avgScore > 60 && avgScore <= 70)
{
    Console.WriteLine("Fair");
}
else
{
    Console.WriteLine("Failed!");
}
#endregion


#region Switch
string avgLevel = string.Empty;

switch (avgScore)
{
    case (> 90 and <= 100):
        avgLevel = "Excellent";
        break;
    case (> 80 and <= 90):
        avgLevel = "V.Good";
        break;
    case (> 70 and <= 80):
        avgLevel = "Good";
        break;
    case (> 60 and <= 70):
        avgLevel = "Fair";
        break;
    case (> 50 and <= 60):
        avgLevel = "ya doab";
        break;
    case (< 50):
        avgLevel = "Failed";
        break;
    default:
        avgLevel = "Invaild Entry";
        break;
}
#endregion

#region Loops

// for loop
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"for loop = {i}");
}
// while loop
int num = 0;
while (num < 10)
{
    Console.WriteLine($"Number = {num}");
    num++;
}
Console.Clear();
// do-while loop
string username = "admin";
string password = "pass";
string userNameInput = string.Empty;
string userPassInput = string.Empty;

do
{
    Console.Write("Username: ");
    userNameInput = Console.ReadLine();
    Console.Write("Password: ");
    userPassInput = Console.ReadLine();

    if (userNameInput == username && userPassInput == password)
    {
        Console.WriteLine($"Welcome user, {username}");
    }
    else
    {
        Console.WriteLine("Invalid username or password!");
    }
}
while (!username.Equals(userNameInput) || !password.Equals(userPassInput));
#endregion


Console.ReadKey();

#region Methods

#endregion




