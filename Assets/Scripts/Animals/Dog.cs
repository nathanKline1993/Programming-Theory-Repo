using UnityEngine;

// INHERITANCE
class Dog : Animal
{
    public Dog(string name) : base(name) { }

    // POLYMORPHISM
    public override string Eat()
    {
        return "Chop chop chop";
    }

    // POLYMORPHISM
    public override string Talk()
    {
        return "Bark";
    }
}
