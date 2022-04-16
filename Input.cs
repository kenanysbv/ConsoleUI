using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleUI;

namespace ConsoleUI
{
    internal class Input : Element
    {
        public string? Data { get; set; } = null;

        public string Text { get; set; }

        public ConsoleColor TextColor { get; set; } = ConsoleColor.White;

        public bool Selected { get; set; } = false;

        public Input(string name, string text, Location location) : base(name, location) => Text = text;

        public Input(string name, string text, Location location, ConsoleColor textColor) : base(name, location) { Text = text; TextColor = textColor; }

        public override void Run()
        {
            if (AutoCenter)
                UpdateLocation();
            GoToLocation();
            if (Selected)
            {
                if (Data == null)
                {
                    Console.ForegroundColor = TextColor;
                    Console.Write(Text);
                    Console.ResetColor();
                    Data = Console.ReadLine();
                    if (Data == null)
                        Data = default;
                    return;
                }

            }
            Console.ForegroundColor = TextColor;
            Console.WriteLine($"{Text} {Data}");
            Console.ResetColor();
        }

        public override void UpdateLocation() => Location.Space = UI.FindCenterText(Location.Space, Text.Length);

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Text: {Text}\nData: {Data} \nTextColor: {TextColor}");

        }
    }
}
