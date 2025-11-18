using System;

// Step 1: Create an interface (cannot be instantiated)
interface IAnimal
{
    // Interface methods have no implementation
    void MakeSound();
    void Move();
}

// Step 2: Create a class that implements the interface
class Dog : IAnimal
{
    // Implementing interface methods
    public void MakeSound()
    {
        Console.WriteLine("Dog says: Woof!");
    }

    public void Move()
    {
        Console.WriteLine("Dog runs on four legs.");
    }
}

// Step 3: Another class implementing the same interface
class Cat : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Cat says: Meow!");
    }

    public void Move()
    {
        Console.WriteLine("Cat walks softly on four legs.");
    }
}

class Program
{
    static void Main()
    {
        // Step 4: Polymorphism
        // We use the interface type to refer to different objects
        IAnimal myAnimal;

        // Pointing to a Dog object
        myAnimal = new Dog();
        myAnimal.MakeSound();  // Output → Woof!
        myAnimal.Move();       // Output → Dog runs on four legs.

        // Pointing to a Cat object
        myAnimal = new Cat();
        myAnimal.MakeSound();  // Output → Meow!
        myAnimal.Move();       // Output → Cat walks softly.
    }
}
