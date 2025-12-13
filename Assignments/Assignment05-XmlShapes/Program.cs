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