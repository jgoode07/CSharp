using System.Xml.Serialization;

// Create a list of Shapes to serialize
var listOfShapes = new List<Shape>
{
    new Circle { Colour = "Red", Radius = 2.5 },
    new Rectangle { Colour = "Blue", Height = 20.0, Width = 10.0 },
    new Circle { Colour = "Green", Radius = 8 },
    new Circle { Colour = "Purple", Radius = 12.3 },
    new Rectangle { Colour = "Blue", Height = 45.0, Width = 18.0 }
};

// File path for saving the XML output
string xmlPath = "shapes.xml";

// Create the serializer for a List<Shape>
var serializer = new XmlSerializer(typeof(List<Shape>));

// Write the XML file
using (var file = File.Create(xmlPath))
{
    serializer.Serialize(file, listOfShapes);
}

Console.WriteLine("Shapes saved to XML.");

// Read shapes back from XML
List<Shape>? loadedShapes;

using (var file = File.OpenRead(xmlPath))
{
    loadedShapes = serializer.Deserialize(file) as List<Shape>;
}

Console.WriteLine("\nLoading shapes from XML:\n");

// Make sure the list actually loaded before trying to use it
if (loadedShapes != null)
{
    // Loop through each shape and display its details
    foreach (Shape item in loadedShapes)
    {
        Console.WriteLine($"{item.GetType().Name} is {item.Colour} and has an area of {item.Area}");
    }
}
else
{
    Console.WriteLine("No shapes were loaded from XML.");
}