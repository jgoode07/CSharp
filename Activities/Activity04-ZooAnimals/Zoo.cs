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
}