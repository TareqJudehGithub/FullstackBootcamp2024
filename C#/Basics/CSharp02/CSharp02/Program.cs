using CSharp02.Model;



Employee emp = new Employee();

Console.Write("Name: ");
emp.Name = Console.ReadLine();

Console.Write("Salary: ");
emp.Salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("bonus: ");
emp.Bonus = Convert.ToDecimal(Console.ReadLine());

Console.Write("SSC: ");
emp.SSC = Convert.ToDecimal(Console.ReadLine());

Console.Write("Date of Birth: ");
emp.DOB = Convert.ToDateTime(Console.ReadLine());

Console.WriteLine($"Date of Birth = {emp.DOB}");

decimal totalSalary = emp.CalculateSalary(emp);
Console.WriteLine($"Net Salary = {totalSalary}");

int age = emp.CalculateAge(emp);
Console.WriteLine($"Your age is: {age}");

Console.WriteLine();

// create new list from Employee class
List<Employee> employees = new List<Employee>();

// Add new items into employees list
//employees.Add(
//    new Employee
//    {
//        Id = 1,
//        Name = "John Smith",
//        Salary = 1000M,
//        Bonus = 150M,
//        SSC = 0.05M,
//        DOB = DateTime.
//    });


//test this!!
DateTime date = DateTime.Now;
Console.WriteLine(date("2000-12-15"));



