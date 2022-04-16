using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Button : Element
    {
        public string Text { get; set; }

        public bool Clicked { get; set; }

        public ConsoleColor TextColor { get; set; } = ConsoleColor.White;

        public ConsoleColor TextHoverColor { get; set; } = ConsoleColor.DarkCyan;


        public Button(string name, Location location, string text, ConsoleColor textColor, ConsoleColor textHoverColor) : base(name, location)
        {
            Text = text;
            TextColor = textColor;
            TextHoverColor = textHoverColor;
        }

        public Button(string name, Location location, string text) : base(name, location) => Text = text;




        public void Click() => Clicked = true;

        public override void Run()
        {
            if (AutoCenter)
                UptodateLocation();
            GoToLocation();
            Console.ForegroundColor = Clicked ? TextHoverColor : TextColor;
            Console.Write($"{Text} ");
            Console.ResetColor();
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Clicked: {Clicked} \nText: {Text} \nTextColor: {TextColor}\n");


        }

        public override void UptodateLocation()
        {
            this.Location.Space = UI.FindCenterText(Location.Space, Text.Length);

        }


    }
}
