using EmployeeManagement;
string name = "Mohit";
int age = 35;
decimal salary = 125000.50m;
bool isActive = true;

Console.WriteLine("=== Employee Details ===");
Console.WriteLine($"Hello, {name}!");
Console.WriteLine($"You are {age} years old.");
Console.WriteLine($"Your salary is {salary:F2}.");
Console.WriteLine($"Your status is {isActive}.");

Console.WriteLine("\n=== Arithmetic Operators ===");

int a = 10;
int b = 3;

Console.WriteLine($"Addition: {a + b}");
Console.WriteLine($"Subtraction: {a - b}");
Console.WriteLine($"Multiplication: {a * b}");
Console.WriteLine($"Division: {a / b}");
Console.WriteLine($"Remainder: {a % b}");

Console.WriteLine("\n=== Conditional Statements ===");

bool isEligible = age >= 18 && age <= 65;
Console.WriteLine($"Eligible: {isEligible}");

if (salary >= 200000m)
{
    Console.WriteLine("Salary Category: High");
}
else if (salary >= 100000m)
{
    Console.WriteLine("Salary Category: Medium");
}
else
{
    Console.WriteLine("Salary Category: Low");
}

Console.WriteLine("\n=== Switch Statement ===");

string department = "IT";

switch (department)
{
    case "IT":
        Console.WriteLine("Technology");
        break;

    case "HR":
        Console.WriteLine("Human Resources");
        break;

    case "Finance":
        Console.WriteLine("Finance");
        break;

    default:
        Console.WriteLine("Unknown department");
        break;
}

Console.WriteLine("\n=== Arrays and Loops ===");

string[] names =
[
    "Mohit",
    "Rahul",
    "Amit",
    "Raj"
];

Console.WriteLine($"First name: {names[0]}");

foreach (string n in names)
{
    Console.WriteLine(n);
}

Console.WriteLine("\n=== Methods ===");

int result = Add(2, 3);
Console.WriteLine($"Addition result: {result}");

PrintEmployee("Mohit", 35, 125000m);

Console.WriteLine("\n=== Null-Conditional Operator ===");

string? middleName = null;
Console.WriteLine(middleName?.ToUpper() ?? "Middle name not provided");

Console.WriteLine("\n=== Employee Class and Object ===");

/*Employee emp = new()
{
    Id = 1,
    Name = "Mohit",
    Salary = 125000m,
    Department = "IT"
};

Console.WriteLine($"Employee ID: {emp.Id}");
Console.WriteLine($"Employee Name: {emp.Name}");
Console.WriteLine($"Employee Salary: {emp.Salary:F2}");
Console.WriteLine($"Employee Department: {emp.Department}");*/

List<Products> productsList = [
    new ()
    {
        Id = 1,
        Name = "Laptop",
        Price = 100,
        Category = "Laptop",
        IsAvailable = false
    },
    new ()
    {
        Id = 2,
        Name = "Mouse",
        Price = 200,
        Category = "Mouse",
        IsAvailable = false
    },
    new ()
    {
        Id = 3,
        Name = "Keyboard",
        Price = 300,
        Category = "Keyboard",
        IsAvailable = false
    },
    new ()
    {
        Id = 4,
        Name = "Monitor",
        Price = 400,
        Category = "Monitor",
        IsAvailable = false
    },
    new Products()
    {
        Id = 5,
        Name = "Phone",
        Price = 500,
        Category = "Phone",
        IsAvailable = false
    }
];

foreach (Products item in productsList)
{
    Console.WriteLine(
        $"{item.Name} - ₹{item.Price:N2} - " +
        $"Category: {item.Category} - " +
        $"Available: {item.IsAvailable}"
    );
}

static int Add(int x, int y)
{
    return x + y;
}

static void PrintEmployee(string name, int age, decimal salary)
{
    Console.WriteLine(
        $"Name: {name}, Age: {age}, Salary: {salary:F2}");
}

Employee employee = new Employee(1, "Mohit", 125000m, "IT");
Console.WriteLine($"employee id: {employee.Id},  name: {employee.Name}, salary: {employee.Salary}, department: {employee.Department}");

Employee secondEmployee =  new Employee(2, "Mohit", 125000m, "HR");
Console.WriteLine($"employee id: {secondEmployee.Id},  name: {secondEmployee.Name}, salary: {secondEmployee.Salary}, department: {secondEmployee.Department}");

Employee thirdEmployee = new Employee(id: 3, "Mohit", 125000m, "Finance");
Console.WriteLine($"employee id: {secondEmployee.Id},  name: {thirdEmployee.Name}, salary: {thirdEmployee.Salary}, department: {thirdEmployee.Department}");