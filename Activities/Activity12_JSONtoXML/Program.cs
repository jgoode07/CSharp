using System;
using System.Text.Json;

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