using ConsoleUI;

namespace ConsoleUI
{
    public class Label : Element
    {

        public Label(string name, Location location, string text, string value, ConsoleColor textColor, ConsoleColor valueColor) : base(name, location, text, value, textColor, valueColor) { }
        public Label(string name, Location.Locations location, string text, string value, ConsoleColor textColor, ConsoleColor valueColor) : base(name, location, text, value, textColor, valueColor) { }



        public Label(string name, Location location, string text, string value) : base(name, location, text, value) { }
        public Label(string name, Location.Locations location, string text, string value) : base(name, location, text, value) { }



        public void ChangeText(string text) => Text = text;
        public void ChangeValue(string value) => Value = value;

    }
}
