/// <summary>
/// This program takes a JSON menu structure, deserializes 
/// it, converts the data into an XML format, and prints 
/// the result.
/// </summary>
/// <remarks>
/// Author: Joe Goode
/// Course: .NET
/// </remarks>

using System;
using System.Text.Json;
using System.Xml.Linq;

string json = @"
{
  ""menu"": {
    ""header"": ""SVG Viewer"",
    ""items"": [
      {""id"": ""Open""},
      {""id"": ""OpenNew"", ""label"": ""Open New""},
      null,
      {""id"": ""ZoomIn"", ""label"": ""Zoom In""},
      {""id"": ""ZoomOut"", ""label"": ""Zoom Out""},
      {""id"": ""OriginalView"", ""label"": ""Original View""},
      null,
      {""id"": ""Quality""},
      {""id"": ""Pause""},
      {""id"": ""Mute""},
      null,
      {""id"": ""Find"", ""label"": ""Find...""},
      {""id"": ""FindAgain"", ""label"": ""Find Again""},
      {""id"": ""Copy""},
      {""id"": ""CopyAgain"", ""label"": ""Copy Again""},
      {""id"": ""CopySVG"", ""label"": ""Copy SVG""},
      {""id"": ""ViewSVG"", ""label"": ""View SVG""},
      {""id"": ""ViewSource"", ""label"": ""View Source""},
      {""id"": ""SaveAs"", ""label"": ""Save As""},
      null,
      {""id"": ""Help""},
      {""id"": ""About"", ""label"": ""About Adobe CVG Viewer...""}
    ]
  }
}
";

// Turn the JSON into C# objects
MenuData? data = JsonSerializer.Deserialize<MenuData>(json);

// Start creating the <menu> XML structure
var menuXml = new XElement("menu");

// Add the header if it exists
if (data?.menu?.header != null)
{
    menuXml.Add(new XElement("header", data.menu.header));
}

// Add menu items
if (data?.menu?.items != null)
{
    foreach (var item in data.menu.items)
    {
        if (item == null)
        {
            // JSON null to <separator/>
            menuXml.Add(new XElement("separator"));
        }
        else
        {
            // Build <item> tag
            var xmlItem = new XElement("item",
                new XAttribute("action", item.id ?? ""),
                new XAttribute("id", item.id ?? "")
            );

            // Inner text = label (if it exists), otherwise id
            xmlItem.Value = item.label ?? item.id ?? "";

            menuXml.Add(xmlItem);
        }
    }
}

// Print the finished XML
Console.WriteLine(menuXml);

// The top-level "menu" object in the JSON
public class MenuData
{
    public Menu? menu { get; set; }
}

// Holds the menu header and the list of items
public class Menu
{
    public string? header { get; set; }

    public List<MenuItem?>? items { get; set; }
}

// Represents a menu item
public class MenuItem
{
    public string? id { get; set; }
    public string? label { get; set; }
}