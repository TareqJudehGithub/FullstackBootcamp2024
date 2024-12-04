//// See https://aka.ms/new-console-template for more information
////Console.WriteLine("C# Basics\n");

////Console.Write("Please enter a choice: ");
////var userChoice = Console.ReadLine().ToLower();

////bool isUserInputABC = userChoice.Equals("abc");

////Console.WriteLine(isUserInputABC);
////Console.Clear();

////// modulo 
////// Check if the number is odd or even
////Console.Write("Enter a number: ");
////int num = Convert.ToInt32(Console.ReadLine());

////bool isEven = num % 2 == 0;
////Console.WriteLine(isEven);
////Console.WriteLine(" ");


//// Methods

//// Sum method
//int Add(int a, int b)
//{
//    return a + b;
//}

//Console.WriteLine(Add(a: 5, b: 15));


//// Islong method checks if a string is longer than 25 characters.
//bool IsLong(string letters)
//{
//    return letters.Length > 10;
//}

//Console.WriteLine($"Is the user input longer than 25 characters? {isLongResult}");
//Console.ReadKey();



Console.WriteLine("Hello World!");

string GreetMethod()
{
    return "Hello User of Greet Method";
}
Console.WriteLine(GreetMethod());


string myName = "Tareq";
string GreetLambda(string name) => $"Hello User, {myName} of Lambda!";


Console.WriteLine(GreetLambda(myName));


