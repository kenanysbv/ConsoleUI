using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Button : Element
    {
        public bool Clicked { get; set; }

        public Button(string name, Location location, string text, string value, ConsoleColor textColor, ConsoleColor textHoverColor, ConsoleColor valueColor, ConsoleColor valueHoverColor) : base(name, location, text, value, textColor, textHoverColor, valueColor, valueHoverColor) { }
        public Button(string name, Location location, string text, string value) : base(name, location, text, value) { }

        public void Click() => Clicked = true;


    }
}
