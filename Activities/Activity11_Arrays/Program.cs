using System;

// Create an array of integers
int[] numbers = new int[10];

// Fill the array with random numbers (1–100)
Random rand = new Random();

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rand.Next(1, 101);
}