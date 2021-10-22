using UnityEngine;

// INHERITANCE
class Cat : Animal
{
    public Cat(string name) : base(name) { }

    // POLYMORPHISM
    public override string Eat()
    {
        return "Slurp slurp slurp";
    }

    // POLYMORPHISM
    public override string Talk()
    {
        return "Meow";
    }
}
