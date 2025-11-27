// Create a New Zoo
Zoo myZoo = new Zoo();

// Create Animals
Lion leo = new Lion("Leo", 5);
Elephant ella = new Elephant("Ella", 12);
Penguin penny = new Penguin("Penny", 3);

// Add Animals to the Zoo
myZoo.AddAnimal(leo);
myZoo.AddAnimal(ella);
myZoo.AddAnimal(penny);

// Show Info about all Animals
myZoo.DisplayAnimals();

Console.WriteLine();

// Make all Animals Perform their Sounds
myZoo.MakeAllSounds();
