# Assignment 5 – XML Shapes Serialization  
Author: Joe Goode  
Course: .NET  

## Overview  
This console application demonstrates how to serialize and deserialize objects using XML.  
The program creates a list of shapes, saves them to an XML file, then loads them back and displays each shape with its calculated area.

## How It Works  
- A list of shapes (circles and rectangles) is created in the program.  
- Each shape stores its colour and dimensions.  
- The list is serialized and written to an XML file on disk.  
- The program then reads the XML file and deserializes it back into shape objects.  
- Each shape is displayed in the console along with its type, colour, and area.  

## Files Included  
- `Program.cs`  
- `Shape.cs`  
- `Circle.cs`  
- `Rectangle.cs`  

## Notes  
This assignment focuses on working with XML serialization and object-oriented design in C#.  
It practices saving data to the filesystem and restoring it back into usable objects, which is a key concept covered in Module 2 of the .NET course at Robertson College.