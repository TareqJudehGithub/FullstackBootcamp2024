// Creating new (empty) ToDo List of type string
List<string> TODOs = new List<string>();

//User input bool check - Exit or stay in application
bool isRunning = true;

do
{
    Header();
    Console.WriteLine("Hello!");
    Console.WriteLine("What do you want to do today?");
    Console.WriteLine("[S]ee all TODO");
    Console.WriteLine("[A]dd a new TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    // User input bool check - Check if user provided a bad entry
    bool isLetter = true;
    do
    {
        Console.Write("\nChoice: ");
        string userChoice = Console.ReadLine().ToLower().Trim();

        if (userChoice.All(char.IsLetter))
        {
            // user choice options - switch statement
            switch (userChoice)
            {
                case "s":
                    DisplayAllTodos();
                    break;
                case "a":
                    AddToDo();
                    break;
                case "r":
                    RemoveTODO();
                    break;
                case "e":
                    Console.Write("Exit program? (y/n) ");
                    string exitChoice = Console.ReadLine().Trim();

                    if (exitChoice.Equals("y", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Good Bye!");
                        isRunning = false;
                    }
                    else
                    {
                        continue;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid entry!");
                    break;
            }
        }
        else
        {
            isLetter = false;
        }
    }

    while (!isLetter);
}
while (isRunning);

Console.ReadKey();


#region Methods
// User selected option
void DisplayAllTodos()
{
    Header();
    //foreach (var item in TODOs)
    //{
    //    Console.WriteLine(item);
    //}

    Console.WriteLine("Your TODOs List:\n");

    for (int i = 0; i < TODOs.Count; i++)
    {
        Console.WriteLine($"[{i}] {TODOs[i]}");
    }
    Console.ReadKey();
}
#endregion

void AddToDo()
{
    Header();

    // Creating a string variable TODO as a user input
    string TODO = string.Empty;

    // Check if user input is not empty or null using a do/while loop.
    do
    {
        Console.Write("TODO description: ");
        TODO = Console.ReadLine();
    }
    while (String.IsNullOrEmpty(TODO)); // if input is indeed empty, then run "do" block again.

    TODOs.Add(TODO);   // Add user input (new TODO to the list)
    if (TODOs.Count > 0)
    {
        Console.WriteLine($"TODO: {TODO} was added successfully!!");
    }
    Console.ReadKey();
}
void RemoveTODO()
{
    Header();


    // Display TODOs list for the user to choose from which TODO to remove
    DisplayAllTodos();

    Console.WriteLine("");
    bool isInt = true;
    Console.Write($"Select a TODO to remove? (0-{TODOs.Count - 1}) ");

    isInt = int.TryParse(Console.ReadLine(), out int TodoToDelNum);

    if (isInt)
    {
        for (int i = 0; 0 < TODOs.Count; i++)
        {

            if (i == TodoToDelNum)
            {
                string itemName = TODOs[i];
                TODOs.Remove(itemName);
                Console.WriteLine($"TODO: {itemName} was successfully removed!");
                break;
            }
        }
    }

    Console.ReadKey();
}



void Header()
{
    Console.Clear();
    Console.WriteLine("\t\t\t\t=====TODOs List=====");
    Console.WriteLine("\n");
}








// user choice options - if else statement
//if (userchoice.equals("s"))
//{
//    printselectedoption("see all todos");
//}
//else if (userchoice.equals("a"))
//{
//    printselectedoption("add a todo");
//}
//else if (userchoice.equals("r"))
//{
//    printselectedoption("remove a todo");
//}
//else if (userchoice.equals("e"))
//{
//    printselectedoption("exit program");
//}
//else
//{
//    console.writeline("invalid entry.");
//}