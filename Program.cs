// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");*/

string name = "Mohit";
int age = 35;
decimal salary = 125000.50m;
bool isActive = true;

/*var surName = "Sharma";
Console.WriteLine($"{surName}");*/
Console.WriteLine($"Hello, {name}!\nYou are {age} years old.\nYou salary is {salary}.\nYour status is {isActive}.");

int a = 10;
int b = 3;

Console.WriteLine(a + b);
Console.WriteLine(a - b);
Console.WriteLine(a * b);
Console.WriteLine(a / b);
Console.WriteLine(a % b);

bool isEligible = (age >= 18 && age <= 65);
Console.WriteLine(isEligible);

if (salary >= 200000)
{
    Console.WriteLine("High");
}
else if (salary >= 100000)
{
    Console.WriteLine("Medium");
}
else
{
    Console.WriteLine("Low");
}

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

string[] names =
[
    "Mohit",
    "Rahul",
    "Amit",
    "Raj"
];

Console.WriteLine(names[0]);

foreach (string n in names)
{
    Console.WriteLine(n);
}

static int Add(int x, int y)
{
    return x + y;
}

int result = Add(2, 3);
Console.WriteLine(result);

static void PrintEmployee(string name, int age, decimal salary)
{
    Console.WriteLine(
        $"Name: {name}, Age: {age}, Salary: {salary}"
    );
}

PrintEmployee(
    "Mohit",
    35,
    125000
);

string? middleName = null;
Console.WriteLine(middleName?.ToUpper());

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public string department { get; set; }
}
 Employee emp = new(){
     Id = 1,
     Name = "Mohit",
     Salary = 125000,
     department = "IT"
 };