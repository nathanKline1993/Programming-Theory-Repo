using UnityEngine;

// INHERITANCE
abstract class Animal
{
    private string name;

    // ENCAPSULATION
    public string Name { get { return name; } }

    public Animal(string name)
    {
        this.name = name;
    }

    public abstract string Eat();

    public abstract string Talk();

    public string Sleep()
    {
        return "Zzzz";
    }

    public string Walk()
    {
        return "Paw paw paw";
    }
}
