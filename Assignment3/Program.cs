using System;

// Employee class with overloaded comparison operators
class Employee
{
    // Properties for the Employee
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overloading the "==" operator
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // Check if both objects are null
        if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
            return true;

        // Check if one of them is null
        if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            return false;

        // Compare the Id properties
        return emp1.Id == emp2.Id;
    }

    // Overloading the "!=" operator (must be overloaded as a pair with ==)
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create the first Employee object
        Employee employee1 = new Employee()
        {
            Id = 1,
            FirstName = "John",
            LastName = "Smith"
        };

        // Create the second Employee object
        Employee employee2 = new Employee()
        {
            Id = 1,
            FirstName = "Sarah",
            LastName = "Johnson"
        };

        // Comparing the two employees using the overloaded == operator
        Console.WriteLine("Are the two employees equal? " + (employee1 == employee2));

        // Comparing using the overloaded != operator
        Console.WriteLine("Are the two employees different? " + (employee1 != employee2));

        Console.ReadLine();
    }
}
