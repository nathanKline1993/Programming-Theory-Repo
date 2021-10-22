static class AnimalFactory
{
    // ABSTRACTION
    public static Animal GetAnimal(string animalName, string nameOfPet)
    {
        switch (animalName)
        {
            case DataNameConstants.Dog:
                return new Dog(nameOfPet);
            case DataNameConstants.Cat:
                return new Cat(nameOfPet);
            default:
                break;
        }

        return null;
    }
}
