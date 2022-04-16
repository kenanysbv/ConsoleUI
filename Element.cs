﻿using ConsoleUI;

namespace ConsoleUI
{

    public class Element : UI
    {

        public string Name { get; set; }
        public Location Location { get; set; }
        public string Text { get; set; }
        public string Value { get; set; }

        public ConsoleColor TextColor { get; set; } = ConsoleColor.White;
        public ConsoleColor ValueColor { get; set; } = ConsoleColor.Green;
        public ConsoleColor TextHoverColor { get; set; } = ConsoleColor.DarkCyan;
        public ConsoleColor ValueHoverColor { get; set; } = ConsoleColor.DarkGreen;




        public Element(string name, Location location, string text, string value, ConsoleColor textColor, ConsoleColor textHoverColor, ConsoleColor valueColor, ConsoleColor valueHoverColor)
        {
            Name = name;
            Location = location;
            Text = text;
            Value = value;
            TextColor = textColor;
            TextHoverColor = textHoverColor;
            ValueColor = valueColor;
            ValueHoverColor = valueHoverColor;
        }
        public Element(string name, Location.Locations location, string text, string value, ConsoleColor textColor, ConsoleColor textHoverColor, ConsoleColor valueColor, ConsoleColor valueHoverColor)
        {
            Name = name;
            Location.LocationDefault = location;
            Text = text;
            Value = value;
            TextColor = textColor;
            TextHoverColor = textHoverColor;
            ValueColor = valueColor;
            ValueHoverColor = valueHoverColor;
        }


        public Element(string name, Location.Locations location, string text, string value, ConsoleColor textColor, ConsoleColor valueColor)
        {
            Name = name;
            Location.LocationDefault = location;
            Text = text;
            Value = value;
            TextColor = textColor;
            ValueColor = valueColor;
            TextHoverColor = TextColor;
            ValueHoverColor = ValueColor;
        }
        public Element(string name, Location location, string text, string value, ConsoleColor textColor, ConsoleColor valueColor)
        {
            Name = name;
            Location = location;
            Text = text;
            Value = value;
            TextColor = textColor;
            ValueColor = valueColor;
            TextHoverColor = TextColor;
            ValueHoverColor = ValueColor;
        }


        public Element(string name, Location location, string text, string value)
        {
            Name = name;
            Location = location;
            Text = text;
            Value = value;
        }
        public Element(string name, Location.Locations location, string text, string value)
        {
            Name = name;
            Location.LocationDefault = location;
            Text = text;
            Value = value;
        }
    }

}