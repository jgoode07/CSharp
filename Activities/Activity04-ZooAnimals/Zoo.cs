using System;
using System.Collections.Generic;

public class Zoo
{
    private List<Animal> animals = new List<Animal>();

    // Add an Animal to the Zoo
    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }

    // Show Info for all Animals
    public void DisplayAnimals()
    {
        foreach (var animal in animals)
        {
            Console.WriteLine($"{animal.Name}, Age {animal.Age}, Sound: {animal.MakeSound()}");
        }
    }

    // // Have Each Animal Make its Sound
    public void MakeAllSounds()
    {
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.MakeSound());
        }
    }
}