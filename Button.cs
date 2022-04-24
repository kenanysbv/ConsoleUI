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

        /// <summary>
        /// Searches and returns the book identified by the specified ISBN.
        /// </summary>
        /// <param name="isbn">The <see cref="System.String"/> instance that represents the ISBN of the book to search for.</param>
        /// <returns>An instance of the <see cref="UI"/> class representing the element with the specified ISBN, if found; otherwise, <c>null</c>.</returns>
        /// <exception cref="System.ArgumentNullException">
        /// <paramref name="isbn"/> is <c>null</c>.
        /// </exception>
        /// <exception cref="System.ArgumentException">
        /// <paramref name="isbn"/> is an empty or white-space string.
        /// </exception>
        public override void Run()
        {
            if (AutoCenter)
                UpdateLocation();
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

        public override void UpdateLocation() => Location.Space = Base.FindCenterText(Location.Space, Text.Length);

    }
}
